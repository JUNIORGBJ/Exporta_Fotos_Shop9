namespace ExportaFotosShop9
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblPastaDestino;
        private Button btnEscolherPasta;
        private Button btnExportarFotos;
        private Button btnSobre;
        private ProgressBar progressBar;
        private Label lblStatus;
        private GroupBox groupBoxFiltros;
        private CheckBox chkNormal;
        private CheckBox chkGrade;
        private CheckBox chkLote;
        private CheckBox chkServico;
        private CheckBox chkSerie;
        private CheckBox chkEdicao;
        private Button btnSelecionarTodos;
        private Button btnDesmarcarTodos;
        private GroupBox groupBoxEstoque;
        private RadioButton rbEstoquePositivo;
        private RadioButton rbEstoqueZeradoNegativo;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblTitulo = new Label();
            lblPastaDestino = new Label();
            btnEscolherPasta = new Button();
            btnExportarFotos = new Button();
            btnSobre = new Button();
            progressBar = new ProgressBar();
            lblStatus = new Label();
            groupBoxFiltros = new GroupBox();
            btnDesmarcarTodos = new Button();
            btnSelecionarTodos = new Button();
            chkEdicao = new CheckBox();
            chkSerie = new CheckBox();
            chkServico = new CheckBox();
            chkLote = new CheckBox();
            chkGrade = new CheckBox();
            chkNormal = new CheckBox();
            groupBoxEstoque = new GroupBox();
            rbEstoqueZeradoNegativo = new RadioButton();
            rbEstoquePositivo = new RadioButton();
            groupBoxFiltros.SuspendLayout();
            groupBoxEstoque.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(50, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(357, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Exportar Fotos do Sistema Shop9";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPastaDestino
            // 
            lblPastaDestino.AutoSize = true;
            lblPastaDestino.BackColor = Color.Transparent;
            lblPastaDestino.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPastaDestino.ForeColor = Color.Black;
            lblPastaDestino.Location = new Point(30, 70);
            lblPastaDestino.Name = "lblPastaDestino";
            lblPastaDestino.Size = new Size(193, 15);
            lblPastaDestino.TabIndex = 1;
            lblPastaDestino.Text = "📁 Pasta Destino: Não selecionada";
            // 
            // btnEscolherPasta
            // 
            btnEscolherPasta.BackColor = Color.FromArgb(45, 45, 65);
            btnEscolherPasta.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 255);
            btnEscolherPasta.FlatAppearance.BorderSize = 2;
            btnEscolherPasta.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 120, 200);
            btnEscolherPasta.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 80);
            btnEscolherPasta.FlatStyle = FlatStyle.Flat;
            btnEscolherPasta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEscolherPasta.ForeColor = Color.FromArgb(220, 220, 220);
            btnEscolherPasta.Location = new Point(30, 100);
            btnEscolherPasta.Name = "btnEscolherPasta";
            btnEscolherPasta.Size = new Size(150, 35);
            btnEscolherPasta.TabIndex = 2;
            btnEscolherPasta.Text = "📁 Escolher Pasta";
            btnEscolherPasta.UseVisualStyleBackColor = false;
            btnEscolherPasta.Click += btnEscolherPasta_Click;
            // 
            // btnExportarFotos
            // 
            btnExportarFotos.BackColor = Color.Transparent;
            btnExportarFotos.FlatAppearance.BorderColor = Color.FromArgb(0, 200, 0);
            btnExportarFotos.FlatAppearance.BorderSize = 2;
            btnExportarFotos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 120, 0);
            btnExportarFotos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 180, 0);
            btnExportarFotos.FlatStyle = FlatStyle.Flat;
            btnExportarFotos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportarFotos.ForeColor = Color.White;
            btnExportarFotos.Location = new Point(200, 100);
            btnExportarFotos.Name = "btnExportarFotos";
            btnExportarFotos.Size = new Size(150, 35);
            btnExportarFotos.TabIndex = 3;
            btnExportarFotos.Text = "⚡ Exportar Fotos";
            btnExportarFotos.UseVisualStyleBackColor = false;
            btnExportarFotos.Click += btnExportarFotos_Click;
            // 
            // btnSobre
            // 
            btnSobre.BackColor = Color.FromArgb(45, 45, 65);
            btnSobre.FlatAppearance.BorderColor = Color.FromArgb(150, 150, 150);
            btnSobre.FlatAppearance.BorderSize = 2;
            btnSobre.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 120);
            btnSobre.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 80);
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSobre.ForeColor = Color.FromArgb(220, 220, 220);
            btnSobre.Location = new Point(370, 100);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(80, 35);
            btnSobre.TabIndex = 4;
            btnSobre.Text = "ℹ️ Sobre";
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += btnSobre_Click;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(35, 35, 45);
            progressBar.ForeColor = Color.FromArgb(0, 200, 255);
            progressBar.Location = new Point(20, 390);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(440, 23);
            progressBar.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(20, 420);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Pronto";
            // 
            // groupBoxFiltros
            // 
            groupBoxFiltros.BackColor = Color.Transparent;
            groupBoxFiltros.Controls.Add(btnDesmarcarTodos);
            groupBoxFiltros.Controls.Add(btnSelecionarTodos);
            groupBoxFiltros.Controls.Add(chkEdicao);
            groupBoxFiltros.Controls.Add(chkSerie);
            groupBoxFiltros.Controls.Add(chkServico);
            groupBoxFiltros.Controls.Add(chkLote);
            groupBoxFiltros.Controls.Add(chkGrade);
            groupBoxFiltros.Controls.Add(chkNormal);
            groupBoxFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxFiltros.ForeColor = Color.Black;
            groupBoxFiltros.Location = new Point(20, 150);
            groupBoxFiltros.Name = "groupBoxFiltros";
            groupBoxFiltros.Size = new Size(440, 120);
            groupBoxFiltros.TabIndex = 5;
            groupBoxFiltros.TabStop = false;
            groupBoxFiltros.Text = "FILTROS POR TIPO DE PRODUTO";
            // 
            // btnDesmarcarTodos
            // 
            btnDesmarcarTodos.BackColor = Color.FromArgb(60, 60, 70);
            btnDesmarcarTodos.FlatAppearance.BorderColor = Color.FromArgb(255, 100, 100);
            btnDesmarcarTodos.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 80, 80);
            btnDesmarcarTodos.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 90);
            btnDesmarcarTodos.FlatStyle = FlatStyle.Flat;
            btnDesmarcarTodos.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDesmarcarTodos.ForeColor = Color.FromArgb(255, 100, 100);
            btnDesmarcarTodos.Location = new Point(160, 85);
            btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            btnDesmarcarTodos.Size = new Size(124, 25);
            btnDesmarcarTodos.TabIndex = 7;
            btnDesmarcarTodos.Text = "❌ Desmarcar Todos";
            btnDesmarcarTodos.UseVisualStyleBackColor = false;
            btnDesmarcarTodos.Click += btnDesmarcarTodos_Click;
            // 
            // btnSelecionarTodos
            // 
            btnSelecionarTodos.BackColor = Color.FromArgb(60, 60, 70);
            btnSelecionarTodos.FlatAppearance.BorderColor = Color.FromArgb(100, 255, 100);
            btnSelecionarTodos.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 255, 80);
            btnSelecionarTodos.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 90);
            btnSelecionarTodos.FlatStyle = FlatStyle.Flat;
            btnSelecionarTodos.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnSelecionarTodos.ForeColor = Color.FromArgb(100, 255, 100);
            btnSelecionarTodos.Location = new Point(15, 85);
            btnSelecionarTodos.Name = "btnSelecionarTodos";
            btnSelecionarTodos.Size = new Size(135, 25);
            btnSelecionarTodos.TabIndex = 6;
            btnSelecionarTodos.Text = "✅ Selecionar Todos";
            btnSelecionarTodos.UseVisualStyleBackColor = false;
            btnSelecionarTodos.Click += btnSelecionarTodos_Click;
            // 
            // chkEdicao
            // 
            chkEdicao.AutoSize = true;
            chkEdicao.ForeColor = Color.FromArgb(220, 220, 220);
            chkEdicao.Location = new Point(160, 50);
            chkEdicao.Name = "chkEdicao";
            chkEdicao.Size = new Size(61, 19);
            chkEdicao.TabIndex = 5;
            chkEdicao.Text = "Edição";
            chkEdicao.UseVisualStyleBackColor = true;
            // 
            // chkSerie
            // 
            chkSerie.AutoSize = true;
            chkSerie.ForeColor = Color.FromArgb(220, 220, 220);
            chkSerie.Location = new Point(90, 50);
            chkSerie.Name = "chkSerie";
            chkSerie.Size = new Size(55, 19);
            chkSerie.TabIndex = 4;
            chkSerie.Text = "Série";
            chkSerie.UseVisualStyleBackColor = true;
            // 
            // chkServico
            // 
            chkServico.AutoSize = true;
            chkServico.ForeColor = Color.FromArgb(220, 220, 220);
            chkServico.Location = new Point(15, 50);
            chkServico.Name = "chkServico";
            chkServico.Size = new Size(68, 19);
            chkServico.TabIndex = 3;
            chkServico.Text = "Serviço";
            chkServico.UseVisualStyleBackColor = true;
            // 
            // chkLote
            // 
            chkLote.AutoSize = true;
            chkLote.ForeColor = Color.FromArgb(220, 220, 220);
            chkLote.Location = new Point(160, 25);
            chkLote.Name = "chkLote";
            chkLote.Size = new Size(51, 19);
            chkLote.TabIndex = 2;
            chkLote.Text = "Lote";
            chkLote.UseVisualStyleBackColor = true;
            // 
            // chkGrade
            // 
            chkGrade.AutoSize = true;
            chkGrade.ForeColor = Color.FromArgb(220, 220, 220);
            chkGrade.Location = new Point(90, 25);
            chkGrade.Name = "chkGrade";
            chkGrade.Size = new Size(60, 19);
            chkGrade.TabIndex = 1;
            chkGrade.Text = "Grade";
            chkGrade.UseVisualStyleBackColor = true;
            // 
            // chkNormal
            // 
            chkNormal.AutoSize = true;
            chkNormal.ForeColor = Color.FromArgb(220, 220, 220);
            chkNormal.Location = new Point(15, 25);
            chkNormal.Name = "chkNormal";
            chkNormal.Size = new Size(67, 19);
            chkNormal.TabIndex = 0;
            chkNormal.Text = "Normal";
            chkNormal.UseVisualStyleBackColor = true;
            // 
            // groupBoxEstoque
            // 
            groupBoxEstoque.BackColor = Color.Transparent;
            groupBoxEstoque.Controls.Add(rbEstoqueZeradoNegativo);
            groupBoxEstoque.Controls.Add(rbEstoquePositivo);
            groupBoxEstoque.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxEstoque.ForeColor = Color.Black;
            groupBoxEstoque.Location = new Point(20, 280);
            groupBoxEstoque.Name = "groupBoxEstoque";
            groupBoxEstoque.Size = new Size(440, 80);
            groupBoxEstoque.TabIndex = 8;
            groupBoxEstoque.TabStop = false;
            groupBoxEstoque.Text = "FILTRO POR ESTOQUE";
            // 
            // rbEstoqueZeradoNegativo
            // 
            rbEstoqueZeradoNegativo.AutoSize = true;
            rbEstoqueZeradoNegativo.ForeColor = Color.FromArgb(220, 220, 220);
            rbEstoqueZeradoNegativo.Location = new Point(15, 50);
            rbEstoqueZeradoNegativo.Name = "rbEstoqueZeradoNegativo";
            rbEstoqueZeradoNegativo.Size = new Size(229, 19);
            rbEstoqueZeradoNegativo.TabIndex = 1;
            rbEstoqueZeradoNegativo.TabStop = true;
            rbEstoqueZeradoNegativo.Text = "Somente - Estoque Zerado/Negativo";
            rbEstoqueZeradoNegativo.UseVisualStyleBackColor = true;
            // 
            // rbEstoquePositivo
            // 
            rbEstoquePositivo.AutoSize = true;
            rbEstoquePositivo.ForeColor = Color.FromArgb(220, 220, 220);
            rbEstoquePositivo.Location = new Point(15, 25);
            rbEstoquePositivo.Name = "rbEstoquePositivo";
            rbEstoquePositivo.Size = new Size(178, 19);
            rbEstoquePositivo.TabIndex = 0;
            rbEstoquePositivo.TabStop = true;
            rbEstoquePositivo.Text = "Somente - Estoque Positivo";
            rbEstoquePositivo.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 25);
            BackgroundImage = Properties.Resources.Fundo;
            ClientSize = new Size(480, 450);
            Controls.Add(groupBoxEstoque);
            Controls.Add(groupBoxFiltros);
            Controls.Add(lblStatus);
            Controls.Add(progressBar);
            Controls.Add(btnSobre);
            Controls.Add(btnExportarFotos);
            Controls.Add(btnEscolherPasta);
            Controls.Add(lblPastaDestino);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(220, 220, 220);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exportar Fotos Shop9";
            groupBoxFiltros.ResumeLayout(false);
            groupBoxFiltros.PerformLayout();
            groupBoxEstoque.ResumeLayout(false);
            groupBoxEstoque.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}