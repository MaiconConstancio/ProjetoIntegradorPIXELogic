namespace ProjetoIntegradorPIXELogic
{
    partial class Form11
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
            btnVoltar = new Button();
            btnEditar = new Button();
            txtCodigoServico = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTempoEntrega = new TextBox();
            label3 = new Label();
            txtNomeProduto = new TextBox();
            label4 = new Label();
            txtValor = new TextBox();
            label5 = new Label();
            comboBoxStatus = new ComboBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(713, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 415);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtCodigoServico
            // 
            txtCodigoServico.Location = new Point(38, 120);
            txtCodigoServico.Name = "txtCodigoServico";
            txtCodigoServico.Size = new Size(102, 23);
            txtCodigoServico.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 102);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 3;
            label1.Text = "Código de serviço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 188);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 5;
            label2.Text = "Tempo para terminar";
            // 
            // txtTempoEntrega
            // 
            txtTempoEntrega.Location = new Point(38, 206);
            txtTempoEntrega.Name = "txtTempoEntrega";
            txtTempoEntrega.Size = new Size(117, 23);
            txtTempoEntrega.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 102);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 7;
            label3.Text = "Nome do produto";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(322, 120);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(103, 23);
            txtNomeProduto.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(558, 102);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 9;
            label4.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(528, 120);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 188);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 10;
            label5.Text = "status de produção";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Em espera", "Concluido" });
            comboBoxStatus.Location = new Point(310, 206);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(713, 415);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(comboBoxStatus);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(txtNomeProduto);
            Controls.Add(label2);
            Controls.Add(txtTempoEntrega);
            Controls.Add(label1);
            Controls.Add(txtCodigoServico);
            Controls.Add(btnEditar);
            Controls.Add(btnVoltar);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnEditar;
        private TextBox txtCodigoServico;
        private Label label1;
        private Label label2;
        private TextBox txtTempoEntrega;
        private Label label3;
        private TextBox txtNomeProduto;
        private Label label4;
        private TextBox txtValor;
        private Label label5;
        private ComboBox comboBoxStatus;
        private Button btnSalvar;
    }
}