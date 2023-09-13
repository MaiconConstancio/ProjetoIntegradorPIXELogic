namespace ProjetoIntegradorPIXELogic
{
    partial class lblGerenciamentoDeServicos
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
            btnImprimir = new WiLBiT.WiLBiTButton2();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            pictureBox1 = new PictureBox();
            lblEscolhaSeusColaboradoresESuasCredenciais = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btnImprimir.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Location = new Point(12, 407);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(111, 31);
            btnImprimir.TabIndex = 24;
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
            btnSalvar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(129, 407);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 31);
            btnSalvar.TabIndex = 25;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
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
            btnVoltar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(677, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(111, 31);
            btnVoltar.TabIndex = 26;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ESCRITA_SEM_Fundo9;
            pictureBox1.Location = new Point(-16, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // lblEscolhaSeusColaboradoresESuasCredenciais
            // 
            lblEscolhaSeusColaboradoresESuasCredenciais.AutoSize = true;
            lblEscolhaSeusColaboradoresESuasCredenciais.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblEscolhaSeusColaboradoresESuasCredenciais.ForeColor = Color.Cyan;
            lblEscolhaSeusColaboradoresESuasCredenciais.Location = new Point(422, 46);
            lblEscolhaSeusColaboradoresESuasCredenciais.Name = "lblEscolhaSeusColaboradoresESuasCredenciais";
            lblEscolhaSeusColaboradoresESuasCredenciais.Size = new Size(366, 37);
            lblEscolhaSeusColaboradoresESuasCredenciais.TabIndex = 28;
            lblEscolhaSeusColaboradoresESuasCredenciais.Text = "Gerenciamento de Servicos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(625, 407);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 29;
            label1.Text = "{lbl VALOR TOTAL}";
            // 
            // lblGerenciamentoDeServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblEscolhaSeusColaboradoresESuasCredenciais);
            Controls.Add(pictureBox1);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(btnImprimir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "lblGerenciamentoDeServicos";
            Text = "EmissãoRelatorioFinanceiroProduto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTButton2 btnImprimir;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private PictureBox pictureBox1;
        private Label lblEscolhaSeusColaboradoresESuasCredenciais;
        private Label label1;
    }
}