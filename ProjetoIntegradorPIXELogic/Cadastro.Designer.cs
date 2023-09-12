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
            txtCNPJ = new TextBox();
            txtTelefone = new TextBox();
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtCEP = new TextBox();
            label5 = new Label();
            txtNumero = new TextBox();
            label6 = new Label();
            txtCidade = new TextBox();
            label7 = new Label();
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
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 140);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 195);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "CNPJ";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(305, 213);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(100, 23);
            txtCNPJ.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(305, 158);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 5;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(305, 94);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(100, 23);
            txtEndereco.TabIndex = 6;
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
            // txtCEP
            // 
            txtCEP.Location = new Point(305, 272);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 254);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 10;
            label5.Text = "CEP";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(305, 337);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 319);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 12;
            label6.Text = "Numero";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(305, 399);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(343, 381);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 14;
            label7.Text = "Cidade";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCidade);
            Controls.Add(label7);
            Controls.Add(txtNumero);
            Controls.Add(label6);
            Controls.Add(txtCEP);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(txtEndereco);
            Controls.Add(txtTelefone);
            Controls.Add(txtCNPJ);
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
        private TextBox txtCNPJ;
        private TextBox txtTelefone;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private Button button1;
        private Button button2;
        private TextBox txtCEP;
        private Label label5;
        private TextBox txtNumero;
        private Label label6;
        private TextBox txtCidade;
        private Label label7;
    }
}