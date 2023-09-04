using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjetoIntegradorPIXELogic
{
    partial class TelaCredenciais
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
            lblNomeCredenciais = new Label();
            txtNomeCredenciais = new WiLBiT.WiLBiTTextBox();
            lblCargoCredenciais = new Label();
            btnAvançarCredenciais = new WiLBiT.WiLBiTButton2();
            txtCargoCredenciais = new WiLBiT.WiLBiTTextBox();
            lblSenhaCredenciais = new Label();
            txtSenhaCredenciais = new WiLBiT.WiLBiTTextBox();
            lblSejaBemVindo = new Label();
            lblEscolhaSuaEquipeESuasCredenciais = new Label();
            SuspendLayout();
            // 
            // lblNomeCredenciais
            // 
            lblNomeCredenciais.AutoSize = true;
            lblNomeCredenciais.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeCredenciais.ForeColor = Color.FromArgb(63, 136, 254);
            lblNomeCredenciais.Location = new Point(239, 137);
            lblNomeCredenciais.Name = "lblNomeCredenciais";
            lblNomeCredenciais.Size = new Size(102, 37);
            lblNomeCredenciais.TabIndex = 11;
            lblNomeCredenciais.Text = "Nome:";
            // 
            // txtNomeCredenciais
            // 
            txtNomeCredenciais.BackColor = Color.FromArgb(53, 81, 142);
            txtNomeCredenciais.BorderColor = Color.FromArgb(0, 242, 254);
            txtNomeCredenciais.BorderFocusColor = Color.DeepSkyBlue;
            txtNomeCredenciais.BorderRadius = 24;
            txtNomeCredenciais.BorderSize = 2;
            txtNomeCredenciais.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCredenciais.ForeColor = Color.FromArgb(160, 245, 255);
            txtNomeCredenciais.Location = new Point(229, 178);
            txtNomeCredenciais.Margin = new Padding(4);
            txtNomeCredenciais.Multiline = false;
            txtNomeCredenciais.Name = "txtNomeCredenciais";
            txtNomeCredenciais.Padding = new Padding(10, 7, 10, 7);
            txtNomeCredenciais.PasswordChar = false;
            txtNomeCredenciais.PlaceholderColor = Color.DarkGray;
            txtNomeCredenciais.PlaceholderText = "";
            txtNomeCredenciais.Size = new Size(296, 51);
            txtNomeCredenciais.TabIndex = 10;
            txtNomeCredenciais.Texts = "";
            txtNomeCredenciais.UnderlinedStyle = false;
            // 
            // lblCargoCredenciais
            // 
            lblCargoCredenciais.AutoSize = true;
            lblCargoCredenciais.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCargoCredenciais.ForeColor = Color.FromArgb(63, 136, 254);
            lblCargoCredenciais.Location = new Point(247, 233);
            lblCargoCredenciais.Name = "lblCargoCredenciais";
            lblCargoCredenciais.Size = new Size(101, 37);
            lblCargoCredenciais.TabIndex = 9;
            lblCargoCredenciais.Text = "Cargo:";
            // 
            // btnAvançarCredenciais
            // 
            btnAvançarCredenciais.BackColor = Color.FromArgb(72, 116, 245);
            btnAvançarCredenciais.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnAvançarCredenciais.BorderColor = Color.FromArgb(0, 242, 254);
            btnAvançarCredenciais.BorderRadius = 22;
            btnAvançarCredenciais.BorderSize = 2;
            btnAvançarCredenciais.FlatAppearance.BorderSize = 0;
            btnAvançarCredenciais.FlatStyle = FlatStyle.Flat;
            btnAvançarCredenciais.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnAvançarCredenciais.ForeColor = Color.Black;
            btnAvançarCredenciais.Location = new Point(229, 433);
            btnAvançarCredenciais.Name = "btnAvançarCredenciais";
            btnAvançarCredenciais.Size = new Size(296, 47);
            btnAvançarCredenciais.TabIndex = 8;
            btnAvançarCredenciais.Text = "AVANÇAR";
            btnAvançarCredenciais.TextColor = Color.Black;
            btnAvançarCredenciais.UseVisualStyleBackColor = false;
            // 
            // txtCargoCredenciais
            // 
            txtCargoCredenciais.BackColor = Color.FromArgb(53, 81, 142);
            txtCargoCredenciais.BorderColor = Color.FromArgb(0, 242, 254);
            txtCargoCredenciais.BorderFocusColor = Color.DeepSkyBlue;
            txtCargoCredenciais.BorderRadius = 24;
            txtCargoCredenciais.BorderSize = 2;
            txtCargoCredenciais.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargoCredenciais.ForeColor = Color.FromArgb(160, 245, 255);
            txtCargoCredenciais.Location = new Point(229, 274);
            txtCargoCredenciais.Margin = new Padding(4);
            txtCargoCredenciais.Multiline = false;
            txtCargoCredenciais.Name = "txtCargoCredenciais";
            txtCargoCredenciais.Padding = new Padding(10, 7, 10, 7);
            txtCargoCredenciais.PasswordChar = false;
            txtCargoCredenciais.PlaceholderColor = Color.DarkGray;
            txtCargoCredenciais.PlaceholderText = "";
            txtCargoCredenciais.Size = new Size(296, 51);
            txtCargoCredenciais.TabIndex = 7;
            txtCargoCredenciais.Texts = "";
            txtCargoCredenciais.UnderlinedStyle = false;
            // 
            // lblSenhaCredenciais
            // 
            lblSenhaCredenciais.AutoSize = true;
            lblSenhaCredenciais.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenhaCredenciais.ForeColor = Color.FromArgb(63, 136, 254);
            lblSenhaCredenciais.Location = new Point(247, 334);
            lblSenhaCredenciais.Name = "lblSenhaCredenciais";
            lblSenhaCredenciais.Size = new Size(101, 37);
            lblSenhaCredenciais.TabIndex = 13;
            lblSenhaCredenciais.Text = "Senha:";
            // 
            // txtSenhaCredenciais
            // 
            txtSenhaCredenciais.BackColor = Color.FromArgb(53, 81, 142);
            txtSenhaCredenciais.BorderColor = Color.FromArgb(0, 242, 254);
            txtSenhaCredenciais.BorderFocusColor = Color.DeepSkyBlue;
            txtSenhaCredenciais.BorderRadius = 24;
            txtSenhaCredenciais.BorderSize = 2;
            txtSenhaCredenciais.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaCredenciais.ForeColor = Color.FromArgb(160, 245, 255);
            txtSenhaCredenciais.Location = new Point(229, 375);
            txtSenhaCredenciais.Margin = new Padding(4);
            txtSenhaCredenciais.Multiline = false;
            txtSenhaCredenciais.Name = "txtSenhaCredenciais";
            txtSenhaCredenciais.Padding = new Padding(10, 7, 10, 7);
            txtSenhaCredenciais.PasswordChar = false;
            txtSenhaCredenciais.PlaceholderColor = Color.DarkGray;
            txtSenhaCredenciais.PlaceholderText = "";
            txtSenhaCredenciais.Size = new Size(296, 51);
            txtSenhaCredenciais.TabIndex = 12;
            txtSenhaCredenciais.Texts = "";
            txtSenhaCredenciais.UnderlinedStyle = false;
            // 
            // lblSejaBemVindo
            // 
            lblSejaBemVindo.AutoSize = true;
            lblSejaBemVindo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblSejaBemVindo.ForeColor = Color.FromArgb(160, 245, 255);
            lblSejaBemVindo.Location = new Point(254, 18);
            lblSejaBemVindo.Name = "lblSejaBemVindo";
            lblSejaBemVindo.Size = new Size(230, 37);
            lblSejaBemVindo.TabIndex = 14;
            lblSejaBemVindo.Text = "Sejá Bem-Vindo!";
            // 
            // lblEscolhaSuaEquipeESuasCredenciais
            // 
            lblEscolhaSuaEquipeESuasCredenciais.AutoSize = true;
            lblEscolhaSuaEquipeESuasCredenciais.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblEscolhaSuaEquipeESuasCredenciais.ForeColor = Color.FromArgb(160, 245, 255);
            lblEscolhaSuaEquipeESuasCredenciais.Location = new Point(130, 71);
            lblEscolhaSuaEquipeESuasCredenciais.Name = "lblEscolhaSuaEquipeESuasCredenciais";
            lblEscolhaSuaEquipeESuasCredenciais.Size = new Size(491, 37);
            lblEscolhaSuaEquipeESuasCredenciais.TabIndex = 15;
            lblEscolhaSuaEquipeESuasCredenciais.Text = "Escolha sua equipe e suas credenciais";
            // 
            // Credenciais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 502);
            Controls.Add(lblEscolhaSuaEquipeESuasCredenciais);
            Controls.Add(lblSejaBemVindo);
            Controls.Add(lblSenhaCredenciais);
            Controls.Add(txtSenhaCredenciais);
            Controls.Add(lblNomeCredenciais);
            Controls.Add(txtNomeCredenciais);
            Controls.Add(lblCargoCredenciais);
            Controls.Add(btnAvançarCredenciais);
            Controls.Add(txtCargoCredenciais);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Credenciais";
            Text = "   ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblNomeCredenciais;
        private WiLBiT.WiLBiTTextBox txtNomeCredenciais;
        private Label lblCargoCredenciais;
        private WiLBiT.WiLBiTButton2 btnAvançarCredenciais;
        private WiLBiT.WiLBiTTextBox txtCargoCredenciais;
        private Label lblSenhaCredenciais;
        private WiLBiT.WiLBiTTextBox txtSenhaCredenciais;
        private Label lblSejaBemVindo;
        private Label lblEscolhaSuaEquipeESuasCredenciais;
    }
}