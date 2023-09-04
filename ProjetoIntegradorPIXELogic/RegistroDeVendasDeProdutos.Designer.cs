namespace ProjetoIntegradorPIXELogic
{
    partial class RegistroDeVendasDeProdutos
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
            lblCodigo = new Label();
            lblProduto = new Label();
            lblCliente = new Label();
            lblValor = new Label();
            lblAcao = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ESCRITA_SEM_Fundo8;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 72);
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
            btnVoltar.TabIndex = 26;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodigo.ForeColor = Color.FromArgb(160, 245, 255);
            lblCodigo.Location = new Point(12, 145);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(77, 25);
            lblCodigo.TabIndex = 31;
            lblCodigo.Text = "Código";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduto.ForeColor = Color.FromArgb(160, 245, 255);
            lblProduto.Location = new Point(164, 145);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(87, 25);
            lblProduto.TabIndex = 32;
            lblProduto.Text = "Produto";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(160, 245, 255);
            lblCliente.Location = new Point(348, 145);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(73, 25);
            lblCliente.TabIndex = 33;
            lblCliente.Text = "Cliente";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(160, 245, 255);
            lblValor.Location = new Point(532, 145);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(59, 25);
            lblValor.TabIndex = 34;
            lblValor.Text = "Valor";
            // 
            // lblAcao
            // 
            lblAcao.AutoSize = true;
            lblAcao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcao.ForeColor = Color.FromArgb(160, 245, 255);
            lblAcao.Location = new Point(709, 145);
            lblAcao.Name = "lblAcao";
            lblAcao.Size = new Size(56, 25);
            lblAcao.TabIndex = 35;
            lblAcao.Text = "Ação";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(160, 245, 255);
            label1.Location = new Point(435, 68);
            label1.Name = "label1";
            label1.Size = new Size(353, 32);
            label1.TabIndex = 36;
            label1.Text = "Registro de vendas de produtos";
            // 
            // RegistroDeVendasDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblAcao);
            Controls.Add(lblValor);
            Controls.Add(lblCliente);
            Controls.Add(lblProduto);
            Controls.Add(lblCodigo);
            Controls.Add(btnVoltar);
            Controls.Add(pictureBox1);
            Name = "RegistroDeVendasDeProdutos";
            Text = "RegistroDeVendasDeProdutos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private Label lblCodigo;
        private Label lblProduto;
        private Label lblCliente;
        private Label lblValor;
        private Label lblAcao;
        private Label label1;
    }
}