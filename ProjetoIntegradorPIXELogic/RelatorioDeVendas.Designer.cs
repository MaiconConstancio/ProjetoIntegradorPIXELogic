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
            pictureBox1 = new PictureBox();
            lblMetodoSelecionado = new Label();
            lblNomeDoCliente = new Label();
            txtNomeDoCliente = new WiLBiT.WiLBiTTextBox();
            btnCancelar = new WiLBiT.WiLBiTButton2();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            btnImprimir = new WiLBiT.WiLBiTButton2();
            lblPagamentoNoMetodoSelecionado = new Label();
            lblTotal = new Label();
            lblProduto = new Label();
            lblValor = new Label();
            lblMetodoDePagamento = new Label();
            lblCliente = new Label();
            lblQuantidade = new Label();
            lblAcao = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ESCRITA_SEM_Fundo10;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblMetodoSelecionado
            // 
            lblMetodoSelecionado.AutoSize = true;
            lblMetodoSelecionado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMetodoSelecionado.ForeColor = Color.FromArgb(63, 136, 254);
            lblMetodoSelecionado.Location = new Point(12, 89);
            lblMetodoSelecionado.Name = "lblMetodoSelecionado";
            lblMetodoSelecionado.Size = new Size(229, 30);
            lblMetodoSelecionado.TabIndex = 20;
            lblMetodoSelecionado.Text = "{Método selecionado}";
            // 
            // lblNomeDoCliente
            // 
            lblNomeDoCliente.AutoSize = true;
            lblNomeDoCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeDoCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblNomeDoCliente.Location = new Point(559, 21);
            lblNomeDoCliente.Name = "lblNomeDoCliente";
            lblNomeDoCliente.Size = new Size(176, 30);
            lblNomeDoCliente.TabIndex = 21;
            lblNomeDoCliente.Text = "Nome do cliente";
            // 
            // txtNomeDoCliente
            // 
            txtNomeDoCliente.BackColor = Color.FromArgb(53, 81, 142);
            txtNomeDoCliente.BorderColor = Color.FromArgb(0, 242, 254);
            txtNomeDoCliente.BorderFocusColor = Color.DeepSkyBlue;
            txtNomeDoCliente.BorderRadius = 18;
            txtNomeDoCliente.BorderSize = 2;
            txtNomeDoCliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDoCliente.ForeColor = Color.FromArgb(160, 245, 255);
            txtNomeDoCliente.Location = new Point(519, 55);
            txtNomeDoCliente.Margin = new Padding(4);
            txtNomeDoCliente.Multiline = false;
            txtNomeDoCliente.Name = "txtNomeDoCliente";
            txtNomeDoCliente.Padding = new Padding(10, 7, 10, 7);
            txtNomeDoCliente.PasswordChar = false;
            txtNomeDoCliente.PlaceholderColor = Color.DarkGray;
            txtNomeDoCliente.PlaceholderText = "";
            txtNomeDoCliente.Size = new Size(253, 39);
            txtNomeDoCliente.TabIndex = 23;
            txtNomeDoCliente.Texts = "";
            txtNomeDoCliente.UnderlinedStyle = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(72, 116, 245);
            btnCancelar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnCancelar.BorderColor = Color.FromArgb(0, 242, 254);
            btnCancelar.BorderRadius = 16;
            btnCancelar.BorderSize = 2;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(12, 356);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 33);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextColor = Color.Black;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 16;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(137, 356);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(104, 33);
            btnSalvar.TabIndex = 25;
            btnSalvar.Text = "SALVAR";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BorderColor = Color.FromArgb(0, 242, 254);
            btnImprimir.BorderRadius = 16;
            btnImprimir.BorderSize = 2;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Location = new Point(12, 405);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(104, 33);
            btnImprimir.TabIndex = 26;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.TextColor = Color.Black;
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // lblPagamentoNoMetodoSelecionado
            // 
            lblPagamentoNoMetodoSelecionado.AutoSize = true;
            lblPagamentoNoMetodoSelecionado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagamentoNoMetodoSelecionado.ForeColor = Color.FromArgb(63, 136, 254);
            lblPagamentoNoMetodoSelecionado.Location = new Point(490, 368);
            lblPagamentoNoMetodoSelecionado.Name = "lblPagamentoNoMetodoSelecionado";
            lblPagamentoNoMetodoSelecionado.Size = new Size(298, 21);
            lblPagamentoNoMetodoSelecionado.TabIndex = 27;
            lblPagamentoNoMetodoSelecionado.Text = "Pagamento no: {Método selecionado}";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(63, 136, 254);
            lblTotal.Location = new Point(660, 420);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(128, 21);
            lblTotal.TabIndex = 28;
            lblTotal.Text = "Total: R$ 168,00";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduto.ForeColor = Color.FromArgb(63, 136, 254);
            lblProduto.Location = new Point(25, 137);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(72, 21);
            lblProduto.TabIndex = 29;
            lblProduto.Text = "Produto";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(593, 137);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(50, 21);
            lblValor.TabIndex = 30;
            lblValor.Text = "Valor";
            // 
            // lblMetodoDePagamento
            // 
            lblMetodoDePagamento.AutoSize = true;
            lblMetodoDePagamento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMetodoDePagamento.ForeColor = Color.FromArgb(63, 136, 254);
            lblMetodoDePagamento.Location = new Point(368, 137);
            lblMetodoDePagamento.Name = "lblMetodoDePagamento";
            lblMetodoDePagamento.Size = new Size(185, 21);
            lblMetodoDePagamento.TabIndex = 31;
            lblMetodoDePagamento.Text = "Método de pagamento";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblCliente.Location = new Point(264, 137);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(64, 21);
            lblCliente.TabIndex = 32;
            lblCliente.Text = "Cliente";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidade.ForeColor = Color.FromArgb(63, 136, 254);
            lblQuantidade.Location = new Point(126, 137);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(100, 21);
            lblQuantidade.TabIndex = 33;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblAcao
            // 
            lblAcao.AutoSize = true;
            lblAcao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcao.ForeColor = Color.FromArgb(63, 136, 254);
            lblAcao.Location = new Point(700, 137);
            lblAcao.Name = "lblAcao";
            lblAcao.Size = new Size(48, 21);
            lblAcao.TabIndex = 34;
            lblAcao.Text = "Ação";
            // 
            // RelatorioDeVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(lblAcao);
            Controls.Add(lblQuantidade);
            Controls.Add(lblCliente);
            Controls.Add(lblMetodoDePagamento);
            Controls.Add(lblValor);
            Controls.Add(lblProduto);
            Controls.Add(lblTotal);
            Controls.Add(lblPagamentoNoMetodoSelecionado);
            Controls.Add(btnImprimir);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNomeDoCliente);
            Controls.Add(lblNomeDoCliente);
            Controls.Add(lblMetodoSelecionado);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RelatorioDeVendas";
            Text = "RelatorioDeVendas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblMetodoSelecionado;
        private Label lblNomeDoCliente;
        private WiLBiT.WiLBiTTextBox txtNomeDoCliente;
        private WiLBiT.WiLBiTButton2 btnCancelar;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private WiLBiT.WiLBiTButton2 btnImprimir;
        private Label lblPagamentoNoMetodoSelecionado;
        private Label lblTotal;
        private Label lblProduto;
        private Label lblValor;
        private Label lblMetodoDePagamento;
        private Label lblCliente;
        private Label lblQuantidade;
        private Label lblAcao;
    }
}