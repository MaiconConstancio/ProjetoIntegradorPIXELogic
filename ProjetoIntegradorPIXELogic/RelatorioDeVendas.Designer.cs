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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioDeVendas));
            imgLogoEscrita = new PictureBox();
            txtNomeDoCliente = new TextBox();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            btnImprimir = new WiLBiT.WiLBiTButton2();
            btnCancelar = new WiLBiT.WiLBiTButton2();
            lblNomeDoCliente = new Label();
            lblProduto = new Label();
            lblQuantidade = new Label();
            lblCliente = new Label();
            lblMetodoDePagamento = new Label();
            lblValor = new Label();
            lblAcao = new Label();
            lblPagamentoNoMetodoSelecionado = new Label();
            lblTotal = new Label();
            lblMetodoSelecionado = new Label();
            ((System.ComponentModel.ISupportInitialize)imgLogoEscrita).BeginInit();
            SuspendLayout();
            // 
            // imgLogoEscrita
            // 
            imgLogoEscrita.Image = (Image)resources.GetObject("imgLogoEscrita.Image");
            imgLogoEscrita.Location = new Point(12, 12);
            imgLogoEscrita.Name = "imgLogoEscrita";
            imgLogoEscrita.Size = new Size(265, 78);
            imgLogoEscrita.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogoEscrita.TabIndex = 0;
            imgLogoEscrita.TabStop = false;
            // 
            // txtNomeDoCliente
            // 
            txtNomeDoCliente.BackColor = Color.FromArgb(53, 81, 142);
            txtNomeDoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeDoCliente.Location = new Point(510, 67);
            txtNomeDoCliente.Name = "txtNomeDoCliente";
            txtNomeDoCliente.Size = new Size(259, 23);
            txtNomeDoCliente.TabIndex = 25;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 19;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(135, 360);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(117, 39);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BorderColor = Color.FromArgb(0, 242, 254);
            btnImprimir.BorderRadius = 19;
            btnImprimir.BorderSize = 2;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Location = new Point(12, 410);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(117, 39);
            btnImprimir.TabIndex = 27;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextColor = Color.Black;
            btnImprimir.UseVisualStyleBackColor = false;
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
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(12, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 39);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.Black;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblNomeDoCliente
            // 
            lblNomeDoCliente.AutoSize = true;
            lblNomeDoCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeDoCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblNomeDoCliente.Location = new Point(559, 39);
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
            lblProduto.Location = new Point(12, 147);
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
            lblQuantidade.Location = new Point(125, 147);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(134, 30);
            lblQuantidade.TabIndex = 33;
            lblQuantidade.Text = "Quantidade";
            lblQuantidade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            lblCliente.BorderStyle = BorderStyle.FixedSingle;
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblCliente.Location = new Point(265, 147);
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
            lblMetodoDePagamento.Location = new Point(374, 147);
            lblMetodoDePagamento.Name = "lblMetodoDePagamento";
            lblMetodoDePagamento.Size = new Size(229, 30);
            lblMetodoDePagamento.TabIndex = 35;
            lblMetodoDePagamento.Text = "Método de pagamento";
            lblMetodoDePagamento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            lblValor.BorderStyle = BorderStyle.FixedSingle;
            lblValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(609, 147);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(117, 30);
            lblValor.TabIndex = 36;
            lblValor.Text = "Valor";
            lblValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAcao
            // 
            lblAcao.BorderStyle = BorderStyle.FixedSingle;
            lblAcao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcao.ForeColor = Color.FromArgb(63, 136, 254);
            lblAcao.Location = new Point(732, 147);
            lblAcao.Name = "lblAcao";
            lblAcao.Size = new Size(64, 30);
            lblAcao.TabIndex = 37;
            lblAcao.Text = "Ação";
            lblAcao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPagamentoNoMetodoSelecionado
            // 
            lblPagamentoNoMetodoSelecionado.AutoSize = true;
            lblPagamentoNoMetodoSelecionado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagamentoNoMetodoSelecionado.ForeColor = Color.FromArgb(63, 136, 254);
            lblPagamentoNoMetodoSelecionado.Location = new Point(490, 369);
            lblPagamentoNoMetodoSelecionado.Name = "lblPagamentoNoMetodoSelecionado";
            lblPagamentoNoMetodoSelecionado.Size = new Size(298, 21);
            lblPagamentoNoMetodoSelecionado.TabIndex = 38;
            lblPagamentoNoMetodoSelecionado.Text = "Pagamento no: {Método selecionado}";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(63, 136, 254);
            lblTotal.Location = new Point(701, 420);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(68, 21);
            lblTotal.TabIndex = 39;
            lblTotal.Text = "{TOTAL}";
            // 
            // lblMetodoSelecionado
            // 
            lblMetodoSelecionado.AutoSize = true;
            lblMetodoSelecionado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMetodoSelecionado.ForeColor = Color.FromArgb(63, 136, 254);
            lblMetodoSelecionado.Location = new Point(12, 110);
            lblMetodoSelecionado.Name = "lblMetodoSelecionado";
            lblMetodoSelecionado.Size = new Size(178, 21);
            lblMetodoSelecionado.TabIndex = 40;
            lblMetodoSelecionado.Text = "{Método selecionado}";
            // 
            // RelatorioDeVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(lblMetodoSelecionado);
            Controls.Add(lblTotal);
            Controls.Add(lblPagamentoNoMetodoSelecionado);
            Controls.Add(lblAcao);
            Controls.Add(lblValor);
            Controls.Add(lblMetodoDePagamento);
            Controls.Add(lblCliente);
            Controls.Add(lblQuantidade);
            Controls.Add(lblProduto);
            Controls.Add(lblNomeDoCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnImprimir);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeDoCliente);
            Controls.Add(imgLogoEscrita);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RelatorioDeVendas";
            Text = "RelatorioDeVendas";
            ((System.ComponentModel.ISupportInitialize)imgLogoEscrita).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgLogoEscrita;
        private TextBox txtNomeDoCliente;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private WiLBiT.WiLBiTButton2 btnImprimir;
        private WiLBiT.WiLBiTButton2 btnCancelar;
        private Label lblNomeDoCliente;
        private Label lblProduto;
        private Label lblQuantidade;
        private Label lblCliente;
        private Label lblMetodoDePagamento;
        private Label lblValor;
        private Label lblAcao;
        private Label lblPagamentoNoMetodoSelecionado;
        private Label lblTotal;
        private Label lblMetodoSelecionado;
    }
}