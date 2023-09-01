namespace ProjetoIntegradorPIXELogic
{
    partial class Confirma
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

        private void InitializeComponent()
        {

            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // btnConfirmar
            btnConfirmar.BackColor = Color.FromArgb(0, 242, 254);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Location = new Point(501, 300);
            btnConfirmar.Name = "btnEntra";
            btnConfirmar.Size = new Size(100, 23);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "ENTRAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(0, 242, 254);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(501, 300);
            btnCancelar.Name = "btnEntra";
            btnCancelar.Size = new Size(100, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "ENTRAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(53, 81, 142);
            txtLogin.Location = new Point(501, 178);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(53, 81, 142);
            txtSenha.Location = new Point(501, 244);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;

        }

        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtLogin;
        private TextBox txtSenha;
    }
}