using System;
using System.IO;
using System.Xml;

namespace ExportaFotosShop9
{
    public class DatabaseConfig
    {
        public string Servidor { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Banco { get; set; } = "S9_Real";

        public static DatabaseConfig LerConfigDB()
        {
            var config = new DatabaseConfig();
            
            try
            {
                string caminhoArquivo = @"C:\Shop9\ArqID9.TXT";
                
                if (!File.Exists(caminhoArquivo))
                {
                    throw new FileNotFoundException($"Arquivo ArqID9.TXT não encontrado em: {caminhoArquivo}");
                }

                var xmlDoc = new XmlDocument();
                xmlDoc.Load(caminhoArquivo);

                var servidorNode = xmlDoc.SelectSingleNode("//CONEXAO/Servidor");
                var usuarioNode = xmlDoc.SelectSingleNode("//CONEXAO/Usuario");
                var senhaNode = xmlDoc.SelectSingleNode("//CONEXAO/Senha");

                if (servidorNode != null)
                    config.Servidor = servidorNode.InnerText.Trim();
                
                if (usuarioNode != null)
                    config.Usuario = usuarioNode.InnerText.Trim();
                
                if (senhaNode != null)
                    config.Senha = senhaNode.InnerText.Trim();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao ler configuração do banco: {ex.Message}");
            }

            return config;
        }

        public string GetConnectionString()
        {
            return $"Server=tcp:{Servidor};Database={Banco};User Id={Usuario};Password={Senha};";
        }
    }
}