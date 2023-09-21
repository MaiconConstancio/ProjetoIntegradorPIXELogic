namespace ProjetoIntegradorPIXELogic
{
    partial class ListaDeProdutos
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
            btnNovoCadastro = new WiLBiT.WiLBiTButton2();
            lblNome = new Label();
            lblValor = new Label();
            lblQuantidade = new Label();
            lblFornecedor = new Label();
            lblVencimento = new Label();
            lblEditar = new Label();
            panel1 = new Panel();
            btnCapturarImagem = new WiLBiT.WiLBiTButton2();
            btnImprimir = new WiLBiT.WiLBiTButton2();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(16, 25, 56);
            btnVoltar.BackgroundColor = Color.FromArgb(16, 25, 56);
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 12;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.Cyan;
            btnVoltar.Location = new Point(714, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(74, 30);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Cyan;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.BackColor = Color.FromArgb(16, 25, 56);
            btnNovoCadastro.BackgroundColor = Color.FromArgb(16, 25, 56);
            btnNovoCadastro.BorderColor = Color.FromArgb(0, 242, 254);
            btnNovoCadastro.BorderRadius = 12;
            btnNovoCadastro.BorderSize = 2;
            btnNovoCadastro.FlatAppearance.BorderSize = 0;
            btnNovoCadastro.FlatStyle = FlatStyle.Flat;
            btnNovoCadastro.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoCadastro.ForeColor = Color.Cyan;
            btnNovoCadastro.Location = new Point(12, 406);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(150, 32);
            btnNovoCadastro.TabIndex = 2;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.TextColor = Color.Cyan;
            btnNovoCadastro.UseVisualStyleBackColor = false;
            btnNovoCadastro.Click += btnNovoCadastro_Click;
            // 
            // lblNome
            // 
            lblNome.BorderStyle = BorderStyle.FixedSingle;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.Cyan;
            lblNome.Location = new Point(13, 86);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(114, 30);
            lblNome.TabIndex = 27;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            lblValor.BorderStyle = BorderStyle.FixedSingle;
            lblValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.Cyan;
            lblValor.Location = new Point(431, 86);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(107, 30);
            lblValor.TabIndex = 28;
            lblValor.Text = "Valor";
            lblValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuantidade
            // 
            lblQuantidade.BorderStyle = BorderStyle.FixedSingle;
            lblQuantidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidade.ForeColor = Color.Cyan;
            lblQuantidade.Location = new Point(285, 86);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(140, 30);
            lblQuantidade.TabIndex = 29;
            lblQuantidade.Text = "Quantidade";
            lblQuantidade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFornecedor
            // 
            lblFornecedor.BorderStyle = BorderStyle.FixedSingle;
            lblFornecedor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFornecedor.ForeColor = Color.Cyan;
            lblFornecedor.Location = new Point(135, 86);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(141, 30);
            lblFornecedor.TabIndex = 30;
            lblFornecedor.Text = "Fornecedor";
            lblFornecedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVencimento
            // 
            lblVencimento.BorderStyle = BorderStyle.FixedSingle;
            lblVencimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVencimento.ForeColor = Color.Cyan;
            lblVencimento.Location = new Point(546, 86);
            lblVencimento.Name = "lblVencimento";
            lblVencimento.Size = new Size(130, 30);
            lblVencimento.TabIndex = 31;
            lblVencimento.Text = "Vencimento";
            lblVencimento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEditar
            // 
            lblEditar.BorderStyle = BorderStyle.FixedSingle;
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditar.ForeColor = Color.Cyan;
            lblEditar.Location = new Point(684, 86);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(100, 30);
            lblEditar.TabIndex = 32;
            lblEditar.Text = "Ação";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Location = new Point(11, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 10);
            panel1.TabIndex = 34;
            // 
            // btnCapturarImagem
            // 
            btnCapturarImagem.BackColor = Color.FromArgb(16, 25, 56);
            btnCapturarImagem.BackgroundColor = Color.FromArgb(16, 25, 56);
            btnCapturarImagem.BorderColor = Color.FromArgb(0, 242, 254);
            btnCapturarImagem.BorderRadius = 12;
            btnCapturarImagem.BorderSize = 2;
            btnCapturarImagem.FlatAppearance.BorderSize = 0;
            btnCapturarImagem.FlatStyle = FlatStyle.Flat;
            btnCapturarImagem.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapturarImagem.ForeColor = Color.Cyan;
            btnCapturarImagem.Location = new Point(12, 12);
            btnCapturarImagem.Name = "btnCapturarImagem";
            btnCapturarImagem.Size = new Size(154, 32);
            btnCapturarImagem.TabIndex = 41;
            btnCapturarImagem.Text = "Captura de tela";
            btnCapturarImagem.TextColor = Color.Cyan;
            btnCapturarImagem.UseVisualStyleBackColor = false;
            btnCapturarImagem.Click += btnCapturarImagem_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(16, 25, 56);
            btnImprimir.BackgroundColor = Color.FromArgb(16, 25, 56);
            btnImprimir.BorderColor = Color.FromArgb(0, 242, 254);
            btnImprimir.BorderRadius = 12;
            btnImprimir.BorderSize = 2;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Cyan;
            btnImprimir.Location = new Point(169, 12);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(112, 32);
            btnImprimir.TabIndex = 40;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextColor = Color.Cyan;
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // ListaDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCapturarImagem);
            Controls.Add(btnImprimir);
            Controls.Add(panel1);
            Controls.Add(lblEditar);
            Controls.Add(lblVencimento);
            Controls.Add(lblFornecedor);
            Controls.Add(lblQuantidade);
            Controls.Add(lblValor);
            Controls.Add(lblNome);
            Controls.Add(btnNovoCadastro);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListaDeProdutos";
            Text = "ListaDeProdutos";
            Load += ListaDeProdutos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTButton2 btnVoltar;
        private WiLBiT.WiLBiTButton2 btnNovoCadastro;
        private Label lblNome;
        private Label lblValor;
        private Label lblQuantidade;
        private Label lblFornecedor;
        private Label lblVencimento;
        private Label lblEditar;
        private Panel panel1;
        private WiLBiT.WiLBiTButton2 btnCapturarImagem;
        private WiLBiT.WiLBiTButton2 btnImprimir;
    }
}