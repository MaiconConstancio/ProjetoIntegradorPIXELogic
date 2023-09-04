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
            wilBitButton25 = new WiLBiT.WiLBiTButton2();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            // wilBitButton25
            // 
            wilBitButton25.BackColor = Color.FromArgb(72, 116, 245);
            wilBitButton25.BackgroundColor = Color.FromArgb(72, 116, 245);
            wilBitButton25.BorderColor = Color.FromArgb(0, 242, 254);
            wilBitButton25.BorderRadius = 15;
            wilBitButton25.BorderSize = 2;
            wilBitButton25.FlatAppearance.BorderSize = 0;
            wilBitButton25.FlatStyle = FlatStyle.Flat;
            wilBitButton25.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            wilBitButton25.ForeColor = Color.Black;
            wilBitButton25.Location = new Point(688, 12);
            wilBitButton25.Name = "wilBitButton25";
            wilBitButton25.Size = new Size(100, 30);
            wilBitButton25.TabIndex = 26;
            wilBitButton25.Text = "VOLTAR";
            wilBitButton25.TextColor = Color.Black;
            wilBitButton25.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(160, 245, 255);
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 31;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(160, 245, 255);
            label3.Location = new Point(164, 145);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 32;
            label3.Text = "Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(160, 245, 255);
            label4.Location = new Point(348, 145);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 33;
            label4.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(160, 245, 255);
            label5.Location = new Point(532, 145);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 34;
            label5.Text = "Valor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(160, 245, 255);
            label6.Location = new Point(709, 145);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 35;
            label6.Text = "Ação";
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
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(wilBitButton25);
            Controls.Add(pictureBox1);
            Name = "RegistroDeVendasDeProdutos";
            Text = "RegistroDeVendasDeProdutos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private WiLBiT.WiLBiTButton2 wilBitButton25;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
    }
}