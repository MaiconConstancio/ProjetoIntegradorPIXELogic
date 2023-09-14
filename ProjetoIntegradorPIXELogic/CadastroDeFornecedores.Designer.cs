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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            textBox3 = new TextBox();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).BeginInit();
            SuspendLayout();
            // 
            // lblCadastroDeFornecedores
            // 
            lblCadastroDeFornecedores.AutoSize = true;
            lblCadastroDeFornecedores.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroDeFornecedores.ForeColor = Color.Cyan;
            lblCadastroDeFornecedores.Location = new Point(235, 59);
            lblCadastroDeFornecedores.Name = "lblCadastroDeFornecedores";
            lblCadastroDeFornecedores.Size = new Size(351, 37);
            lblCadastroDeFornecedores.TabIndex = 26;
            lblCadastroDeFornecedores.Text = "Cadastro de Fornecedores";
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblFornecedor.ForeColor = Color.FromArgb(63, 136, 254);
            lblFornecedor.Location = new Point(88, 115);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(178, 37);
            lblFornecedor.TabIndex = 24;
            lblFornecedor.Text = " Fornecedor:";
            lblFornecedor.Click += lblNovaSenha_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 18;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.World);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(344, 378);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(135, 36);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "SALVAR";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco.ForeColor = Color.FromArgb(63, 136, 254);
            lblEndereco.Location = new Point(141, 293);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(142, 37);
            lblEndereco.TabIndex = 27;
            lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.ForeColor = Color.FromArgb(63, 136, 254);
            lblTelefone.Location = new Point(165, 152);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(134, 37);
            lblTelefone.TabIndex = 29;
            lblTelefone.Text = "Telefone:";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCNPJ.ForeColor = Color.FromArgb(63, 136, 254);
            lblCNPJ.Location = new Point(218, 185);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(89, 37);
            lblCNPJ.TabIndex = 31;
            lblCNPJ.Text = "CNPJ:";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCEP.ForeColor = Color.FromArgb(63, 136, 254);
            lblCEP.Location = new Point(258, 222);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(72, 37);
            lblCEP.TabIndex = 33;
            lblCEP.Text = "CEP:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.ForeColor = Color.FromArgb(63, 136, 254);
            lblNumero.Location = new Point(190, 256);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(129, 37);
            lblNumero.TabIndex = 35;
            lblNumero.Text = "Número:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.ForeColor = Color.FromArgb(63, 136, 254);
            lblCidade.Location = new Point(170, 328);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(113, 37);
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
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(53, 81, 142);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Cyan;
            textBox1.Location = new Point(262, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 29);
            textBox1.TabIndex = 40;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(53, 81, 142);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Cyan;
            textBox2.Location = new Point(279, 296);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 29);
            textBox2.TabIndex = 41;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.FromArgb(53, 81, 142);
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(295, 156);
            maskedTextBox1.Mask = "(99) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(231, 29);
            maskedTextBox1.TabIndex = 43;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.FromArgb(53, 81, 142);
            maskedTextBox2.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox2.Location = new Point(303, 191);
            maskedTextBox2.Mask = "00.000.000/0001-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(214, 29);
            maskedTextBox2.TabIndex = 44;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.BackColor = Color.FromArgb(53, 81, 142);
            maskedTextBox3.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox3.Location = new Point(326, 226);
            maskedTextBox3.Mask = "00000-00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(168, 29);
            maskedTextBox3.TabIndex = 45;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.BackColor = Color.FromArgb(53, 81, 142);
            maskedTextBox4.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox4.Location = new Point(315, 261);
            maskedTextBox4.Mask = "0000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(191, 29);
            maskedTextBox4.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(53, 81, 142);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Cyan;
            textBox3.Location = new Point(279, 331);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(263, 29);
            textBox3.TabIndex = 47;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 18;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.World);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(653, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(135, 36);
            btnVoltar.TabIndex = 72;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // CadastroDeFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(textBox3);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private TextBox textBox3;
        private WiLBiT.WiLBiTButton2 btnVoltar;
    }
}