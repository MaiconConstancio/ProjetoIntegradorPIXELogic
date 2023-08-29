namespace ProjetoIntegradorPIXELogic
{
    partial class NovoLoginSenha
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
            lblNovoLogin = new Label();
            txtNovoLogin = new WiLBiT.WiLBiTTextBox();
            lblNovaSenha = new Label();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            txtNovaSenha = new WiLBiT.WiLBiTTextBox();
            SuspendLayout();
            // 
            // lblNovoLogin
            // 
            lblNovoLogin.AutoSize = true;
            lblNovoLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovoLogin.ForeColor = Color.FromArgb(63, 136, 254);
            lblNovoLogin.Location = new Point(870, 399);
            lblNovoLogin.Name = "lblNovoLogin";
            lblNovoLogin.Size = new Size(166, 37);
            lblNovoLogin.TabIndex = 11;
            lblNovoLogin.Text = "Novo Login";
            // 
            // txtNovoLogin
            // 
            txtNovoLogin.BackColor = Color.FromArgb(53, 81, 142);
            txtNovoLogin.BorderColor = Color.FromArgb(0, 242, 254);
            txtNovoLogin.BorderFocusColor = Color.DeepSkyBlue;
            txtNovoLogin.BorderRadius = 24;
            txtNovoLogin.BorderSize = 2;
            txtNovoLogin.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtNovoLogin.ForeColor = Color.FromArgb(160, 245, 255);
            txtNovoLogin.Location = new Point(804, 440);
            txtNovoLogin.Margin = new Padding(4);
            txtNovoLogin.Multiline = false;
            txtNovoLogin.Name = "txtNovoLogin";
            txtNovoLogin.Padding = new Padding(10, 7, 10, 7);
            txtNovoLogin.PasswordChar = false;
            txtNovoLogin.PlaceholderColor = Color.DarkGray;
            txtNovoLogin.PlaceholderText = "";
            txtNovoLogin.Size = new Size(296, 51);
            txtNovoLogin.TabIndex = 10;
            txtNovoLogin.Texts = "";
            txtNovoLogin.UnderlinedStyle = false;
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovaSenha.ForeColor = Color.FromArgb(63, 136, 254);
            lblNovaSenha.Location = new Point(870, 495);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(169, 37);
            lblNovaSenha.TabIndex = 9;
            lblNovaSenha.Text = "Nova Senha";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 24;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(804, 594);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(296, 47);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "SALVAR";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.BackColor = Color.FromArgb(53, 81, 142);
            txtNovaSenha.BorderColor = Color.FromArgb(0, 242, 254);
            txtNovaSenha.BorderFocusColor = Color.DeepSkyBlue;
            txtNovaSenha.BorderRadius = 24;
            txtNovaSenha.BorderSize = 2;
            txtNovaSenha.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtNovaSenha.ForeColor = Color.FromArgb(160, 245, 255);
            txtNovaSenha.Location = new Point(804, 536);
            txtNovaSenha.Margin = new Padding(4);
            txtNovaSenha.Multiline = false;
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Padding = new Padding(10, 7, 10, 7);
            txtNovaSenha.PasswordChar = false;
            txtNovaSenha.PlaceholderColor = Color.DarkGray;
            txtNovaSenha.PlaceholderText = "";
            txtNovaSenha.Size = new Size(296, 51);
            txtNovaSenha.TabIndex = 7;
            txtNovaSenha.Texts = "";
            txtNovaSenha.UnderlinedStyle = false;
            // 
            // NovoLoginSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(1904, 1041);
            Controls.Add(lblNovoLogin);
            Controls.Add(txtNovoLogin);
            Controls.Add(lblNovaSenha);
            Controls.Add(btnSalvar);
            Controls.Add(txtNovaSenha);
            Name = "NovoLoginSenha";
            Text = "PIXELogic - Sua visão, nossa programação!";
            Load += NovoLoginSenha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovoLogin;
        private WiLBiT.WiLBiTTextBox txtNovoLogin;
        private Label lblNovaSenha;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private WiLBiT.WiLBiTTextBox txtNovaSenha;
    }
}