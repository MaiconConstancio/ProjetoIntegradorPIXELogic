namespace ProjetoIntegradorPIXELogic
{
    partial class Vendas
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
            btnVoltar = new WiLBiT.WiLBiTButton2();
            txtNomeDoCliente = new TextBox();
            txtQuantidade = new TextBox();
            cmbProduto = new ComboBox();
            cmbMetodoDePagamento = new ComboBox();
            maskValor = new MaskedTextBox();
            lblNome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            btnVerTodosOsItens = new WiLBiT.WiLBiTButton2();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ESCRITA_SEM_Fundo10;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 19;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(671, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(117, 39);
            btnVoltar.TabIndex = 22;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // txtNomeDoCliente
            // 
            txtNomeDoCliente.BackColor = Color.FromArgb(53, 81, 142);
            txtNomeDoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeDoCliente.Location = new Point(547, 146);
            txtNomeDoCliente.Name = "txtNomeDoCliente";
            txtNomeDoCliente.Size = new Size(241, 23);
            txtNomeDoCliente.TabIndex = 23;
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.FromArgb(53, 81, 142);
            txtQuantidade.BorderStyle = BorderStyle.FixedSingle;
            txtQuantidade.Location = new Point(265, 147);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(259, 23);
            txtQuantidade.TabIndex = 24;
            // 
            // cmbProduto
            // 
            cmbProduto.BackColor = Color.FromArgb(53, 81, 142);
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(3, 147);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(229, 23);
            cmbProduto.TabIndex = 27;
            // 
            // cmbMetodoDePagamento
            // 
            cmbMetodoDePagamento.BackColor = Color.FromArgb(53, 81, 142);
            cmbMetodoDePagamento.Cursor = Cursors.SizeNESW;
            cmbMetodoDePagamento.FormattingEnabled = true;
            cmbMetodoDePagamento.Location = new Point(51, 257);
            cmbMetodoDePagamento.Name = "cmbMetodoDePagamento";
            cmbMetodoDePagamento.Size = new Size(290, 23);
            cmbMetodoDePagamento.TabIndex = 28;
            // 
            // maskValor
            // 
            maskValor.BackColor = Color.FromArgb(53, 81, 142);
            maskValor.BorderStyle = BorderStyle.FixedSingle;
            maskValor.Location = new Point(444, 257);
            maskValor.Name = "maskValor";
            maskValor.Size = new Size(284, 23);
            maskValor.TabIndex = 29;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(63, 136, 254);
            lblNome.Location = new Point(342, 118);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(116, 25);
            lblNome.TabIndex = 30;
            lblNome.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(63, 136, 254);
            label1.Location = new Point(557, 229);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 31;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(63, 136, 254);
            label2.Location = new Point(79, 229);
            label2.Name = "label2";
            label2.Size = new Size(217, 25);
            label2.TabIndex = 32;
            label2.Text = "Método de pagamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(63, 136, 254);
            label3.Location = new Point(587, 118);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 33;
            label3.Text = "Nome do cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(63, 136, 254);
            label4.Location = new Point(68, 118);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 34;
            label4.Text = "Produto";
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
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(188, 353);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(133, 39);
            btnSalvar.TabIndex = 35;
            btnSalvar.Text = "SALVAR";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnVerTodosOsItens
            // 
            btnVerTodosOsItens.BackColor = Color.FromArgb(72, 116, 245);
            btnVerTodosOsItens.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnVerTodosOsItens.BorderColor = Color.FromArgb(0, 242, 254);
            btnVerTodosOsItens.BorderRadius = 19;
            btnVerTodosOsItens.BorderSize = 2;
            btnVerTodosOsItens.FlatAppearance.BorderSize = 0;
            btnVerTodosOsItens.FlatStyle = FlatStyle.Flat;
            btnVerTodosOsItens.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerTodosOsItens.ForeColor = Color.Black;
            btnVerTodosOsItens.Location = new Point(428, 353);
            btnVerTodosOsItens.Name = "btnVerTodosOsItens";
            btnVerTodosOsItens.Size = new Size(201, 39);
            btnVerTodosOsItens.TabIndex = 36;
            btnVerTodosOsItens.Text = "VER TODOS OS ITENS";
            btnVerTodosOsItens.TextColor = Color.Black;
            btnVerTodosOsItens.UseVisualStyleBackColor = false;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerTodosOsItens);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNome);
            Controls.Add(maskValor);
            Controls.Add(cmbMetodoDePagamento);
            Controls.Add(cmbProduto);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNomeDoCliente);
            Controls.Add(btnVoltar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vendas";
            Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private TextBox txtNomeDoCliente;
        private TextBox txtQuantidade;
        private ComboBox cmbProduto;
        private ComboBox cmbMetodoDePagamento;
        private MaskedTextBox maskValor;
        private Label lblNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private WiLBiT.WiLBiTButton2 btnVerTodosOsItens;
    }
}