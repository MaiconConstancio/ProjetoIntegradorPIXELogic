namespace ProjetoIntegradorPIXELogic
{
    partial class EmissaoRelatorioFinanceiroProdutos
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
            pictureBox1 = new PictureBox();
            lblAcao = new Label();
            lblValor = new Label();
            lblCliente = new Label();
            lblProduto = new Label();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            btnImprimir = new WiLBiT.WiLBiTButton2();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblAcao
            // 
            lblAcao.BorderStyle = BorderStyle.FixedSingle;
            lblAcao.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcao.ForeColor = Color.FromArgb(63, 136, 254);
            lblAcao.Location = new Point(636, 101);
            lblAcao.Name = "lblAcao";
            lblAcao.Size = new Size(200, 30);
            lblAcao.TabIndex = 29;
            lblAcao.Text = "Ação";
            lblAcao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            lblValor.BorderStyle = BorderStyle.FixedSingle;
            lblValor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(430, 101);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(200, 30);
            lblValor.TabIndex = 31;
            lblValor.Text = "Valor";
            lblValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            lblCliente.BorderStyle = BorderStyle.FixedSingle;
            lblCliente.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblCliente.Location = new Point(224, 101);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(200, 30);
            lblCliente.TabIndex = 32;
            lblCliente.Text = "Cliente";
            lblCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProduto
            // 
            lblProduto.BorderStyle = BorderStyle.FixedSingle;
            lblProduto.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduto.ForeColor = Color.FromArgb(63, 136, 254);
            lblProduto.Location = new Point(18, 101);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(200, 30);
            lblProduto.TabIndex = 33;
            lblProduto.Text = "Produto";
            lblProduto.TextAlign = ContentAlignment.MiddleCenter;
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
            btnVoltar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(714, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(74, 30);
            btnVoltar.TabIndex = 34;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BorderColor = Color.FromArgb(0, 242, 254);
            btnImprimir.BorderRadius = 14;
            btnImprimir.BorderSize = 2;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Location = new Point(18, 398);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(109, 40);
            btnImprimir.TabIndex = 35;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextColor = Color.Black;
            btnImprimir.UseVisualStyleBackColor = false;
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
            btnSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(155, 398);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 40);
            btnSalvar.TabIndex = 36;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Location = new Point(18, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 11);
            panel1.TabIndex = 37;
            // 
            // EmissaoRelatorioFinanceiroProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(839, 450);
            Controls.Add(panel1);
            Controls.Add(btnSalvar);
            Controls.Add(btnImprimir);
            Controls.Add(btnVoltar);
            Controls.Add(lblProduto);
            Controls.Add(lblCliente);
            Controls.Add(lblValor);
            Controls.Add(lblAcao);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmissaoRelatorioFinanceiroProdutos";
            Text = "EmissaoRelatorioFinanceiroProdutos";
            Load += EmissaoRelatorioFinanceiroProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblAcao;
        private Label lblValor;
        private Label lblCliente;
        private Label lblProduto;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private WiLBiT.WiLBiTButton2 btnImprimir;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private Panel panel1;
    }
}