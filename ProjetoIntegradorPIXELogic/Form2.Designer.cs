namespace ProjetoIntegradorPIXELogic
{
    partial class Form2
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
            btnSalvar = new Button();
            txtNovaSenha = new TextBox();
            txtNovoLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 242, 254);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(334, 277);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 23);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.BackColor = Color.FromArgb(53, 81, 142);
            txtNovaSenha.Location = new Point(334, 221);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(100, 23);
            txtNovaSenha.TabIndex = 8;
            // 
            // txtNovoLogin
            // 
            txtNovoLogin.BackColor = Color.FromArgb(53, 81, 142);
            txtNovoLogin.Location = new Point(334, 155);
            txtNovoLogin.Name = "txtNovoLogin";
            txtNovoLogin.Size = new Size(100, 23);
            txtNovoLogin.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(63, 136, 254);
            label2.Location = new Point(352, 203);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "Nova Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(63, 136, 254);
            label1.Location = new Point(352, 137);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 5;
            label1.Text = "Novo Login";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 10, 22);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtNovoLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtNovaSenha;
        private TextBox txtNovoLogin;
        private Label label2;
        private Label label1;
    }
}