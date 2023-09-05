namespace ProjetoIntegradorPIXELogic
{
    partial class Form13
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
            btnPix = new Button();
            btnDebito = new Button();
            btnCredito = new Button();
            btnBoleto = new Button();
            btnVoltar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPix
            // 
            btnPix.Location = new Point(269, 172);
            btnPix.Name = "btnPix";
            btnPix.Size = new Size(75, 23);
            btnPix.TabIndex = 0;
            btnPix.Text = "Pix";
            btnPix.UseVisualStyleBackColor = true;
            // 
            // btnDebito
            // 
            btnDebito.Location = new Point(269, 211);
            btnDebito.Name = "btnDebito";
            btnDebito.Size = new Size(75, 23);
            btnDebito.TabIndex = 1;
            btnDebito.Text = "Débito";
            btnDebito.UseVisualStyleBackColor = true;
            // 
            // btnCredito
            // 
            btnCredito.Location = new Point(269, 254);
            btnCredito.Name = "btnCredito";
            btnCredito.Size = new Size(75, 23);
            btnCredito.TabIndex = 2;
            btnCredito.Text = "Crédito";
            btnCredito.UseVisualStyleBackColor = true;
            // 
            // btnBoleto
            // 
            btnBoleto.Location = new Point(269, 298);
            btnBoleto.Name = "btnBoleto";
            btnBoleto.Size = new Size(75, 23);
            btnBoleto.TabIndex = 3;
            btnBoleto.Text = "Boleto";
            btnBoleto.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(587, 35);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 57);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Pagamento";
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Controls.Add(btnBoleto);
            Controls.Add(btnCredito);
            Controls.Add(btnDebito);
            Controls.Add(btnPix);
            Name = "Form13";
            Text = "Form13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPix;
        private Button btnDebito;
        private Button btnCredito;
        private Button btnBoleto;
        private Button btnVoltar;
        private Label label1;
    }
}