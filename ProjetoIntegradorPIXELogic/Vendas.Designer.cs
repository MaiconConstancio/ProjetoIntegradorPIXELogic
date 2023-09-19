namespace ProjetoIntegradorPIXELogic
{
    partial class Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            cmbProduto = new ComboBox();
            cmbMetodoDePagamento = new ComboBox();
            txtQuantidade = new TextBox();
            txtNomeDoCliente = new TextBox();
            lblMetodoDePagamento = new Label();
            lblValor = new Label();
            lblQuantidade = new Label();
            lblNomeDoCliente = new Label();
            lblProduto = new Label();
            btnVerTodosOsItens = new WiLBiT.WiLBiTButton2();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            LogoComoWallpaper = new PictureBox();
            maskValor = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).BeginInit();
            SuspendLayout();
            // 
            // cmbProduto
            // 
            cmbProduto.BackColor = Color.FromArgb(53, 81, 142);
            cmbProduto.FlatStyle = FlatStyle.Popup;
            cmbProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProduto.ForeColor = Color.Cyan;
            cmbProduto.FormattingEnabled = true;
            cmbProduto.ItemHeight = 21;
            cmbProduto.Location = new Point(17, 172);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(228, 29);
            cmbProduto.TabIndex = 59;
            // 
            // cmbMetodoDePagamento
            // 
            cmbMetodoDePagamento.BackColor = Color.FromArgb(53, 81, 142);
            cmbMetodoDePagamento.FlatStyle = FlatStyle.Popup;
            cmbMetodoDePagamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMetodoDePagamento.ForeColor = Color.Cyan;
            cmbMetodoDePagamento.FormattingEnabled = true;
            cmbMetodoDePagamento.Location = new Point(52, 280);
            cmbMetodoDePagamento.Name = "cmbMetodoDePagamento";
            cmbMetodoDePagamento.Size = new Size(289, 29);
            cmbMetodoDePagamento.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.FromArgb(53, 81, 142);
            txtQuantidade.BorderStyle = BorderStyle.FixedSingle;
            txtQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.ForeColor = Color.Cyan;
            txtQuantidade.Location = new Point(277, 172);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(259, 29);
            txtQuantidade.TabIndex = 2;
            // 
            // txtNomeDoCliente
            // 
            txtNomeDoCliente.BackColor = Color.FromArgb(53, 81, 142);
            txtNomeDoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeDoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDoCliente.ForeColor = Color.Cyan;
            txtNomeDoCliente.Location = new Point(553, 172);
            txtNomeDoCliente.Name = "txtNomeDoCliente";
            txtNomeDoCliente.Size = new Size(225, 29);
            txtNomeDoCliente.TabIndex = 3;
            txtNomeDoCliente.TextChanged += textBox1_TextChanged;
            // 
            // lblMetodoDePagamento
            // 
            lblMetodoDePagamento.AutoSize = true;
            lblMetodoDePagamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMetodoDePagamento.ForeColor = Color.FromArgb(63, 136, 254);
            lblMetodoDePagamento.Location = new Point(88, 239);
            lblMetodoDePagamento.Name = "lblMetodoDePagamento";
            lblMetodoDePagamento.Size = new Size(217, 25);
            lblMetodoDePagamento.TabIndex = 64;
            lblMetodoDePagamento.Text = "Método de pagamento";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(552, 239);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(59, 25);
            lblValor.TabIndex = 65;
            lblValor.Text = "Valor";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidade.ForeColor = Color.FromArgb(63, 136, 254);
            lblQuantidade.Location = new Point(348, 134);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(116, 25);
            lblQuantidade.TabIndex = 66;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblNomeDoCliente
            // 
            lblNomeDoCliente.AutoSize = true;
            lblNomeDoCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeDoCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblNomeDoCliente.Location = new Point(586, 134);
            lblNomeDoCliente.Name = "lblNomeDoCliente";
            lblNomeDoCliente.Size = new Size(158, 25);
            lblNomeDoCliente.TabIndex = 67;
            lblNomeDoCliente.Text = "Nome do cliente";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduto.ForeColor = Color.FromArgb(63, 136, 254);
            lblProduto.Location = new Point(88, 134);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(87, 25);
            lblProduto.TabIndex = 68;
            lblProduto.Text = "Produto";
            // 
            // btnVerTodosOsItens
            // 
            btnVerTodosOsItens.BackColor = Color.FromArgb(72, 116, 245);
            btnVerTodosOsItens.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnVerTodosOsItens.BorderColor = Color.FromArgb(0, 242, 254);
            btnVerTodosOsItens.BorderRadius = 12;
            btnVerTodosOsItens.BorderSize = 2;
            btnVerTodosOsItens.FlatAppearance.BorderSize = 0;
            btnVerTodosOsItens.FlatStyle = FlatStyle.Flat;
            btnVerTodosOsItens.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerTodosOsItens.ForeColor = Color.Black;
            btnVerTodosOsItens.Location = new Point(453, 361);
            btnVerTodosOsItens.Name = "btnVerTodosOsItens";
            btnVerTodosOsItens.Size = new Size(225, 32);
            btnVerTodosOsItens.TabIndex = 7;
            btnVerTodosOsItens.Text = "VER TODOS OS ITENS";
            btnVerTodosOsItens.TextColor = Color.Black;
            btnVerTodosOsItens.UseVisualStyleBackColor = false;
            btnVerTodosOsItens.Click += btnVerTodosOsItens_Click;
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
            btnSalvar.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(180, 361);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 32);
            btnSalvar.TabIndex = 6;
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
            btnVoltar.BorderRadius = 12;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(714, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(74, 30);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // LogoComoWallpaper
            // 
            LogoComoWallpaper.Dock = DockStyle.Fill;
            LogoComoWallpaper.Image = (Image)resources.GetObject("LogoComoWallpaper.Image");
            LogoComoWallpaper.Location = new Point(0, 0);
            LogoComoWallpaper.Name = "LogoComoWallpaper";
            LogoComoWallpaper.Size = new Size(800, 450);
            LogoComoWallpaper.SizeMode = PictureBoxSizeMode.Zoom;
            LogoComoWallpaper.TabIndex = 74;
            LogoComoWallpaper.TabStop = false;
            // 
            // maskValor
            // 
            maskValor.BackColor = Color.FromArgb(53, 81, 142);
            maskValor.BorderStyle = BorderStyle.FixedSingle;
            maskValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskValor.ForeColor = Color.Cyan;
            maskValor.Location = new Point(436, 280);
            maskValor.Mask = "$ 000,00";
            maskValor.Name = "maskValor";
            maskValor.Size = new Size(290, 29);
            maskValor.TabIndex = 5;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(maskValor);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(btnVerTodosOsItens);
            Controls.Add(lblProduto);
            Controls.Add(lblNomeDoCliente);
            Controls.Add(lblQuantidade);
            Controls.Add(lblValor);
            Controls.Add(lblMetodoDePagamento);
            Controls.Add(txtNomeDoCliente);
            Controls.Add(txtQuantidade);
            Controls.Add(cmbMetodoDePagamento);
            Controls.Add(cmbProduto);
            Controls.Add(LogoComoWallpaper);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vendas";
            Text = "v";
            Load += Vendas_Load;
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbProduto;
        private ComboBox cmbMetodoDePagamento;
        private TextBox txtQuantidade;
        private TextBox txtNomeDoCliente;
        private Label lblMetodoDePagamento;
        private Label lblValor;
        private Label lblQuantidade;
        private Label lblNomeDoCliente;
        private Label lblProduto;
        private WiLBiT.WiLBiTButton2 btnVerTodosOsItens;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private PictureBox LogoComoWallpaper;
        private MaskedTextBox maskValor;
    }
}