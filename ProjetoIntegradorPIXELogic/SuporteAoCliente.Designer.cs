namespace ProjetoIntegradorPIXELogic
{
    partial class SuporteAoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuporteAoCliente));
            pictureBox1 = new PictureBox();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            lblOrcamentoDeServicos = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkTurquoise;
            btnVoltar.BackgroundColor = Color.DarkTurquoise;
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 18;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.World);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(440, 372);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(229, 36);
            btnVoltar.TabIndex = 74;
            btnVoltar.Text = "ENTRAR EM CONTATO";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // lblOrcamentoDeServicos
            // 
            lblOrcamentoDeServicos.AutoSize = true;
            lblOrcamentoDeServicos.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrcamentoDeServicos.ForeColor = Color.Cyan;
            lblOrcamentoDeServicos.Location = new Point(368, 29);
            lblOrcamentoDeServicos.Name = "lblOrcamentoDeServicos";
            lblOrcamentoDeServicos.Size = new Size(372, 54);
            lblOrcamentoDeServicos.TabIndex = 75;
            lblOrcamentoDeServicos.Text = "Suporte ao Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(449, 118);
            label1.Name = "label1";
            label1.Size = new Size(204, 31);
            label1.TabIndex = 76;
            label1.Text = "Atendimento das:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(486, 155);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 77;
            label2.Text = "8:30 à 19:30";
            // 
            // SuporteAoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblOrcamentoDeServicos);
            Controls.Add(btnVoltar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuporteAoCliente";
            Text = "SuporteAoCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private Label lblOrcamentoDeServicos;
        private Label label1;
        private Label label2;
    }
}