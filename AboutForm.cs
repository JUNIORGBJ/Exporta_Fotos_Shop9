using System;
using System.Reflection;
using System.Windows.Forms;

namespace ExportaFotosShop9
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var version = assembly.GetName().Version;
            
            lblVersao.Text = $"Versão: {version?.ToString() ?? "1.0"}";
            lblCopyright.Text = $"© {DateTime.Now.Year} - Gilson Barbosa Junior";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}