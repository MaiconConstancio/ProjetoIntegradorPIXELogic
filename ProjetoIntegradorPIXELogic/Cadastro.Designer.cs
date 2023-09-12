namespace ProjetoIntegradorPIXELogic
{
    partial class Cadastro
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();

            txtQuantidade = new TextBox();
            btnSalvar = new Button();
            btnVoltar = new Button();
            txtNomeCliente = new TextBox();
            label5 = new Label();
            comboMPagamento = new ComboBox();
            comboProduto = new ComboBox();
            btnVTItens = new Button();
            comboValor = new ComboBox();
            label6 = new Label();

            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;

            label1.Location = new Point(94, 158);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 158);
            label2.Name = "label2";

            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantidade";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(604, 158);
            label3.Name = "label3";

            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome do cliente";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 195);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Endereço";
            // 

            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(304, 187);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(181, 23);
            txtQuantidade.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(264, 386);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 34);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(713, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += button2_Click;

            // 
            // txtNomeCliente
            // 

            txtNomeCliente.Location = new Point(562, 187);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(181, 23);
            txtNomeCliente.TabIndex = 11;

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(482, 261);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 10;
            label5.Text = "Método de pagamento";
            // 
            // comboMPagamento
            // 
            comboMPagamento.FormattingEnabled = true;
            comboMPagamento.Location = new Point(448, 292);
            comboMPagamento.Name = "comboMPagamento";
            comboMPagamento.Size = new Size(181, 23);
            comboMPagamento.TabIndex = 12;
            // 

            // comboProduto
            // 
            comboProduto.FormattingEnabled = true;
            comboProduto.Location = new Point(35, 187);
            comboProduto.Name = "comboProduto";
            comboProduto.Size = new Size(181, 23);
            comboProduto.TabIndex = 13;

            // 
            // btnVTItens
            // 

            btnVTItens.Location = new Point(439, 386);
            btnVTItens.Name = "btnVTItens";
            btnVTItens.Size = new Size(128, 34);
            btnVTItens.TabIndex = 14;
            btnVTItens.Text = "Ver todos os itens";
            btnVTItens.UseVisualStyleBackColor = true;
            btnVTItens.Click += btnVTItens_Click;
            // 
            // comboValor
            // 
            comboValor.FormattingEnabled = true;
            comboValor.Location = new Point(175, 292);
            comboValor.Name = "comboValor";
            comboValor.Size = new Size(181, 23);
            comboValor.TabIndex = 16;

            // 
            // label6
            // 
            label6.AutoSize = true;

            label6.Location = new Point(238, 261);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 15;
            label6.Text = "Valor";

            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(comboValor);
            Controls.Add(label6);
            Controls.Add(btnVTItens);
            Controls.Add(comboProduto);
            Controls.Add(comboMPagamento);
            Controls.Add(txtNomeCliente);
            Controls.Add(label5);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(txtQuantidade);

            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;


            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        private TextBox txtQuantidade;
        private Button btnSalvar;
        private Button btnVoltar;
        private TextBox txtNomeCliente;
        private Label label5;
        private ComboBox comboMPagamento;
        private ComboBox comboProduto;
        private Button btnVTItens;
        private ComboBox comboValor;
        private Label label6;

    }
}