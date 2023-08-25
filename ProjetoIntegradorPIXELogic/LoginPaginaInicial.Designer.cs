﻿namespace ProjetoIntegradorPIXELogic
{
    partial class LoginPaginaInicial
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
            txtSenha = new WiLBiT.WiLBiTTextBox();
            btnEntra = new WiLBiT.WiLBiTButton2();
            lblSenha = new Label();
            lblLogin = new Label();
            txtLogin = new WiLBiT.WiLBiTTextBox();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(53, 81, 142);
            txtSenha.BorderColor = Color.FromArgb(0, 242, 254);
            txtSenha.BorderFocusColor = Color.DeepSkyBlue;
            txtSenha.BorderRadius = 24;
            txtSenha.BorderSize = 2;
            txtSenha.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.FromArgb(160, 245, 255);
            txtSenha.Location = new Point(1421, 525);
            txtSenha.Margin = new Padding(4);
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.Padding = new Padding(10, 7, 10, 7);
            txtSenha.PasswordChar = false;
            txtSenha.PlaceholderColor = Color.DarkGray;
            txtSenha.PlaceholderText = "";
            txtSenha.Size = new Size(296, 51);
            txtSenha.TabIndex = 0;
            txtSenha.Texts = "";
            txtSenha.UnderlinedStyle = false;
            txtSenha._TextChanged += txtSenha__TextChanged;
            // 
            // btnEntra
            // 
            btnEntra.BackColor = Color.FromArgb(72, 116, 245);
            btnEntra.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnEntra.BorderColor = Color.FromArgb(0, 242, 254);
            btnEntra.BorderRadius = 24;
            btnEntra.BorderSize = 2;
            btnEntra.FlatAppearance.BorderSize = 0;
            btnEntra.FlatStyle = FlatStyle.Flat;
            btnEntra.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntra.ForeColor = Color.Black;
            btnEntra.Location = new Point(1421, 583);
            btnEntra.Name = "btnEntra";
            btnEntra.Size = new Size(296, 47);
            btnEntra.TabIndex = 3;
            btnEntra.Text = "ENTRAR";
            btnEntra.TextColor = Color.Black;
            btnEntra.UseVisualStyleBackColor = false;
            btnEntra.Click += btnEntra_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.ForeColor = Color.FromArgb(63, 136, 254);
            lblSenha.Location = new Point(1519, 484);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(94, 37);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            lblSenha.Click += lblSenha_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(63, 136, 254);
            lblLogin.Location = new Point(1519, 388);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(89, 37);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "Login";
            lblLogin.Click += lblLogin_Click;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(53, 81, 142);
            txtLogin.BorderColor = Color.FromArgb(0, 242, 254);
            txtLogin.BorderFocusColor = Color.DeepSkyBlue;
            txtLogin.BorderRadius = 24;
            txtLogin.BorderSize = 2;
            txtLogin.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.ForeColor = Color.FromArgb(160, 245, 255);
            txtLogin.Location = new Point(1421, 429);
            txtLogin.Margin = new Padding(4);
            txtLogin.Multiline = false;
            txtLogin.Name = "txtLogin";
            txtLogin.Padding = new Padding(10, 7, 10, 7);
            txtLogin.PasswordChar = false;
            txtLogin.PlaceholderColor = Color.DarkGray;
            txtLogin.PlaceholderText = "";
            txtLogin.Size = new Size(296, 51);
            txtLogin.TabIndex = 5;
            txtLogin.Texts = "";
            txtLogin.UnderlinedStyle = false;
            txtLogin._TextChanged += txtLogin__TextChanged;
            // 
            // LoginPaginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(1904, 1041);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblSenha);
            Controls.Add(btnEntra);
            Controls.Add(txtSenha);
            Name = "LoginPaginaInicial";
            Text = "Form1";
            Load += LoginPaginaInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTTextBox txtSenha;
        private WiLBiT.WiLBiTButton2 btnEntra;
        private Label lblSenha;
        private Label lblLogin;
        private WiLBiT.WiLBiTTextBox txtLogin;
    }
}