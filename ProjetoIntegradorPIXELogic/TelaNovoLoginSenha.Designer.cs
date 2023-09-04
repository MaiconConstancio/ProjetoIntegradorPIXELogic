using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjetoIntegradorPIXELogic
{
    partial class TelaNovoLoginSenha
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
            btnSalvarNovoLoginSenha = new WiLBiT.WiLBiTButton2();
            txtNovaSenha = new WiLBiT.WiLBiTTextBox();
            SuspendLayout();
            // 
            // lblNovoLogin
            // 
            lblNovoLogin.AutoSize = true;
            lblNovoLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovoLogin.ForeColor = Color.FromArgb(63, 136, 254);
            lblNovoLogin.Location = new Point(309, 104);
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
            txtNovoLogin.Location = new Point(243, 145);
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
            lblNovaSenha.Location = new Point(309, 200);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(169, 37);
            lblNovaSenha.TabIndex = 9;
            lblNovaSenha.Text = "Nova Senha";
            // 
            // btnSalvarNovoLoginSenha
            // 
            btnSalvarNovoLoginSenha.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvarNovoLoginSenha.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvarNovoLoginSenha.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvarNovoLoginSenha.BorderRadius = 22;
            btnSalvarNovoLoginSenha.BorderSize = 2;
            btnSalvarNovoLoginSenha.FlatAppearance.BorderSize = 0;
            btnSalvarNovoLoginSenha.FlatStyle = FlatStyle.Flat;
            btnSalvarNovoLoginSenha.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvarNovoLoginSenha.ForeColor = Color.Black;
            btnSalvarNovoLoginSenha.Location = new Point(243, 299);
            btnSalvarNovoLoginSenha.Name = "btnSalvarNovoLoginSenha";
            btnSalvarNovoLoginSenha.Size = new Size(296, 47);
            btnSalvarNovoLoginSenha.TabIndex = 8;
            btnSalvarNovoLoginSenha.Text = "SALVAR";
            btnSalvarNovoLoginSenha.TextColor = Color.Black;
            btnSalvarNovoLoginSenha.UseVisualStyleBackColor = false;
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
            txtNovaSenha.Location = new Point(243, 241);
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
            ClientSize = new Size(800, 450);
            Controls.Add(lblNovoLogin);
            Controls.Add(txtNovoLogin);
            Controls.Add(lblNovaSenha);
            Controls.Add(btnSalvarNovoLoginSenha);
            Controls.Add(txtNovaSenha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NovoLoginSenha";
            Text = "PIXELogic - Sua visão, nossa programação!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovoLogin;
        private WiLBiT.WiLBiTTextBox txtNovoLogin;
        private Label lblNovaSenha;
        private WiLBiT.WiLBiTButton2 btnSalvarNovoLoginSenha;
        private WiLBiT.WiLBiTTextBox txtNovaSenha;
    }
}