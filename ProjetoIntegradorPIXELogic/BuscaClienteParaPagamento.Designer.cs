namespace ProjetoIntegradorPIXELogic
{
    partial class BuscaClienteParaPagamento
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
            wilBitTextBox2 = new WiLBiT.WiLBiTTextBox();
            wilBitButton25 = new WiLBiT.WiLBiTButton2();
            pictureBox1 = new PictureBox();
            lblNovoLogin = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // wilBitTextBox2
            // 
            wilBitTextBox2.BackColor = Color.FromArgb(53, 81, 142);
            wilBitTextBox2.BorderColor = Color.FromArgb(0, 242, 254);
            wilBitTextBox2.BorderFocusColor = Color.DeepSkyBlue;
            wilBitTextBox2.BorderRadius = 15;
            wilBitTextBox2.BorderSize = 2;
            wilBitTextBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            wilBitTextBox2.ForeColor = Color.FromArgb(160, 245, 255);
            wilBitTextBox2.Location = new Point(226, 228);
            wilBitTextBox2.Margin = new Padding(4);
            wilBitTextBox2.Multiline = false;
            wilBitTextBox2.Name = "wilBitTextBox2";
            wilBitTextBox2.Padding = new Padding(10, 7, 10, 7);
            wilBitTextBox2.PasswordChar = false;
            wilBitTextBox2.PlaceholderColor = Color.DarkGray;
            wilBitTextBox2.PlaceholderText = "";
            wilBitTextBox2.Size = new Size(344, 33);
            wilBitTextBox2.TabIndex = 3;
            wilBitTextBox2.Texts = "";
            wilBitTextBox2.UnderlinedStyle = false;
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
            wilBitButton25.TabIndex = 21;
            wilBitButton25.Text = "VOLTAR";
            wilBitButton25.TextColor = Color.Black;
            wilBitButton25.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ESCRITA_SEM_Fundo4;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // lblNovoLogin
            // 
            lblNovoLogin.AutoSize = true;
            lblNovoLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovoLogin.ForeColor = Color.FromArgb(160, 245, 255);
            lblNovoLogin.Location = new Point(235, 96);
            lblNovoLogin.Name = "lblNovoLogin";
            lblNovoLogin.Size = new Size(335, 37);
            lblNovoLogin.TabIndex = 23;
            lblNovoLogin.Text = "Escolher uma das opções";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(63, 136, 254);
            label1.Location = new Point(249, 195);
            label1.Name = "label1";
            label1.Size = new Size(320, 21);
            label1.TabIndex = 24;
            label1.Text = "Nome e sobrenome / RG / CPF / Telefone";
            // 
            // BuscaClienteParaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblNovoLogin);
            Controls.Add(pictureBox1);
            Controls.Add(wilBitButton25);
            Controls.Add(wilBitTextBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuscaClienteParaPagamento";
            Text = "BuscaClienteParaPagamento";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private WiLBiT.WiLBiTTextBox wilBitTextBox2;
        private WiLBiT.WiLBiTButton2 wilBitButton25;
        private PictureBox pictureBox1;
        private Label lblNovoLogin;
        private Label label1;
    }
}