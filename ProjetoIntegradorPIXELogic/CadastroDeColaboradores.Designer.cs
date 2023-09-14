namespace ProjetoIntegradorPIXELogic
{
    partial class CadastroDeColaboradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeColaboradores));
            lblEscolhaSeusColaboradoresESuasCredenciais = new Label();
            lblNome = new Label();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            lblCargo = new Label();
            lblLogin = new Label();
            lblSenha = new Label();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            LogoComoWallpaper = new PictureBox();
            txtNome = new TextBox();
            txtCargo = new TextBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).BeginInit();
            SuspendLayout();
            // 
            // lblEscolhaSeusColaboradoresESuasCredenciais
            // 
            lblEscolhaSeusColaboradoresESuasCredenciais.AutoSize = true;
            lblEscolhaSeusColaboradoresESuasCredenciais.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblEscolhaSeusColaboradoresESuasCredenciais.ForeColor = Color.Cyan;
            lblEscolhaSeusColaboradoresESuasCredenciais.Location = new Point(100, 50);
            lblEscolhaSeusColaboradoresESuasCredenciais.Name = "lblEscolhaSeusColaboradoresESuasCredenciais";
            lblEscolhaSeusColaboradoresESuasCredenciais.Size = new Size(600, 37);
            lblEscolhaSeusColaboradoresESuasCredenciais.TabIndex = 16;
            lblEscolhaSeusColaboradoresESuasCredenciais.Text = "Escolha seus colaboradores e suas credenciais";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(63, 136, 254);
            lblNome.Location = new Point(249, 115);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(71, 25);
            lblNome.TabIndex = 14;
            lblNome.Text = "Nome:";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 18;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.World);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(333, 390);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(135, 36);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "SALVAR";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCargo.ForeColor = Color.FromArgb(63, 136, 254);
            lblCargo.Location = new Point(249, 173);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(71, 25);
            lblCargo.TabIndex = 17;
            lblCargo.Text = "Cargo:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(63, 136, 254);
            lblLogin.Location = new Point(249, 231);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(68, 25);
            lblLogin.TabIndex = 19;
            lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.ForeColor = Color.FromArgb(63, 136, 254);
            lblSenha.Location = new Point(249, 289);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(71, 25);
            lblSenha.TabIndex = 21;
            lblSenha.Text = "Senha:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 14;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(677, 7);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(111, 31);
            btnVoltar.TabIndex = 23;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // LogoComoWallpaper
            // 
            LogoComoWallpaper.Dock = DockStyle.Fill;
            LogoComoWallpaper.Image = (Image)resources.GetObject("LogoComoWallpaper.Image");
            LogoComoWallpaper.Location = new Point(0, 0);
            LogoComoWallpaper.Name = "LogoComoWallpaper";
            LogoComoWallpaper.Size = new Size(800, 450);
            LogoComoWallpaper.SizeMode = PictureBoxSizeMode.Zoom;
            LogoComoWallpaper.TabIndex = 24;
            LogoComoWallpaper.TabStop = false;
            LogoComoWallpaper.Click += LogoComoWallpaper_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(53, 81, 142);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = Color.Cyan;
            txtNome.Location = new Point(252, 142);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(296, 29);
            txtNome.TabIndex = 64;
            // 
            // txtCargo
            // 
            txtCargo.BackColor = Color.FromArgb(53, 81, 142);
            txtCargo.BorderStyle = BorderStyle.FixedSingle;
            txtCargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargo.ForeColor = Color.Cyan;
            txtCargo.Location = new Point(252, 200);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(296, 29);
            txtCargo.TabIndex = 65;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(53, 81, 142);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.ForeColor = Color.Cyan;
            txtLogin.Location = new Point(252, 258);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(296, 29);
            txtLogin.TabIndex = 66;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(53, 81, 142);
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.Cyan;
            txtSenha.Location = new Point(252, 316);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(296, 29);
            txtSenha.TabIndex = 67;
            // 
            // CadastroDeColaboradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(txtCargo);
            Controls.Add(txtNome);
            Controls.Add(lblEscolhaSeusColaboradoresESuasCredenciais);
            Controls.Add(btnVoltar);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(lblCargo);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Controls.Add(LogoComoWallpaper);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroDeColaboradores";
            Text = "CadastroDeColaboradores";
            Load += CadastroDeColaboradores_Load;
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEscolhaSeusColaboradoresESuasCredenciais;
        private Label lblNome;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private Label lblCargo;
        private Label lblLogin;
        private Label lblSenha;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private PictureBox LogoComoWallpaper;
        private TextBox txtNome;
        private TextBox txtCargo;
        private TextBox txtLogin;
        private TextBox txtSenha;
    }
}