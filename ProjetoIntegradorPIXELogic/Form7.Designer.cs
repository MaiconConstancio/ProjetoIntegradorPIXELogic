namespace ProjetoIntegradorPIXELogic
{
    partial class Form7
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
            txtCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEndereco = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtCPF = new TextBox();
            label5 = new Label();
            txtCEP = new TextBox();
            label6 = new Label();
            txtRG = new TextBox();
            label7 = new Label();
            txtCidade = new TextBox();
            btnCadastrar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(316, 48);
            txtCliente.Margin = new Padding(3, 3, 3, 10);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 51);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 87);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(316, 84);
            txtEndereco.Margin = new Padding(3, 3, 3, 10);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(100, 23);
            txtEndereco.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 120);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(316, 120);
            txtTelefone.Margin = new Padding(3, 3, 3, 10);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 159);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "CPF:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(316, 156);
            txtCPF.Margin = new Padding(3, 3, 3, 10);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 195);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "CEP:";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(316, 192);
            txtCEP.Margin = new Padding(3, 3, 3, 10);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 231);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 11;
            label6.Text = "RG:";
            // 
            // txtRG
            // 
            txtRG.Location = new Point(316, 228);
            txtRG.Margin = new Padding(3, 3, 3, 10);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(100, 23);
            txtRG.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(263, 267);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 13;
            label7.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(316, 264);
            txtCidade.Margin = new Padding(3, 3, 3, 10);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(713, 415);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(713, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrar);
            Controls.Add(label7);
            Controls.Add(txtCidade);
            Controls.Add(label6);
            Controls.Add(txtRG);
            Controls.Add(label5);
            Controls.Add(txtCEP);
            Controls.Add(label4);
            Controls.Add(txtCPF);
            Controls.Add(label3);
            Controls.Add(txtTelefone);
            Controls.Add(label2);
            Controls.Add(txtEndereco);
            Controls.Add(label1);
            Controls.Add(txtCliente);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private Label label1;
        private Label label2;
        private TextBox txtEndereco;
        private Label label3;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtCPF;
        private Label label5;
        private TextBox txtCEP;
        private Label label6;
        private TextBox txtRG;
        private Label label7;
        private TextBox txtCidade;
        private Button btnCadastrar;
        private Button btnVoltar;
    }
}