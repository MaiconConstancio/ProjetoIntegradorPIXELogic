namespace ProjetoIntegradorPIXELogic
{
    partial class NovoCadastroDeEmpresas
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
            pictureBox1 = new PictureBox();
            lblCadastroDeNovasConta = new Label();
            txtEmpresa = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lblNome = new Label();
            lblEmpresa = new Label();
            lblEmail = new Label();
            lblLogin = new Label();
            lblSenha = new Label();
            btnCancelar = new WiLBiT.WiLBiTButton2();
            btnCadastrar = new WiLBiT.WiLBiTButton2();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ESCRITA_SEM_Fundo9;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblCadastroDeNovasConta
            // 
            lblCadastroDeNovasConta.AutoSize = true;
            lblCadastroDeNovasConta.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroDeNovasConta.ForeColor = Color.FromArgb(63, 136, 254);
            lblCadastroDeNovasConta.Location = new Point(249, 76);
            lblCadastroDeNovasConta.Name = "lblCadastroDeNovasConta";
            lblCadastroDeNovasConta.Size = new Size(295, 32);
            lblCadastroDeNovasConta.TabIndex = 36;
            lblCadastroDeNovasConta.Text = "Cadastro de novas conta";
            // 
            // txtEmpresa
            // 
            txtEmpresa.BackColor = Color.FromArgb(53, 81, 142);
            txtEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtEmpresa.Location = new Point(268, 199);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(259, 23);
            txtEmpresa.TabIndex = 37;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(53, 81, 142);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(268, 145);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(259, 23);
            txtNome.TabIndex = 38;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(53, 81, 142);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(268, 253);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 23);
            txtEmail.TabIndex = 39;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(53, 81, 142);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Location = new Point(268, 307);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(259, 23);
            txtLogin.TabIndex = 40;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(53, 81, 142);
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(268, 361);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(259, 23);
            txtSenha.TabIndex = 41;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(63, 136, 254);
            lblNome.Location = new Point(358, 117);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(66, 25);
            lblNome.TabIndex = 42;
            lblNome.Text = "Nome";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpresa.ForeColor = Color.FromArgb(63, 136, 254);
            lblEmpresa.Location = new Point(358, 171);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(87, 25);
            lblEmpresa.TabIndex = 43;
            lblEmpresa.Text = "Empresa";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(63, 136, 254);
            lblEmail.Location = new Point(369, 225);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 25);
            lblEmail.TabIndex = 44;
            lblEmail.Text = "Email";
            lblEmail.Click += label2_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(63, 136, 254);
            lblLogin.Location = new Point(365, 279);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(63, 25);
            lblLogin.TabIndex = 45;
            lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.ForeColor = Color.FromArgb(63, 136, 254);
            lblSenha.Location = new Point(365, 333);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(66, 25);
            lblSenha.TabIndex = 46;
            lblSenha.Text = "Senha";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(72, 116, 245);
            btnCancelar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnCancelar.BorderColor = Color.FromArgb(0, 242, 254);
            btnCancelar.BorderRadius = 19;
            btnCancelar.BorderSize = 2;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(499, 399);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 39);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextColor = Color.Black;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(72, 116, 245);
            btnCadastrar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnCadastrar.BorderColor = Color.FromArgb(0, 242, 254);
            btnCadastrar.BorderRadius = 19;
            btnCadastrar.BorderSize = 2;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.Black;
            btnCadastrar.Location = new Point(177, 399);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(117, 39);
            btnCadastrar.TabIndex = 48;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.TextColor = Color.Black;
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // NovoCadastroDeEmpresas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(lblEmail);
            Controls.Add(lblEmpresa);
            Controls.Add(lblNome);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtEmpresa);
            Controls.Add(lblCadastroDeNovasConta);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NovoCadastroDeEmpresas";
            Text = "NovoCadastroDeEmpresas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCadastroDeNovasConta;
        private TextBox txtEmpresa;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lblNome;
        private Label lblEmpresa;
        private Label lblEmail;
        private Label lblLogin;
        private Label lblSenha;
        private WiLBiT.WiLBiTButton2 btnCancelar;
        private WiLBiT.WiLBiTButton2 btnCadastrar;
    }
}