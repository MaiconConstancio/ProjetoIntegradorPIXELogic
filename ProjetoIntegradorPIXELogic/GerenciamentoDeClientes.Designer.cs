namespace ProjetoIntegradorPIXELogic
{
    partial class GerenciamentoDeClientes
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
            btnNovoCadastro = new WiLBiT.WiLBiTButton2();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.BackColor = Color.FromArgb(72, 116, 245);
            btnNovoCadastro.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnNovoCadastro.BorderColor = Color.FromArgb(0, 242, 254);
            btnNovoCadastro.BorderRadius = 14;
            btnNovoCadastro.BorderSize = 2;
            btnNovoCadastro.FlatAppearance.BorderSize = 0;
            btnNovoCadastro.FlatStyle = FlatStyle.Flat;
            btnNovoCadastro.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnNovoCadastro.ForeColor = Color.Black;
            btnNovoCadastro.Location = new Point(12, 411);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(121, 31);
            btnNovoCadastro.TabIndex = 30;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.TextColor = Color.Black;
            btnNovoCadastro.UseVisualStyleBackColor = false;
            btnNovoCadastro.Click += btnNovoCadastro_Click;
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
            btnVoltar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(713, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 31);
            btnVoltar.TabIndex = 36;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Location = new Point(1, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 0);
            panel1.TabIndex = 37;
            // 
            // GerenciamentoDeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnVoltar);
            Controls.Add(btnNovoCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GerenciamentoDeClientes";
            Text = "    ";
            Load += GerenciamentoDeClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEscolhaSeusColaboradoresESuasCredenciais;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private WiLBiT.WiLBiTButton2 btnNovoCadastro;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private Panel panel1;
    }
}