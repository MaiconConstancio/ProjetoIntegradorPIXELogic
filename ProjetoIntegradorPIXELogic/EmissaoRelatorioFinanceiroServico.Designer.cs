namespace ProjetoIntegradorPIXELogic
{
    partial class EmissaoRelatorioFinanceiroservico
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
            btnVoltar = new WiLBiT.WiLBiTButton2();
            btnImprimir = new WiLBiT.WiLBiTButton2();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            lblServicos = new Label();
            lblCliente = new Label();
            lblValor = new Label();
            lblAcao = new Label();
            panel1 = new Panel();
            btnCapturarImagem = new WiLBiT.WiLBiTButton2();
            SuspendLayout();
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
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BorderColor = Color.FromArgb(0, 242, 254);
            btnImprimir.BorderRadius = 12;
            btnImprimir.BorderSize = 2;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Location = new Point(169, 12);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(112, 32);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextColor = Color.Black;
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
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
            btnSalvar.Location = new Point(11, 406);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 32);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblServicos
            // 
            lblServicos.BorderStyle = BorderStyle.FixedSingle;
            lblServicos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblServicos.ForeColor = Color.FromArgb(63, 136, 254);
            lblServicos.Location = new Point(12, 86);
            lblServicos.Name = "lblServicos";
            lblServicos.Size = new Size(189, 30);
            lblServicos.TabIndex = 27;
            lblServicos.Text = "Serviços";
            lblServicos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            lblCliente.BorderStyle = BorderStyle.FixedSingle;
            lblCliente.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblCliente.Location = new Point(209, 86);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(189, 30);
            lblCliente.TabIndex = 28;
            lblCliente.Text = "Cliente";
            lblCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            lblValor.BorderStyle = BorderStyle.FixedSingle;
            lblValor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(404, 86);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(189, 30);
            lblValor.TabIndex = 29;
            lblValor.Text = "Valor";
            lblValor.TextAlign = ContentAlignment.MiddleCenter;
            lblValor.Click += lblValor_Click;
            // 
            // lblAcao
            // 
            lblAcao.BorderStyle = BorderStyle.FixedSingle;
            lblAcao.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcao.ForeColor = Color.FromArgb(63, 136, 254);
            lblAcao.Location = new Point(599, 86);
            lblAcao.Name = "lblAcao";
            lblAcao.Size = new Size(189, 30);
            lblAcao.TabIndex = 30;
            lblAcao.Text = "Ação";
            lblAcao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Location = new Point(11, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 10);
            panel1.TabIndex = 31;
            // 
            // btnCapturarImagem
            // 
            btnCapturarImagem.BackColor = Color.FromArgb(72, 116, 245);
            btnCapturarImagem.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnCapturarImagem.BorderColor = Color.FromArgb(0, 242, 254);
            btnCapturarImagem.BorderRadius = 12;
            btnCapturarImagem.BorderSize = 2;
            btnCapturarImagem.FlatAppearance.BorderSize = 0;
            btnCapturarImagem.FlatStyle = FlatStyle.Flat;
            btnCapturarImagem.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapturarImagem.ForeColor = Color.Black;
            btnCapturarImagem.Location = new Point(12, 12);
            btnCapturarImagem.Name = "btnCapturarImagem";
            btnCapturarImagem.Size = new Size(154, 32);
            btnCapturarImagem.TabIndex = 40;
            btnCapturarImagem.Text = "Captura de tela";
            btnCapturarImagem.TextColor = Color.Black;
            btnCapturarImagem.UseVisualStyleBackColor = false;
            btnCapturarImagem.Click += btnCapturarImagem_Click;
            // 
            // EmissaoRelatorioFinanceiroservico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCapturarImagem);
            Controls.Add(panel1);
            Controls.Add(lblAcao);
            Controls.Add(lblValor);
            Controls.Add(lblCliente);
            Controls.Add(lblServicos);
            Controls.Add(btnSalvar);
            Controls.Add(btnImprimir);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmissaoRelatorioFinanceiroservico";
            Text = "Form1";
            Load += EmissaoRelatorioFinanceiroservico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private WiLBiT.WiLBiTButton2 btnImprimir;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private Label lblServicos;
        private Label lblCliente;
        private Label lblValor;
        private Label lblAcao;
        private Panel panel1;
        private WiLBiT.WiLBiTButton2 btnCapturarImagem;
    }
}