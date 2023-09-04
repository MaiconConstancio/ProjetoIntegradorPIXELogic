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
            txtNomeESobrenome = new WiLBiT.WiLBiTTextBox();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            pictureBox1 = new PictureBox();
            lblNovoLogin = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNomeESobrenome
            // 
            txtNomeESobrenome.BackColor = Color.FromArgb(53, 81, 142);
            txtNomeESobrenome.BorderColor = Color.FromArgb(0, 242, 254);
            txtNomeESobrenome.BorderFocusColor = Color.DeepSkyBlue;
            txtNomeESobrenome.BorderRadius = 15;
            txtNomeESobrenome.BorderSize = 2;
            txtNomeESobrenome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeESobrenome.ForeColor = Color.FromArgb(160, 245, 255);
            txtNomeESobrenome.Location = new Point(226, 228);
            txtNomeESobrenome.Margin = new Padding(4);
            txtNomeESobrenome.Multiline = false;
            txtNomeESobrenome.Name = "txtNomeESobrenome";
            txtNomeESobrenome.Padding = new Padding(10, 7, 10, 7);
            txtNomeESobrenome.PasswordChar = false;
            txtNomeESobrenome.PlaceholderColor = Color.DarkGray;
            txtNomeESobrenome.PlaceholderText = "";
            txtNomeESobrenome.Size = new Size(344, 33);
            txtNomeESobrenome.TabIndex = 3;
            txtNomeESobrenome.Texts = "";
            txtNomeESobrenome.UnderlinedStyle = false;
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
            btnVoltar.TabIndex = 21;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
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
            Controls.Add(btnVoltar);
            Controls.Add(txtNomeESobrenome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuscaClienteParaPagamento";
            Text = "BuscaClienteParaPagamento";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private WiLBiT.WiLBiTTextBox txtNomeESobrenome;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private PictureBox pictureBox1;
        private Label lblNovoLogin;
        private Label label1;
    }
}