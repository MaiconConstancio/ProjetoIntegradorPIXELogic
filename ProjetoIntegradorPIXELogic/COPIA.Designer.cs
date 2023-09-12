using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjetoIntegradorPIXELogic
{
    partial class COPIA
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
            txtNovo = new WiLBiT.WiLBiTTextBox();
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
            // txtNovo
            // 
            txtNovo.BackColor = Color.FromArgb(53, 81, 142);
            txtNovo.BorderColor = Color.FromArgb(0, 242, 254);
            txtNovo.BorderFocusColor = Color.DeepSkyBlue;
            txtNovo.BorderRadius = 24;
            txtNovo.BorderSize = 2;
            txtNovo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtNovo.ForeColor = Color.FromArgb(160, 245, 255);
            txtNovo.Location = new Point(243, 145);
            txtNovo.Margin = new Padding(4);
            txtNovo.Multiline = false;
            txtNovo.Name = "txtNovo";
            txtNovo.Padding = new Padding(10, 7, 10, 7);
            txtNovo.PasswordChar = false;
            txtNovo.PlaceholderColor = Color.DarkGray;
            txtNovo.PlaceholderText = "";
            txtNovo.Size = new Size(296, 51);
            txtNovo.TabIndex = 10;
            txtNovo.Texts = "";
            txtNovo.UnderlinedStyle = false;
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
            // COPIA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(lblNovoLogin);
            Controls.Add(txtNovo);
            Controls.Add(lblNovaSenha);
            Controls.Add(btnSalvarNovoLoginSenha);
            Controls.Add(txtNovaSenha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "COPIA";
            Text = "PIXELogic - Sua visão, nossa programação!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovoLogin;
        private WiLBiT.WiLBiTTextBox txtNovo;
        private Label lblNovaSenha;
        private WiLBiT.WiLBiTButton2 btnSalvarNovoLoginSenha;
        private WiLBiT.WiLBiTTextBox txtNovaSenha;
    }
}