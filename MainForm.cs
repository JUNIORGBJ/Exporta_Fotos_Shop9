using System;
using System.IO;
using System.Windows.Forms;

namespace ExportaFotosShop9
{
    public partial class MainForm : Form
    {
        private PhotoExporter? photoExporter;
        private string? pastaDestino;

        public MainForm()
        {
            InitializeComponent();
            
            try
            {
                photoExporter = new PhotoExporter();
                
                // Selecionar todos os tipos por padrão
                chkNormal.Checked = true;
                chkGrade.Checked = true;
                chkLote.Checked = true;
                chkServico.Checked = true;
                chkSerie.Checked = true;
                chkEdicao.Checked = true;
                
                // Selecionar filtro de estoque positivo por padrão
                rbEstoquePositivo.Checked = true;
                
                // Inicializar sem pasta de destino
                lblPastaDestino.Text = "Nenhuma pasta selecionada";
                btnExportarFotos.Enabled = false; // Desabilitar até selecionar pasta
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEscolherPasta_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecione a pasta de destino para as fotos";
                folderDialog.SelectedPath = pastaDestino;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    pastaDestino = folderDialog.SelectedPath;
                    lblPastaDestino.Text = $"Pasta de destino: {pastaDestino}";
                    btnExportarFotos.Enabled = true; // Habilitar exportação após selecionar pasta
                    
                    // Criar pasta se não existir
                    Directory.CreateDirectory(pastaDestino);
                }
            }
        }

        private async void btnExportarFotos_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se pasta foi selecionada
                if (string.IsNullOrEmpty(pastaDestino))
                {
                    MessageBox.Show("Selecione uma pasta de destino antes de exportar.", "Aviso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar se pelo menos um tipo está selecionado
                var tiposSelecionados = ObterTiposSelecionados();
                if (tiposSelecionados.Count == 0)
                {
                    MessageBox.Show("Selecione pelo menos um tipo de produto para exportar.", "Aviso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                btnExportarFotos.Enabled = false;
                btnEscolherPasta.Enabled = false;
                groupBoxFiltros.Enabled = false;
                groupBoxEstoque.Enabled = false;
                progressBar.Value = 0;
                progressBar.Visible = true;
                lblStatus.Text = "Iniciando exportação...";
                lblStatus.Visible = true;

                var progress = new Progress<(int current, int total, string message)>(report =>
                {
                    if (report.total > 0)
                    {
                        progressBar.Maximum = report.total;
                        progressBar.Value = report.current;
                    }
                    lblStatus.Text = report.message;
                    Application.DoEvents();
                });

                // Obter filtro de estoque selecionado
                bool incluirEstoqueZerado = rbEstoqueZeradoNegativo.Checked;

                if (photoExporter != null)
                {
                    await photoExporter.ExportarFotosAsync(pastaDestino, tiposSelecionados, incluirEstoqueZerado, progress);
                }

                MessageBox.Show("Exportação concluída com sucesso!", "Sucesso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro durante a exportação: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnExportarFotos.Enabled = !string.IsNullOrEmpty(pastaDestino); // Só habilitar se pasta estiver selecionada
                btnEscolherPasta.Enabled = true;
                groupBoxFiltros.Enabled = true;
                groupBoxEstoque.Enabled = true;
                progressBar.Visible = false;
                lblStatus.Visible = false;
            }
        }

        private List<string> ObterTiposSelecionados()
        {
            var tipos = new List<string>();
            
            if (chkNormal.Checked) tipos.Add("N");
            if (chkGrade.Checked) tipos.Add("G");
            if (chkLote.Checked) tipos.Add("L");
            if (chkServico.Checked) tipos.Add("V");
            if (chkSerie.Checked) tipos.Add("S");
            if (chkEdicao.Checked) tipos.Add("E");
            
            return tipos;
        }

        private void btnSelecionarTodos_Click(object sender, EventArgs e)
        {
            chkNormal.Checked = true;
            chkGrade.Checked = true;
            chkLote.Checked = true;
            chkServico.Checked = true;
            chkSerie.Checked = true;
            chkEdicao.Checked = true;
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            chkNormal.Checked = false;
            chkGrade.Checked = false;
            chkLote.Checked = false;
            chkServico.Checked = false;
            chkSerie.Checked = false;
            chkEdicao.Checked = false;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }
        }
    }
}