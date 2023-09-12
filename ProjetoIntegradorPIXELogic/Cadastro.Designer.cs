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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCPF = new TextBox();
            txtTelefone = new TextBox();
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtVencimento = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 76);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Fornecedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 140);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 195);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(305, 213);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(305, 158);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 5;
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new Point(305, 94);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(100, 23);
            txtFornecedor.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(305, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(713, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtVencimento
            // 
            txtVencimento.Location = new Point(305, 272);
            txtVencimento.Name = "txtVencimento";
            txtVencimento.Size = new Size(100, 23);
            txtVencimento.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 254);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "Vencimento";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtVencimento);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(txtEndereco);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCPF;
        private TextBox txtTelefone;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private Button button1;
        private Button button2;
        private TextBox txtVencimento;
        private Label label5;
    }
}