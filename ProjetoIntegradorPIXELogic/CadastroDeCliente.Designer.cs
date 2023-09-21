namespace ProjetoIntegradorPIXELogic
{
    partial class CadastroDeCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeCliente));
            txtCidade = new TextBox();
            maskNumero = new MaskedTextBox();
            maskCEP = new MaskedTextBox();
            maskCPF = new MaskedTextBox();
            maskTelefone = new MaskedTextBox();
            txtEndereco = new TextBox();
            txtCliente = new TextBox();
            lblCidade = new Label();
            lblNumero = new Label();
            lblCEP = new Label();
            lblCPF = new Label();
            lblTelefone = new Label();
            lblEndereco = new Label();
            lblCliente = new Label();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            lblCadastroDeClientes = new Label();
            LogoComoWallpaper = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).BeginInit();
            SuspendLayout();
            // 
            // txtCidade
            // 
            txtCidade.BackColor = Color.FromArgb(53, 81, 142);
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.ForeColor = Color.Cyan;
            txtCidade.Location = new Point(275, 329);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(263, 29);
            txtCidade.TabIndex = 7;
            // 
            // maskNumero
            // 
            maskNumero.BackColor = Color.FromArgb(53, 81, 142);
            maskNumero.BorderStyle = BorderStyle.FixedSingle;
            maskNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskNumero.ForeColor = Color.Cyan;
            maskNumero.Location = new Point(311, 259);
            maskNumero.Mask = "0000";
            maskNumero.Name = "maskNumero";
            maskNumero.Size = new Size(191, 29);
            maskNumero.TabIndex = 5;
            maskNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskCEP
            // 
            maskCEP.BackColor = Color.FromArgb(53, 81, 142);
            maskCEP.BorderStyle = BorderStyle.FixedSingle;
            maskCEP.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskCEP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskCEP.ForeColor = Color.Cyan;
            maskCEP.Location = new Point(322, 224);
            maskCEP.Mask = "00000-000";
            maskCEP.Name = "maskCEP";
            maskCEP.Size = new Size(168, 29);
            maskCEP.TabIndex = 4;
            maskCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskCPF
            // 
            maskCPF.BackColor = Color.FromArgb(53, 81, 142);
            maskCPF.BorderStyle = BorderStyle.FixedSingle;
            maskCPF.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskCPF.ForeColor = Color.Cyan;
            maskCPF.Location = new Point(302, 189);
            maskCPF.Mask = "000.000.000-00";
            maskCPF.Name = "maskCPF";
            maskCPF.Size = new Size(214, 29);
            maskCPF.TabIndex = 3;
            maskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskTelefone
            // 
            maskTelefone.BackColor = Color.FromArgb(53, 81, 142);
            maskTelefone.BorderStyle = BorderStyle.FixedSingle;
            maskTelefone.CutCopyMaskFormat = MaskFormat.IncludePrompt;
            maskTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskTelefone.ForeColor = Color.Cyan;
            maskTelefone.Location = new Point(294, 154);
            maskTelefone.Mask = "(99) 00000-0000";
            maskTelefone.Name = "maskTelefone";
            maskTelefone.Size = new Size(231, 29);
            maskTelefone.TabIndex = 2;
            maskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.FromArgb(53, 81, 142);
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.ForeColor = Color.Cyan;
            txtEndereco.Location = new Point(275, 294);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(263, 29);
            txtEndereco.TabIndex = 6;
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.FromArgb(53, 81, 142);
            txtCliente.BorderStyle = BorderStyle.FixedSingle;
            txtCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCliente.ForeColor = Color.Cyan;
            txtCliente.Location = new Point(261, 119);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(296, 29);
            txtCliente.TabIndex = 1;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.ForeColor = Color.Cyan;
            lblCidade.Location = new Point(166, 325);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(113, 37);
            lblCidade.TabIndex = 62;
            lblCidade.Text = "Cidade:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.ForeColor = Color.Cyan;
            lblNumero.Location = new Point(186, 254);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(129, 37);
            lblNumero.TabIndex = 61;
            lblNumero.Text = "Número:";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCEP.ForeColor = Color.Cyan;
            lblCEP.Location = new Point(254, 220);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(72, 37);
            lblCEP.TabIndex = 60;
            lblCEP.Text = "CEP:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCPF.ForeColor = Color.Cyan;
            lblCPF.Location = new Point(234, 184);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(72, 37);
            lblCPF.TabIndex = 59;
            lblCPF.Text = "CPF:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.ForeColor = Color.Cyan;
            lblTelefone.Location = new Point(164, 150);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(134, 37);
            lblTelefone.TabIndex = 58;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco.ForeColor = Color.Cyan;
            lblEndereco.Location = new Point(137, 290);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(142, 37);
            lblEndereco.TabIndex = 57;
            lblEndereco.Text = "Endereço:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.Cyan;
            lblCliente.Location = new Point(151, 113);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(114, 37);
            lblCliente.TabIndex = 56;
            lblCliente.Text = "Cliente:";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(16, 25, 56);
            btnSalvar.BackgroundColor = Color.FromArgb(16, 25, 56);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 12;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Cyan;
            btnSalvar.Location = new Point(349, 384);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 32);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Cyan;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(16, 25, 56);
            btnVoltar.BackgroundColor = Color.FromArgb(16, 25, 56);
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 12;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.Cyan;
            btnVoltar.Location = new Point(714, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(74, 30);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Cyan;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblCadastroDeClientes
            // 
            lblCadastroDeClientes.AutoSize = true;
            lblCadastroDeClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroDeClientes.ForeColor = Color.Cyan;
            lblCadastroDeClientes.Location = new Point(269, 62);
            lblCadastroDeClientes.Name = "lblCadastroDeClientes";
            lblCadastroDeClientes.Size = new Size(280, 37);
            lblCadastroDeClientes.TabIndex = 72;
            lblCadastroDeClientes.Text = "Cadastro de Clientes";
            // 
            // LogoComoWallpaper
            // 
            LogoComoWallpaper.Dock = DockStyle.Fill;
            LogoComoWallpaper.Image = (Image)resources.GetObject("LogoComoWallpaper.Image");
            LogoComoWallpaper.Location = new Point(0, 0);
            LogoComoWallpaper.Name = "LogoComoWallpaper";
            LogoComoWallpaper.Size = new Size(800, 450);
            LogoComoWallpaper.SizeMode = PictureBoxSizeMode.Zoom;
            LogoComoWallpaper.TabIndex = 73;
            LogoComoWallpaper.TabStop = false;
            // 
            // CadastroDeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(lblCadastroDeClientes);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(txtCidade);
            Controls.Add(maskNumero);
            Controls.Add(maskCEP);
            Controls.Add(maskCPF);
            Controls.Add(maskTelefone);
            Controls.Add(txtEndereco);
            Controls.Add(txtCliente);
            Controls.Add(lblCidade);
            Controls.Add(lblNumero);
            Controls.Add(lblCEP);
            Controls.Add(lblCPF);
            Controls.Add(lblTelefone);
            Controls.Add(lblEndereco);
            Controls.Add(lblCliente);
            Controls.Add(LogoComoWallpaper);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroDeCliente";
            Text = "CadastroDeCliente";
            Load += CadastroDeCliente_Load;
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCidade;
        private MaskedTextBox maskNumero;
        private MaskedTextBox maskCEP;
        private MaskedTextBox maskCPF;
        private MaskedTextBox maskTelefone;
        private TextBox txtEndereco;
        private TextBox txtCliente;
        private Label lblCidade;
        private Label lblNumero;
        private Label lblCEP;
        private Label lblCPF;
        private Label lblTelefone;
        private Label lblEndereco;
        private Label lblCliente;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private Label lblCadastroDeClientes;
        private PictureBox LogoComoWallpaper;
    }
}