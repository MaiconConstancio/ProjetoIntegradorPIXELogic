namespace ProjetoIntegradorPIXELogic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnEntra = new Button();
            pictureEscrita = new PictureBox();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureEscrita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(63, 136, 254);
            label1.Location = new Point(533, 160);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(63, 136, 254);
            label2.Location = new Point(533, 226);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(53, 81, 142);
            txtLogin.Location = new Point(501, 178);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(53, 81, 142);
            txtSenha.Location = new Point(501, 244);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;
            // 
            // btnEntra
            // 
            btnEntra.BackColor = Color.FromArgb(0, 242, 254);
            btnEntra.FlatStyle = FlatStyle.Flat;
            btnEntra.Location = new Point(501, 300);
            btnEntra.Name = "btnEntra";
            btnEntra.Size = new Size(100, 23);
            btnEntra.TabIndex = 4;
            btnEntra.Text = "ENTRAR";
            btnEntra.UseVisualStyleBackColor = false;
            btnEntra.Click += btnEntra_Click;
            // 
            // pictureEscrita
            // 
            pictureEscrita.BackColor = Color.Lime;
            pictureEscrita.Location = new Point(148, 26);
            pictureEscrita.Name = "pictureEscrita";
            pictureEscrita.Size = new Size(426, 72);
            pictureEscrita.TabIndex = 5;
            pictureEscrita.TabStop = false;
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Lime;
            pictureLogo.Location = new Point(65, 188);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(156, 135);
            pictureLogo.TabIndex = 6;
            pictureLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 10, 22);
            ClientSize = new Size(659, 373);
            Controls.Add(pictureLogo);
            Controls.Add(pictureEscrita);
            Controls.Add(btnEntra);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureEscrita).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEntra;
        private PictureBox pictureEscrita;
        private PictureBox pictureLogo;
    }
}