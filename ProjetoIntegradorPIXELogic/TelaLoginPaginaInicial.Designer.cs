using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjetoIntegradorPIXELogic
{
    partial class TelaLoginPaginaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLoginPaginaInicial));
            btnEntra = new WiLBiT.WiLBiTButton2();
            lblSenha = new Label();
            lblLogin = new Label();
            imgWallpaperLoginPrincipal = new PictureBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            imgLOGOloginPrincipal = new PictureBox();
            lblNãotemconta = new Label();
            ((System.ComponentModel.ISupportInitialize)imgWallpaperLoginPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLOGOloginPrincipal).BeginInit();
            SuspendLayout();
            // 
            // btnEntra
            // 
            btnEntra.BackColor = Color.FromArgb(72, 116, 245);
            btnEntra.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnEntra.BorderColor = Color.FromArgb(0, 242, 254);
            btnEntra.BorderRadius = 22;
            btnEntra.BorderSize = 2;
            btnEntra.FlatAppearance.BorderSize = 0;
            btnEntra.FlatStyle = FlatStyle.Flat;
            btnEntra.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntra.ForeColor = Color.Black;
            btnEntra.Location = new Point(465, 381);
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
            lblSenha.Location = new Point(458, 282);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(94, 37);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(63, 136, 254);
            lblLogin.Location = new Point(459, 209);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(89, 37);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "Login";
            // 
            // imgWallpaperLoginPrincipal
            // 
            imgWallpaperLoginPrincipal.Dock = DockStyle.Fill;
            imgWallpaperLoginPrincipal.Location = new Point(0, 0);
            imgWallpaperLoginPrincipal.Name = "imgWallpaperLoginPrincipal";
            imgWallpaperLoginPrincipal.Size = new Size(800, 450);
            imgWallpaperLoginPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            imgWallpaperLoginPrincipal.TabIndex = 7;
            imgWallpaperLoginPrincipal.TabStop = false;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(53, 81, 142);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.ForeColor = Color.Cyan;
            txtLogin.Location = new Point(465, 247);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(296, 29);
            txtLogin.TabIndex = 8;
            txtLogin.Text = "joao@desenvolvedor";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(53, 81, 142);
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.Cyan;
            txtSenha.Location = new Point(465, 319);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(296, 29);
            txtSenha.TabIndex = 9;
            txtSenha.Text = "1234";
            // 
            // imgLOGOloginPrincipal
            // 
            imgLOGOloginPrincipal.Image = (System.Drawing.Image)resources.GetObject("imgLOGOloginPrincipal.Image");
            imgLOGOloginPrincipal.Location = new Point(357, -57);
            imgLOGOloginPrincipal.Name = "imgLOGOloginPrincipal";
            imgLOGOloginPrincipal.Size = new Size(431, 327);
            imgLOGOloginPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            imgLOGOloginPrincipal.TabIndex = 10;
            imgLOGOloginPrincipal.TabStop = false;
            // 
            // lblNãotemconta
            // 
            lblNãotemconta.AutoSize = true;
            lblNãotemconta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNãotemconta.ForeColor = Color.FromArgb(63, 200, 254);
            lblNãotemconta.Location = new Point(465, 355);
            lblNãotemconta.Name = "lblNãotemconta";
            lblNãotemconta.Size = new Size(231, 19);
            lblNãotemconta.TabIndex = 11;
            lblNãotemconta.Text = "Não tem uma conta? Clique aqui!";
            lblNãotemconta.Click += lblNãotemconta_Click;
            // 
            // TelaLoginPaginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(lblSenha);
            Controls.Add(btnEntra);
            Controls.Add(imgLOGOloginPrincipal);
            Controls.Add(lblNãotemconta);
            Controls.Add(imgWallpaperLoginPrincipal);
            ForeColor = Color.FromArgb(16, 25, 56);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaLoginPaginaInicial";
            Text = " ";
            TransparencyKey = Color.DimGray;
            Load += TelaLoginPaginaInicial_Load;
            ((System.ComponentModel.ISupportInitialize)imgWallpaperLoginPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLOGOloginPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private WiLBiT.WiLBiTButton2 btnEntra;
        private Label lblSenha;
        private Label lblLogin;
        private PictureBox imgWallpaperLoginPrincipal;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private PictureBox imgLOGOloginPrincipal;
        private Label lblNãotemconta;
    }
}