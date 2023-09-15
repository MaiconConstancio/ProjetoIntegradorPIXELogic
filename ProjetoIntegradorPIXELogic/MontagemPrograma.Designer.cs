namespace ProjetoIntegradorPIXELogic
{
    partial class MontagemPrograma
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
            chkBoxColaboradores = new CheckBox();
            chkBoxFornecedores = new CheckBox();
            chkBoxProdutos = new CheckBox();
            chkBoxClientes = new CheckBox();
            chkBoxGerenciamentoServiços = new CheckBox();
            chkBoxVendas = new CheckBox();
            chkBoxEmissaoRelatoriosFinanceiros = new CheckBox();
            chkBoxSuporteAoCliente = new CheckBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // chkBoxColaboradores
            // 
            chkBoxColaboradores.AutoSize = true;
            chkBoxColaboradores.ForeColor = SystemColors.ButtonFace;
            chkBoxColaboradores.Location = new Point(27, 257);
            chkBoxColaboradores.Name = "chkBoxColaboradores";
            chkBoxColaboradores.Size = new Size(103, 19);
            chkBoxColaboradores.TabIndex = 0;
            chkBoxColaboradores.Text = "Colaboradores";
            chkBoxColaboradores.UseVisualStyleBackColor = true;
            // 
            // chkBoxFornecedores
            // 
            chkBoxFornecedores.AutoSize = true;
            chkBoxFornecedores.ForeColor = SystemColors.ButtonFace;
            chkBoxFornecedores.Location = new Point(27, 219);
            chkBoxFornecedores.Name = "chkBoxFornecedores";
            chkBoxFornecedores.Size = new Size(97, 19);
            chkBoxFornecedores.TabIndex = 1;
            chkBoxFornecedores.Text = "Fornecedores";
            chkBoxFornecedores.UseVisualStyleBackColor = true;
            // 
            // chkBoxProdutos
            // 
            chkBoxProdutos.AutoSize = true;
            chkBoxProdutos.ForeColor = SystemColors.ButtonFace;
            chkBoxProdutos.Location = new Point(27, 180);
            chkBoxProdutos.Name = "chkBoxProdutos";
            chkBoxProdutos.Size = new Size(74, 19);
            chkBoxProdutos.TabIndex = 2;
            chkBoxProdutos.Text = "Produtos";
            chkBoxProdutos.UseVisualStyleBackColor = true;
            // 
            // chkBoxClientes
            // 
            chkBoxClientes.AutoSize = true;
            chkBoxClientes.ForeColor = SystemColors.ButtonFace;
            chkBoxClientes.Location = new Point(27, 142);
            chkBoxClientes.Name = "chkBoxClientes";
            chkBoxClientes.Size = new Size(68, 19);
            chkBoxClientes.TabIndex = 3;
            chkBoxClientes.Text = "Clientes";
            chkBoxClientes.UseVisualStyleBackColor = true;
            // 
            // chkBoxGerenciamentoServiços
            // 
            chkBoxGerenciamentoServiços.AutoSize = true;
            chkBoxGerenciamentoServiços.ForeColor = SystemColors.ButtonFace;
            chkBoxGerenciamentoServiços.Location = new Point(27, 107);
            chkBoxGerenciamentoServiços.Name = "chkBoxGerenciamentoServiços";
            chkBoxGerenciamentoServiços.Size = new Size(168, 19);
            chkBoxGerenciamentoServiços.TabIndex = 4;
            chkBoxGerenciamentoServiços.Text = "Gerenciamento de serviços";
            chkBoxGerenciamentoServiços.UseVisualStyleBackColor = true;
            // 
            // chkBoxVendas
            // 
            chkBoxVendas.AutoSize = true;
            chkBoxVendas.ForeColor = SystemColors.ButtonFace;
            chkBoxVendas.Location = new Point(27, 331);
            chkBoxVendas.Name = "chkBoxVendas";
            chkBoxVendas.Size = new Size(63, 19);
            chkBoxVendas.TabIndex = 5;
            chkBoxVendas.Text = "Vendas";
            chkBoxVendas.UseVisualStyleBackColor = true;
            // 
            // chkBoxEmissaoRelatoriosFinanceiros
            // 
            chkBoxEmissaoRelatoriosFinanceiros.AutoSize = true;
            chkBoxEmissaoRelatoriosFinanceiros.ForeColor = SystemColors.ButtonFace;
            chkBoxEmissaoRelatoriosFinanceiros.Location = new Point(27, 294);
            chkBoxEmissaoRelatoriosFinanceiros.Name = "chkBoxEmissaoRelatoriosFinanceiros";
            chkBoxEmissaoRelatoriosFinanceiros.Size = new Size(271, 19);
            chkBoxEmissaoRelatoriosFinanceiros.TabIndex = 6;
            chkBoxEmissaoRelatoriosFinanceiros.Text = "Emissão De Relatorios Financeiros de Produtos";
            chkBoxEmissaoRelatoriosFinanceiros.UseVisualStyleBackColor = true;
            // 
            // chkBoxSuporteAoCliente
            // 
            chkBoxSuporteAoCliente.AutoSize = true;
            chkBoxSuporteAoCliente.ForeColor = SystemColors.ButtonFace;
            chkBoxSuporteAoCliente.Location = new Point(27, 370);
            chkBoxSuporteAoCliente.Name = "chkBoxSuporteAoCliente";
            chkBoxSuporteAoCliente.Size = new Size(123, 19);
            chkBoxSuporteAoCliente.TabIndex = 8;
            chkBoxSuporteAoCliente.Text = "Suporte ao Cliente";
            chkBoxSuporteAoCliente.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(713, 415);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar\r\n";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // MontagemPrograma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(chkBoxSuporteAoCliente);
            Controls.Add(chkBoxEmissaoRelatoriosFinanceiros);
            Controls.Add(chkBoxVendas);
            Controls.Add(chkBoxGerenciamentoServiços);
            Controls.Add(chkBoxClientes);
            Controls.Add(chkBoxProdutos);
            Controls.Add(chkBoxFornecedores);
            Controls.Add(chkBoxColaboradores);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MontagemPrograma";
            Text = "MontagemPrograma";
            Load += MontagemPrograma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkBoxColaboradores;
        private CheckBox chkBoxFornecedores;
        private CheckBox chkBoxProdutos;
        private CheckBox chkBoxClientes;
        private CheckBox chkBoxGerenciamentoServiços;
        private CheckBox chkBoxVendas;
        private CheckBox chkBoxEmissaoRelatoriosFinanceiros;
        private CheckBox chkBoxSuporteAoCliente;
        private Button btnSalvar;
    }
}