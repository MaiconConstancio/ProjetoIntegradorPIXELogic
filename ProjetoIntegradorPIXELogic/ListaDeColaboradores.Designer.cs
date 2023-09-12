namespace ProjetoIntegradorPIXELogic
{
    partial class ListaDeColaboradores
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
            btnSalvarNovoLoginSenha = new WiLBiT.WiLBiTButton2();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnSalvarNovoLoginSenha
            // 
            btnSalvarNovoLoginSenha.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvarNovoLoginSenha.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvarNovoLoginSenha.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvarNovoLoginSenha.BorderRadius = 18;
            btnSalvarNovoLoginSenha.BorderSize = 2;
            btnSalvarNovoLoginSenha.FlatAppearance.BorderSize = 0;
            btnSalvarNovoLoginSenha.FlatStyle = FlatStyle.Flat;
            btnSalvarNovoLoginSenha.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.World);
            btnSalvarNovoLoginSenha.ForeColor = Color.Black;
            btnSalvarNovoLoginSenha.Location = new Point(0, 402);
            btnSalvarNovoLoginSenha.Name = "btnSalvarNovoLoginSenha";
            btnSalvarNovoLoginSenha.Size = new Size(176, 36);
            btnSalvarNovoLoginSenha.TabIndex = 14;
            btnSalvarNovoLoginSenha.Text = "Novo Cadastro";
            btnSalvarNovoLoginSenha.TextColor = Color.Black;
            btnSalvarNovoLoginSenha.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(63, 136, 254);
            label1.Location = new Point(513, 88);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 21;
            label1.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(63, 136, 254);
            label2.Location = new Point(302, 88);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 22;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(63, 136, 254);
            label3.Location = new Point(163, 88);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 23;
            label3.Text = "Cargo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(63, 136, 254);
            label4.Location = new Point(672, 88);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 24;
            label4.Text = "Editar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(63, 136, 254);
            label5.Location = new Point(22, 88);
            label5.Name = "label5";
            label5.Size = new Size(73, 30);
            label5.TabIndex = 25;
            label5.Text = "Nome";
            // 
            // ListaDeColaboradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvarNovoLoginSenha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListaDeColaboradores";
            Text = "ListaDeColaboradores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTButton2 btnSalvarNovoLoginSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}