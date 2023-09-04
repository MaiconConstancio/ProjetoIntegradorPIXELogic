namespace ProjetoIntegradorPIXELogic
{
    partial class EmissaoDeRelatorioFinanceiro
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
            btnVoltar = new WiLBiT.WiLBiTButton2();
            btnImprimir = new WiLBiT.WiLBiTButton2();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            label1 = new Label();
            lblCodigo = new Label();
            lblProduto = new Label();
            lblCliente = new Label();
            lblValor = new Label();
            lblAcao = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ESCRITA_SEM_Fundo6;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 15;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(688, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 30);
            btnVoltar.TabIndex = 22;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BorderColor = Color.FromArgb(0, 242, 254);
            btnImprimir.BorderRadius = 15;
            btnImprimir.BorderSize = 2;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Location = new Point(12, 408);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(97, 30);
            btnImprimir.TabIndex = 23;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.TextColor = Color.Black;
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 15;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(135, 408);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(97, 30);
            btnSalvar.TabIndex = 24;
            btnSalvar.Text = "SALVAR";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(160, 245, 255);
            label1.Location = new Point(437, 65);
            label1.Name = "label1";
            label1.Size = new Size(351, 32);
            label1.TabIndex = 25;
            label1.Text = "Emissão de Relatorio Financeiro\r\n";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodigo.ForeColor = Color.FromArgb(160, 245, 255);
            lblCodigo.Location = new Point(12, 141);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(77, 25);
            lblCodigo.TabIndex = 29;
            lblCodigo.Text = "Código";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduto.ForeColor = Color.FromArgb(160, 245, 255);
            lblProduto.Location = new Point(177, 141);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(87, 25);
            lblProduto.TabIndex = 30;
            lblProduto.Text = "Produto";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(160, 245, 255);
            lblCliente.Location = new Point(371, 141);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(73, 25);
            lblCliente.TabIndex = 31;
            lblCliente.Text = "Cliente";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(160, 245, 255);
            lblValor.Location = new Point(536, 141);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(59, 25);
            lblValor.TabIndex = 32;
            lblValor.Text = "Valor";
            // 
            // lblAcao
            // 
            lblAcao.AutoSize = true;
            lblAcao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcao.ForeColor = Color.FromArgb(160, 245, 255);
            lblAcao.Location = new Point(688, 141);
            lblAcao.Name = "lblAcao";
            lblAcao.Size = new Size(56, 25);
            lblAcao.TabIndex = 33;
            lblAcao.Text = "Ação";
            // 
            // EmissaoDeRelatorioFinanceiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(lblAcao);
            Controls.Add(lblValor);
            Controls.Add(lblCliente);
            Controls.Add(lblProduto);
            Controls.Add(lblCodigo);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(btnImprimir);
            Controls.Add(btnVoltar);
            Controls.Add(pictureBox1);
            Name = "EmissaoDeRelatorioFinanceiro";
            Text = "EmissaoDeRelatorioFinanceiro";
            Load += EmissaoDeRelatorioFinanceiro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private WiLBiT.WiLBiTButton2 btnImprimir;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private Label label1;
        private Label lblCodigo;
        private Label lblProduto;
        private Label lblCliente;
        private Label lblValor;
        private Label lblAcao;
    }
}