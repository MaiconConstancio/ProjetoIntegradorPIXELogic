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
            SuspendLayout();
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
            btnVoltar.TabIndex = 21;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.BackColor = Color.FromArgb(72, 116, 245);
            btnNovoCadastro.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnNovoCadastro.BorderColor = Color.FromArgb(0, 242, 254);
            btnNovoCadastro.BorderRadius = 19;
            btnNovoCadastro.BorderSize = 2;
            btnNovoCadastro.FlatAppearance.BorderSize = 0;
            btnNovoCadastro.FlatStyle = FlatStyle.Flat;
            btnNovoCadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoCadastro.ForeColor = Color.Black;
            btnNovoCadastro.Location = new Point(12, 396);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(196, 42);
            btnNovoCadastro.TabIndex = 22;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.TextColor = Color.Black;
            btnNovoCadastro.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(63, 136, 254);
            lblNome.Location = new Point(12, 95);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(66, 25);
            lblNome.TabIndex = 27;
            lblNome.Text = "Nome";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(400, 95);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(59, 25);
            lblValor.TabIndex = 28;
            lblValor.Text = "Valor";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidade.ForeColor = Color.FromArgb(63, 136, 254);
            lblQuantidade.Location = new Point(248, 95);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(116, 25);
            lblQuantidade.TabIndex = 29;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFornecedor.ForeColor = Color.FromArgb(63, 136, 254);
            lblFornecedor.Location = new Point(107, 95);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(115, 25);
            lblFornecedor.TabIndex = 30;
            lblFornecedor.Text = "Fornecedor";
            // 
            // lblVencimento
            // 
            lblVencimento.AutoSize = true;
            lblVencimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVencimento.ForeColor = Color.FromArgb(63, 136, 254);
            lblVencimento.Location = new Point(505, 95);
            lblVencimento.Name = "lblVencimento";
            lblVencimento.Size = new Size(118, 25);
            lblVencimento.TabIndex = 31;
            lblVencimento.Text = "Vencimento";
            // 
            // lblEditar
            // 
            lblEditar.AutoSize = true;
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditar.ForeColor = Color.FromArgb(63, 136, 254);
            lblEditar.Location = new Point(688, 95);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(64, 25);
            lblEditar.TabIndex = 32;
            lblEditar.Text = "Editar";
            // 
            // ListaDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
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
    }
}