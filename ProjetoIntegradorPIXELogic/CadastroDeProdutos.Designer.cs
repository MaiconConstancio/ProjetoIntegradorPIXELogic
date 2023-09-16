namespace ProjetoIntegradorPIXELogic
{
    partial class CadastroDeProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeProdutos));
            btnSalvar = new WiLBiT.WiLBiTButton2();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            lblNome = new Label();
            lblFornecedor = new Label();
            lblQuantidade = new Label();
            lblValor = new Label();
            lblVencimento = new Label();
            lblCadastrodeprodutos = new Label();
            LogoComoWallpaper = new PictureBox();
            txtNome = new TextBox();
            txtFornecedor = new TextBox();
            txtQuantidade = new TextBox();
            maskValor = new MaskedTextBox();
            maskVencimento = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 14;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(306, 373);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(189, 42);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "SALVAR";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 14;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(676, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(121, 36);
            btnVoltar.TabIndex = 19;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(63, 136, 254);
            lblNome.Location = new Point(186, 115);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(90, 32);
            lblNome.TabIndex = 25;
            lblNome.Text = "Nome:";
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFornecedor.ForeColor = Color.FromArgb(63, 136, 254);
            lblFornecedor.Location = new Point(98, 165);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(152, 32);
            lblFornecedor.TabIndex = 26;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidade.ForeColor = Color.FromArgb(63, 136, 254);
            lblQuantidade.Location = new Point(133, 221);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(154, 32);
            lblQuantidade.TabIndex = 27;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(219, 271);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(81, 32);
            lblValor.TabIndex = 28;
            lblValor.Text = "Valor:";
            // 
            // lblVencimento
            // 
            lblVencimento.AutoSize = true;
            lblVencimento.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblVencimento.ForeColor = Color.FromArgb(63, 136, 254);
            lblVencimento.Location = new Point(151, 322);
            lblVencimento.Name = "lblVencimento";
            lblVencimento.Size = new Size(156, 32);
            lblVencimento.TabIndex = 29;
            lblVencimento.Text = "Vencimento:";
            // 
            // lblCadastrodeprodutos
            // 
            lblCadastrodeprodutos.AutoSize = true;
            lblCadastrodeprodutos.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastrodeprodutos.ForeColor = Color.FromArgb(63, 136, 254);
            lblCadastrodeprodutos.Location = new Point(201, 24);
            lblCadastrodeprodutos.Name = "lblCadastrodeprodutos";
            lblCadastrodeprodutos.Size = new Size(398, 50);
            lblCadastrodeprodutos.TabIndex = 30;
            lblCadastrodeprodutos.Text = "Cadastro de Produtos";
            // 
            // LogoComoWallpaper
            // 
            LogoComoWallpaper.Dock = DockStyle.Fill;
            LogoComoWallpaper.Image = (Image)resources.GetObject("LogoComoWallpaper.Image");
            LogoComoWallpaper.Location = new Point(0, 0);
            LogoComoWallpaper.Name = "LogoComoWallpaper";
            LogoComoWallpaper.Size = new Size(800, 450);
            LogoComoWallpaper.TabIndex = 31;
            LogoComoWallpaper.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(53, 81, 142);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = Color.Cyan;
            txtNome.Location = new Point(279, 117);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(243, 29);
            txtNome.TabIndex = 65;
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = Color.FromArgb(53, 81, 142);
            txtFornecedor.BorderStyle = BorderStyle.FixedSingle;
            txtFornecedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFornecedor.ForeColor = Color.Cyan;
            txtFornecedor.Location = new Point(252, 167);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(296, 29);
            txtFornecedor.TabIndex = 66;
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.FromArgb(53, 81, 142);
            txtQuantidade.BorderStyle = BorderStyle.FixedSingle;
            txtQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.ForeColor = Color.Cyan;
            txtQuantidade.Location = new Point(290, 223);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(220, 29);
            txtQuantidade.TabIndex = 67;
            // 
            // maskValor
            // 
            maskValor.BackColor = Color.FromArgb(53, 81, 142);
            maskValor.BorderStyle = BorderStyle.FixedSingle;
            maskValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskValor.Location = new Point(302, 272);
            maskValor.Mask = "$ 000,00";
            maskValor.Name = "maskValor";
            maskValor.Size = new Size(196, 29);
            maskValor.TabIndex = 70;
            maskValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskVencimento
            // 
            maskVencimento.BackColor = Color.FromArgb(53, 81, 142);
            maskVencimento.BorderStyle = BorderStyle.FixedSingle;
            maskVencimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskVencimento.Location = new Point(309, 323);
            maskVencimento.Mask = "00/00/0000";
            maskVencimento.Name = "maskVencimento";
            maskVencimento.Size = new Size(183, 29);
            maskVencimento.TabIndex = 71;
            maskVencimento.Text = "20012005";
            // 
            // CadastroDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(maskVencimento);
            Controls.Add(maskValor);
            Controls.Add(txtQuantidade);
            Controls.Add(txtFornecedor);
            Controls.Add(txtNome);
            Controls.Add(lblCadastrodeprodutos);
            Controls.Add(lblVencimento);
            Controls.Add(lblValor);
            Controls.Add(lblQuantidade);
            Controls.Add(lblFornecedor);
            Controls.Add(lblNome);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(LogoComoWallpaper);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroDeProdutos";
            Text = "CadastroDeProutos";
            Load += CadastroDeProutos_Load;
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTButton2 btnSalvar;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private Label lblNome;
        private Label lblFornecedor;
        private Label lblQuantidade;
        private Label lblValor;
        private Label lblVencimento;
        private Label lblCadastrodeprodutos;
        private PictureBox LogoComoWallpaper;
        private TextBox txtNome;
        private TextBox txtFornecedor;
        private TextBox txtQuantidade;
        private MaskedTextBox maskValor;
        private MaskedTextBox maskVencimento;
    }
}