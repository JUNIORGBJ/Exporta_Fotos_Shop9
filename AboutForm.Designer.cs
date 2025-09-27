namespace ExportaFotosShop9
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblDescricao;
        private Label lblVersao;
        private Label lblCopyright;
        private Label lblDesenvolvedor;
        private Button btnOK;

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
            lblTitulo = new Label();
            lblDescricao = new Label();
            lblVersao = new Label();
            lblCopyright = new Label();
            lblDesenvolvedor = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(333, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🚀 Exportador de Fotos Shop9";
            // 
            // lblDescricao
            // 
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 9F);
            lblDescricao.ForeColor = Color.FromArgb(220, 220, 220);
            lblDescricao.Location = new Point(30, 60);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(320, 40);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "💻 Aplicativo para exportar fotos de produtos do sistema Shop9 para uma pasta local no computador.";
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.BackColor = Color.Transparent;
            lblVersao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVersao.ForeColor = Color.FromArgb(100, 255, 100);
            lblVersao.Location = new Point(30, 120);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(83, 15);
            lblVersao.TabIndex = 2;
            lblVersao.Text = "🔢 Versão: 1.0";
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.BackColor = Color.Transparent;
            lblCopyright.Font = new Font("Segoe UI", 9F);
            lblCopyright.ForeColor = Color.Black;
            lblCopyright.Location = new Point(30, 145);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(169, 15);
            lblCopyright.TabIndex = 3;
            lblCopyright.Text = "© 2025 - Gilson Barbosa Junior";
            // 
            // lblDesenvolvedor
            // 
            lblDesenvolvedor.BackColor = Color.Transparent;
            lblDesenvolvedor.Font = new Font("Segoe UI", 9F);
            lblDesenvolvedor.ForeColor = Color.FromArgb(220, 220, 220);
            lblDesenvolvedor.Location = new Point(30, 175);
            lblDesenvolvedor.Name = "lblDesenvolvedor";
            lblDesenvolvedor.Size = new Size(320, 30);
            lblDesenvolvedor.TabIndex = 4;
            lblDesenvolvedor.Text = "⚡ Desenvolvido para facilitar a exportação de imagens de produtos do Sistema Shop9.";
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.FromArgb(0, 120, 215);
            btnOK.FlatAppearance.BorderColor = Color.FromArgb(0, 200, 255);
            btnOK.FlatAppearance.BorderSize = 2;
            btnOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 160);
            btnOK.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 150, 255);
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(275, 220);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 30);
            btnOK.TabIndex = 5;
            btnOK.Text = "✅ OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 25);
            BackgroundImage = Properties.Resources.Fundo;
            ClientSize = new Size(380, 270);
            Controls.Add(btnOK);
            Controls.Add(lblDesenvolvedor);
            Controls.Add(lblCopyright);
            Controls.Add(lblVersao);
            Controls.Add(lblDescricao);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(220, 220, 220);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "🚀 Sobre o Aplicativo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}