namespace ProjetoIntegradorPIXELogic
{
    partial class RelatorioDeVendas
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
            txtNomeDoCliente = new TextBox();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            btnCancelar = new WiLBiT.WiLBiTButton2();
            lblNomeDoCliente = new Label();
            lblProduto = new Label();
            lblQuantidade = new Label();
            lblCliente = new Label();
            lblMetodoDePagamento = new Label();
            lblValor = new Label();
            lblAcao = new Label();
            lblTotal = new Label();
            panel1 = new Panel();
            btnCapturarImagem = new WiLBiT.WiLBiTButton2();
            btnImprimir = new WiLBiT.WiLBiTButton2();
            SuspendLayout();
            // 
            // txtNomeDoCliente
            // 
            txtNomeDoCliente.BackColor = Color.FromArgb(53, 81, 142);
            txtNomeDoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeDoCliente.ForeColor = Color.Cyan;
            txtNomeDoCliente.Location = new Point(510, 46);
            txtNomeDoCliente.Name = "txtNomeDoCliente";
            txtNomeDoCliente.Size = new Size(259, 23);
            txtNomeDoCliente.TabIndex = 1;
            txtNomeDoCliente.TextChanged += txtNomeDoCliente_TextChanged;
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
            btnSalvar.Location = new Point(125, 406);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 32);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(72, 116, 245);
            btnCancelar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnCancelar.BorderColor = Color.FromArgb(0, 242, 254);
            btnCancelar.BorderRadius = 12;
            btnCancelar.BorderSize = 2;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(11, 406);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 32);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.Black;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNomeDoCliente
            // 
            lblNomeDoCliente.AutoSize = true;
            lblNomeDoCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeDoCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblNomeDoCliente.Location = new Point(559, 18);
            lblNomeDoCliente.Name = "lblNomeDoCliente";
            lblNomeDoCliente.Size = new Size(158, 25);
            lblNomeDoCliente.TabIndex = 31;
            lblNomeDoCliente.Text = "Nome do cliente";
            // 
            // lblProduto
            // 
            lblProduto.BorderStyle = BorderStyle.FixedSingle;
            lblProduto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduto.ForeColor = Color.FromArgb(63, 136, 254);
            lblProduto.Location = new Point(11, 86);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(107, 30);
            lblProduto.TabIndex = 32;
            lblProduto.Text = "Produto";
            lblProduto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuantidade
            // 
            lblQuantidade.BorderStyle = BorderStyle.FixedSingle;
            lblQuantidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidade.ForeColor = Color.FromArgb(63, 136, 254);
            lblQuantidade.Location = new Point(123, 86);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(133, 30);
            lblQuantidade.TabIndex = 33;
            lblQuantidade.Text = "Quantidade";
            lblQuantidade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            lblCliente.BorderStyle = BorderStyle.FixedSingle;
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblCliente.Location = new Point(262, 86);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(103, 30);
            lblCliente.TabIndex = 34;
            lblCliente.Text = "Cliente";
            lblCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMetodoDePagamento
            // 
            lblMetodoDePagamento.BorderStyle = BorderStyle.FixedSingle;
            lblMetodoDePagamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMetodoDePagamento.ForeColor = Color.FromArgb(63, 136, 254);
            lblMetodoDePagamento.Location = new Point(371, 86);
            lblMetodoDePagamento.Name = "lblMetodoDePagamento";
            lblMetodoDePagamento.Size = new Size(227, 30);
            lblMetodoDePagamento.TabIndex = 35;
            lblMetodoDePagamento.Text = "Método de pagamento";
            lblMetodoDePagamento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            lblValor.BorderStyle = BorderStyle.FixedSingle;
            lblValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(604, 86);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(115, 30);
            lblValor.TabIndex = 36;
            lblValor.Text = "Valor";
            lblValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAcao
            // 
            lblAcao.BorderStyle = BorderStyle.FixedSingle;
            lblAcao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcao.ForeColor = Color.FromArgb(63, 136, 254);
            lblAcao.Location = new Point(724, 86);
            lblAcao.Name = "lblAcao";
            lblAcao.Size = new Size(64, 30);
            lblAcao.TabIndex = 37;
            lblAcao.Text = "Ação";
            lblAcao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(63, 136, 254);
            lblTotal.Location = new Point(681, 420);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 21);
            lblTotal.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Location = new Point(11, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 10);
            panel1.TabIndex = 41;
            panel1.Paint += panel1_Paint;
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
            btnCapturarImagem.TabIndex = 43;
            btnCapturarImagem.Text = "Captura de tela";
            btnCapturarImagem.TextColor = Color.Black;
            btnCapturarImagem.UseVisualStyleBackColor = false;
            btnCapturarImagem.Click += btnCapturarImagem_Click;
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
            btnImprimir.TabIndex = 42;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextColor = Color.Black;
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // RelatorioDeVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCapturarImagem);
            Controls.Add(btnImprimir);
            Controls.Add(panel1);
            Controls.Add(lblTotal);
            Controls.Add(lblAcao);
            Controls.Add(lblValor);
            Controls.Add(lblMetodoDePagamento);
            Controls.Add(lblCliente);
            Controls.Add(lblQuantidade);
            Controls.Add(lblProduto);
            Controls.Add(lblNomeDoCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeDoCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RelatorioDeVendas";
            Text = "RelatorioDeVendas";
            Load += RelatorioDeVendas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private WiLBiT.WiLBiTButton2 btnCancelar;
        private Label lblNomeDoCliente;
        private Label lblProduto;
        private Label lblQuantidade;
        private Label lblCliente;
        private Label lblMetodoDePagamento;
        private Label lblValor;
        private Label lblAcao;
        private Label lblTotal;
        private Panel panel1;
        private WiLBiT.WiLBiTButton2 btnCapturarImagem;
        private WiLBiT.WiLBiTButton2 btnImprimir;
        public TextBox txtNomeDoCliente;
    }
}