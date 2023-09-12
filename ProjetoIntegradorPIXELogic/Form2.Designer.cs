namespace ProjetoIntegradorPIXELogic
{
    partial class Form2
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
            btnSalvar = new Button();
            btnVoltar = new Button();
            label1 = new Label();
            Valor = new Label();
            txtValor = new TextBox();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(318, 365);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(713, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 117);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do serviço";
            // 
            // Valor
            // 
            Valor.AutoSize = true;
            Valor.Location = new Point(331, 232);
            Valor.Name = "Valor";
            Valor.Size = new Size(33, 15);
            Valor.TabIndex = 3;
            Valor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(304, 284);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(304, 157);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNome);
            Controls.Add(txtValor);
            Controls.Add(Valor);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnVoltar;
        private Label label1;
        private Label Valor;
        private TextBox txtValor;
        private TextBox txtNome;
    }
}