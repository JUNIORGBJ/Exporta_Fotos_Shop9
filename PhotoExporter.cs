using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExportaFotosShop9
{
    public class PhotoExporter
    {
        public async Task ExportarFotosAsync(string pastaDestino, List<string> tiposSelecionados, bool incluirEstoqueZerado, IProgress<(int current, int total, string message)> progress)
        {
            if (tiposSelecionados == null || tiposSelecionados.Count == 0)
            {
                throw new ArgumentException("Pelo menos um tipo de produto deve ser selecionado.");
            }

            try
            {
                // Criar pasta de destino se não existir
                Directory.CreateDirectory(pastaDestino);

                // Ler configuração do banco de dados
                var config = DatabaseConfig.LerConfigDB();
                var connectionString = config.GetConnectionString();

                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();

                // Construir a cláusula WHERE com os tipos selecionados
                var tiposParametros = string.Join(",", tiposSelecionados.Select((t, i) => $"@tipo{i}"));
                
                // Construir filtro de estoque
                string filtroEstoque = incluirEstoqueZerado ? 
                    "AND EA.Qtde_Estoque_Atual <= 0" : 
                    "AND EA.Qtde_Estoque_Atual > 0";

                var sql = $@"
                    SELECT
                        PS.Codigo,
                        PS.Codigo_Adicional1,
                        PS.Nome,
                        PS.Tipo,
                        EA.Qtde_Estoque_Atual,
                        PSF.Foto
                    FROM
                        Prod_Serv PS
                        JOIN Prod_Serv_Fotos PSF ON PS.Ordem = PSF.Ordem_Prod_Serv
                        JOIN Estoque_Atual EA ON EA.Ordem_Prod_Serv = PS.Ordem
                        JOIN Filiais F ON F.Ordem = EA.Ordem_Filial
                    WHERE
                        PS.Tipo IN ({tiposParametros})
                        AND F.Ordem = 1
                        {filtroEstoque}
                        AND PSF.Foto IS NOT NULL
                        AND PSF.Foto != ''
                    ORDER BY PS.Codigo";

                using var command = new SqlCommand(sql, connection);
                
                // Adicionar parâmetros para cada tipo selecionado
                for (int i = 0; i < tiposSelecionados.Count; i++)
                {
                    command.Parameters.AddWithValue($"@tipo{i}", tiposSelecionados[i]);
                }

                using var reader = await command.ExecuteReaderAsync();

                var resultados = new List<(string codigo, string codAdic, string nome, string tipo, decimal estoque, byte[] foto)>();

                while (await reader.ReadAsync())
                {
                    var codigo = reader["Codigo"]?.ToString() ?? "";
                    var codAdic = reader["Codigo_Adicional1"]?.ToString() ?? "";
                    var nome = reader["Nome"]?.ToString() ?? "";
                    var tipo = reader["Tipo"]?.ToString() ?? "";
                    var estoque = Convert.ToDecimal(reader["Qtde_Estoque_Atual"]);
                    var fotoBase64 = reader["Foto"]?.ToString();

                    if (!string.IsNullOrEmpty(fotoBase64))
                    {
                        try
                        {
                            var fotoBytes = Convert.FromBase64String(fotoBase64);
                            resultados.Add((codigo, codAdic, nome, tipo, estoque, fotoBytes));
                        }
                        catch (FormatException)
                        {
                            // Ignorar fotos com formato Base64 inválido
                            continue;
                        }
                    }
                }

                if (resultados.Count == 0)
                {
                    progress.Report((0, 0, "Nenhuma foto encontrada com os critérios selecionados."));
                    return;
                }

                var total = resultados.Count;
                progress.Report((0, total, $"Encontradas {total} fotos para exportar"));

                // Exportar as fotos
                for (int i = 0; i < resultados.Count; i++)
                {
                    var (codigo, codAdic, nome, tipo, estoque, foto) = resultados[i];

                    // Determinar extensão da imagem
                    var extensao = DeterminarExtensao(foto);
                    var nomeArquivo = $"{codigo}_{LimparNome(nome)}.{extensao}";
                    var caminhoCompleto = Path.Combine(pastaDestino, nomeArquivo);

                    try
                    {
                        await File.WriteAllBytesAsync(caminhoCompleto, foto);
                        string statusEstoque = incluirEstoqueZerado ? $"Estoque: {estoque}" : $"Estoque: {estoque}";
                        progress.Report((i + 1, total, $"Exportando: {nomeArquivo} (Tipo: {ObterDescricaoTipo(tipo)}, {statusEstoque})"));
                    }
                    catch (Exception ex)
                    {
                        progress.Report((i + 1, total, $"Erro ao salvar {nomeArquivo}: {ex.Message}"));
                    }
                }

                progress.Report((total, total, $"Exportação concluída! {total} fotos salvas em {pastaDestino}"));
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro durante a exportação: {ex.Message}", ex);
            }
        }

        private string ObterDescricaoTipo(string tipo)
        {
            return tipo switch
            {
                "N" => "Normal",
                "G" => "Grade",
                "L" => "Lote",
                "V" => "Serviço",
                "S" => "Série",
                "E" => "Edição",
                _ => tipo
            };
        }

        private static string DeterminarExtensao(byte[] imageBytes)
        {
            if (imageBytes.Length >= 2)
            {
                // Verificar assinatura JPEG
                if (imageBytes[0] == 0xFF && imageBytes[1] == 0xD8)
                    return "jpg";
                
                // Verificar assinatura PNG
                if (imageBytes.Length >= 8 && 
                    imageBytes[0] == 0x89 && imageBytes[1] == 0x50 && 
                    imageBytes[2] == 0x4E && imageBytes[3] == 0x47)
                    return "png";
                
                // Verificar assinatura BMP
                if (imageBytes[0] == 0x42 && imageBytes[1] == 0x4D)
                    return "bmp";
            }
            
            // Padrão para JPEG se não conseguir determinar
            return "jpg";
        }

        private static string LimparNome(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return "sem_nome";

            // Substituir barras por x
            texto = texto.Replace("\\", "x").Replace("/", "x");
            
            // Remover caracteres inválidos para nomes de arquivo
            texto = Regex.Replace(texto, @"[<>:""/\\|?*]", "_");
            
            // Limitar tamanho do nome
            if (texto.Length > 100)
                texto = texto.Substring(0, 100);
            
            return texto;
        }
    }
}