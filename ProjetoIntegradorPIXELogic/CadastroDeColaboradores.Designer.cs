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
            lblEscolhaSeusColaboradoresESuasCredenciais.Location = new Point(100, 86);
            lblEscolhaSeusColaboradoresESuasCredenciais.Name = "lblEscolhaSeusColaboradoresESuasCredenciais";
            lblEscolhaSeusColaboradoresESuasCredenciais.Size = new Size(600, 37);
            lblEscolhaSeusColaboradoresESuasCredenciais.TabIndex = 16;
            lblEscolhaSeusColaboradoresESuasCredenciais.Text = "Escolha seus colaboradores e suas credenciais";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(63, 136, 254);
            lblNome.Location = new Point(207, 170);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(81, 30);
            lblNome.TabIndex = 14;
            lblNome.Text = "Nome:";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 12;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(349, 384);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 32);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblCargo.ForeColor = Color.FromArgb(63, 136, 254);
            lblCargo.Location = new Point(256, 211);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(81, 30);
            lblCargo.TabIndex = 17;
            lblCargo.Text = "Cargo:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(63, 136, 254);
            lblLogin.Location = new Point(253, 252);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(76, 30);
            lblLogin.TabIndex = 19;
            lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.ForeColor = Color.FromArgb(63, 136, 254);
            lblSenha.Location = new Point(242, 293);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(81, 30);
            lblSenha.TabIndex = 21;
            lblSenha.Text = "Senha:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 12;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(714, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(74, 30);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
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
            txtNome.Location = new Point(290, 167);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(272, 29);
            txtNome.TabIndex = 1;
            // 
            // txtCargo
            // 
            txtCargo.BackColor = Color.FromArgb(53, 81, 142);
            txtCargo.BorderStyle = BorderStyle.FixedSingle;
            txtCargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargo.ForeColor = Color.Cyan;
            txtCargo.Location = new Point(339, 208);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(174, 29);
            txtCargo.TabIndex = 2;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(53, 81, 142);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.ForeColor = Color.Cyan;
            txtLogin.Location = new Point(331, 249);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(190, 29);
            txtLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(53, 81, 142);
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.Cyan;
            txtSenha.Location = new Point(325, 290);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(202, 29);
            txtSenha.TabIndex = 4;
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
        private PictureBox LogoComoWallpaper;
        private TextBox txtNome;
        private TextBox txtCargo;
        private TextBox txtLogin;
        private TextBox txtSenha;
        public WiLBiT.WiLBiTButton2 btnVoltar;
    }
}