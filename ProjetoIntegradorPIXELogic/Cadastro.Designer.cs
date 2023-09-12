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
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtfuncionario = new TextBox();
            label5 = new Label();
            txtEstimativa = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            conexaoBindingSource = new BindingSource(components);
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 30);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 76);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Serviço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 140);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor";
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
            // txtEndereco
            // 
            txtEndereco.Location = new Point(295, 213);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(121, 23);
            txtEndereco.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(295, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(121, 23);
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
            // txtfuncionario
            // 
            txtfuncionario.Location = new Point(295, 272);
            txtfuncionario.Name = "txtfuncionario";
            txtfuncionario.Size = new Size(121, 23);
            txtfuncionario.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 254);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "Funcionario";
            // 
            // txtEstimativa
            // 
            txtEstimativa.Location = new Point(295, 337);
            txtEstimativa.Name = "txtEstimativa";
            txtEstimativa.Size = new Size(121, 23);
            txtEstimativa.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 319);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 12;
            label6.Text = "Estimativa de entrega";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(295, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(295, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 15;
            // 
            // conexaoBindingSource
            // 
            conexaoBindingSource.DataSource = typeof(Conexao);
            // 
            // button3
            // 
            button3.Location = new Point(22, 417);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 16;
            button3.Text = "Novo serviço";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(txtEstimativa);
            Controls.Add(label6);
            Controls.Add(txtfuncionario);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(txtEndereco);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private Button button1;
        private Button button2;
        private TextBox txtfuncionario;
        private Label label5;
        private TextBox txtEstimativa;
        private Label label6;
        private ComboBox comboBox1;
        private BindingSource conexaoBindingSource;
        private ComboBox comboBox2;
        private Button button3;
    }
}