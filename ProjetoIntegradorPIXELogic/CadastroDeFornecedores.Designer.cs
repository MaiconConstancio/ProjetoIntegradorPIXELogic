namespace ProjetoIntegradorPIXELogic
{
    partial class CadastroDeFornecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeFornecedores));
            lblCadastroDeFornecedores = new Label();
            lblFornecedor = new Label();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            lblEndereco = new Label();
            lblTelefone = new Label();
            lblCNPJ = new Label();
            lblCEP = new Label();
            lblNumero = new Label();
            lblCidade = new Label();
            LogoComoWallpaper = new PictureBox();
            txtFornecedor = new TextBox();
            txtEndereço = new TextBox();
            maskedCNJP = new MaskedTextBox();
            maskedCEP = new MaskedTextBox();
            maskedNumero = new MaskedTextBox();
            txtCidade = new TextBox();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            maskedTelefone = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).BeginInit();
            SuspendLayout();
            // 
            // lblCadastroDeFornecedores
            // 
            lblCadastroDeFornecedores.AutoSize = true;
            lblCadastroDeFornecedores.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroDeFornecedores.ForeColor = Color.Cyan;
            lblCadastroDeFornecedores.Location = new Point(225, 59);
            lblCadastroDeFornecedores.Name = "lblCadastroDeFornecedores";
            lblCadastroDeFornecedores.Size = new Size(351, 37);
            lblCadastroDeFornecedores.TabIndex = 26;
            lblCadastroDeFornecedores.Text = "Cadastro de Fornecedores";
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblFornecedor.ForeColor = Color.FromArgb(63, 136, 254);
            lblFornecedor.Location = new Point(130, 125);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(143, 30);
            lblFornecedor.TabIndex = 24;
            lblFornecedor.Text = " Fornecedor:";
            lblFornecedor.Click += lblNovaSenha_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 12;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(349, 384);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 32);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco.ForeColor = Color.FromArgb(63, 136, 254);
            lblEndereco.Location = new Point(175, 299);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(115, 30);
            lblEndereco.TabIndex = 27;
            lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.ForeColor = Color.FromArgb(63, 136, 254);
            lblTelefone.Location = new Point(200, 159);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(106, 30);
            lblTelefone.TabIndex = 29;
            lblTelefone.Text = "Telefone:";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblCNPJ.ForeColor = Color.FromArgb(63, 136, 254);
            lblCNPJ.Location = new Point(241, 195);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(73, 30);
            lblCNPJ.TabIndex = 31;
            lblCNPJ.Text = "CNPJ:";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblCEP.ForeColor = Color.FromArgb(63, 136, 254);
            lblCEP.Location = new Point(278, 230);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(59, 30);
            lblCEP.TabIndex = 33;
            lblCEP.Text = "CEP:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.ForeColor = Color.FromArgb(63, 136, 254);
            lblNumero.Location = new Point(223, 265);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(103, 30);
            lblNumero.TabIndex = 35;
            lblNumero.Text = "Número:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.ForeColor = Color.FromArgb(63, 136, 254);
            lblCidade.Location = new Point(217, 335);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(91, 30);
            lblCidade.TabIndex = 37;
            lblCidade.Text = "Cidade:";
            lblCidade.Click += lblCidade_Click;
            // 
            // LogoComoWallpaper
            // 
            LogoComoWallpaper.Dock = DockStyle.Fill;
            LogoComoWallpaper.Image = (Image)resources.GetObject("LogoComoWallpaper.Image");
            LogoComoWallpaper.Location = new Point(0, 0);
            LogoComoWallpaper.Name = "LogoComoWallpaper";
            LogoComoWallpaper.Size = new Size(800, 450);
            LogoComoWallpaper.TabIndex = 39;
            LogoComoWallpaper.TabStop = false;
            LogoComoWallpaper.Click += LogoComoWallpaper_Click;
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = Color.FromArgb(53, 81, 142);
            txtFornecedor.BorderStyle = BorderStyle.FixedSingle;
            txtFornecedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFornecedor.ForeColor = Color.Cyan;
            txtFornecedor.Location = new Point(275, 121);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(296, 29);
            txtFornecedor.TabIndex = 1;
            // 
            // txtEndereço
            // 
            txtEndereço.BackColor = Color.FromArgb(53, 81, 142);
            txtEndereço.BorderStyle = BorderStyle.FixedSingle;
            txtEndereço.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereço.ForeColor = Color.Cyan;
            txtEndereço.Location = new Point(292, 296);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(263, 29);
            txtEndereço.TabIndex = 6;
            // 
            // maskedCNJP
            // 
            maskedCNJP.BackColor = Color.FromArgb(53, 81, 142);
            maskedCNJP.BorderStyle = BorderStyle.FixedSingle;
            maskedCNJP.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedCNJP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedCNJP.ForeColor = Color.Cyan;
            maskedCNJP.Location = new Point(316, 191);
            maskedCNJP.Mask = "00.000.000/0001-00";
            maskedCNJP.Name = "maskedCNJP";
            maskedCNJP.Size = new Size(214, 29);
            maskedCNJP.TabIndex = 3;
            maskedCNJP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedCEP
            // 
            maskedCEP.BackColor = Color.FromArgb(53, 81, 142);
            maskedCEP.BorderStyle = BorderStyle.FixedSingle;
            maskedCEP.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedCEP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedCEP.ForeColor = Color.Cyan;
            maskedCEP.Location = new Point(339, 226);
            maskedCEP.Mask = "00000-00";
            maskedCEP.Name = "maskedCEP";
            maskedCEP.Size = new Size(168, 29);
            maskedCEP.TabIndex = 4;
            maskedCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedNumero
            // 
            maskedNumero.BackColor = Color.FromArgb(53, 81, 142);
            maskedNumero.BorderStyle = BorderStyle.FixedSingle;
            maskedNumero.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedNumero.ForeColor = Color.Cyan;
            maskedNumero.Location = new Point(328, 261);
            maskedNumero.Mask = "0000";
            maskedNumero.Name = "maskedNumero";
            maskedNumero.Size = new Size(191, 29);
            maskedNumero.TabIndex = 5;
            maskedNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCidade
            // 
            txtCidade.BackColor = Color.FromArgb(53, 81, 142);
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.ForeColor = Color.Cyan;
            txtCidade.Location = new Point(310, 331);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(227, 29);
            txtCidade.TabIndex = 7;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 12;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(714, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(74, 30);
            btnVoltar.TabIndex = 72;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // maskedTelefone
            // 
            maskedTelefone.BackColor = Color.FromArgb(53, 81, 142);
            maskedTelefone.BorderStyle = BorderStyle.FixedSingle;
            maskedTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTelefone.ForeColor = Color.Cyan;
            maskedTelefone.Location = new Point(308, 156);
            maskedTelefone.Mask = "(99) 00000-0000";
            maskedTelefone.Name = "maskedTelefone";
            maskedTelefone.Size = new Size(231, 29);
            maskedTelefone.TabIndex = 2;
            maskedTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // CadastroDeFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(txtCidade);
            Controls.Add(maskedNumero);
            Controls.Add(maskedCEP);
            Controls.Add(maskedCNJP);
            Controls.Add(maskedTelefone);
            Controls.Add(txtEndereço);
            Controls.Add(txtFornecedor);
            Controls.Add(lblCidade);
            Controls.Add(lblNumero);
            Controls.Add(lblCEP);
            Controls.Add(lblCNPJ);
            Controls.Add(lblTelefone);
            Controls.Add(lblEndereco);
            Controls.Add(lblCadastroDeFornecedores);
            Controls.Add(lblFornecedor);
            Controls.Add(btnSalvar);
            Controls.Add(LogoComoWallpaper);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroDeFornecedores";
            Text = "CadastroDeFornecedores";
            Load += CadastroDeFornecedores_Load;
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroDeFornecedores;
        private Label lblFornecedor;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private Label lblEndereco;
        private Label lblTelefone;
        private Label lblCNPJ;
        private Label lblCEP;
        private Label lblNumero;
        private Label lblCidade;
        private PictureBox LogoComoWallpaper;
        private TextBox txtFornecedor;
        private TextBox txtEndereço;
        private MaskedTextBox maskedCNJP;
        private MaskedTextBox maskedCEP;
        private MaskedTextBox maskedNumero;
        private TextBox txtCidade;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private MaskedTextBox maskedTelefone;
    }
}