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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            imgLOGOloginPrincipal = new PictureBox();
            label1 = new Label();
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
            imgWallpaperLoginPrincipal.Image = Properties.Resources.Tela_Login_Objeto;
            imgWallpaperLoginPrincipal.Location = new Point(0, 0);
            imgWallpaperLoginPrincipal.Name = "imgWallpaperLoginPrincipal";
            imgWallpaperLoginPrincipal.Size = new Size(800, 450);
            imgWallpaperLoginPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            imgWallpaperLoginPrincipal.TabIndex = 7;
            imgWallpaperLoginPrincipal.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(53, 81, 142);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Cyan;
            textBox1.Location = new Point(465, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 29);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(53, 81, 142);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Cyan;
            textBox2.Location = new Point(465, 319);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 29);
            textBox2.TabIndex = 9;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(63, 200, 254);
            label1.Location = new Point(465, 355);
            label1.Name = "label1";
            label1.Size = new Size(209, 19);
            label1.TabIndex = 11;
            label1.Text = "Não tem uma conta? crie aqui";
            // 
            // TelaLoginPaginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblLogin);
            Controls.Add(lblSenha);
            Controls.Add(btnEntra);
            Controls.Add(imgLOGOloginPrincipal);
            Controls.Add(label1);
            Controls.Add(imgWallpaperLoginPrincipal);
            ForeColor = Color.FromArgb(16, 25, 56);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaLoginPaginaInicial";
            Text = " ";
            TransparencyKey = Color.Transparent;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox imgLOGOloginPrincipal;
        private Label label1;
    }
}