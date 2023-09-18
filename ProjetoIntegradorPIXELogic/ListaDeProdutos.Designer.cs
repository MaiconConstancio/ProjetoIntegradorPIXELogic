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
            btnSalvar = new WiLBiT.WiLBiTButton2();
            panel1 = new Panel();
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
            btnVoltar.TabIndex = 21;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.BackColor = Color.FromArgb(72, 116, 245);
            btnNovoCadastro.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnNovoCadastro.BorderColor = Color.FromArgb(0, 242, 254);
            btnNovoCadastro.BorderRadius = 12;
            btnNovoCadastro.BorderSize = 2;
            btnNovoCadastro.FlatAppearance.BorderSize = 0;
            btnNovoCadastro.FlatStyle = FlatStyle.Flat;
            btnNovoCadastro.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoCadastro.ForeColor = Color.Black;
            btnNovoCadastro.Location = new Point(12, 406);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(150, 32);
            btnNovoCadastro.TabIndex = 22;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.TextColor = Color.Black;
            btnNovoCadastro.UseVisualStyleBackColor = false;
            btnNovoCadastro.Click += btnNovoCadastro_Click;
            // 
            // lblNome
            // 
            lblNome.BorderStyle = BorderStyle.FixedSingle;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(63, 136, 254);
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
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
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
            lblQuantidade.ForeColor = Color.FromArgb(63, 136, 254);
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
            lblFornecedor.ForeColor = Color.FromArgb(63, 136, 254);
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
            lblVencimento.ForeColor = Color.FromArgb(63, 136, 254);
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
            lblEditar.ForeColor = Color.FromArgb(63, 136, 254);
            lblEditar.Location = new Point(684, 86);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(100, 30);
            lblEditar.TabIndex = 32;
            lblEditar.Text = "Editar";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
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
            btnSalvar.Location = new Point(168, 406);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 32);
            btnSalvar.TabIndex = 33;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Location = new Point(11, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 10);
            panel1.TabIndex = 34;
            // 
            // ListaDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnSalvar);
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
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private Panel panel1;
    }
}