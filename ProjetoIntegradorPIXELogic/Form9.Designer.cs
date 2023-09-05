namespace ProjetoIntegradorPIXELogic
{
    partial class Form9
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
            btnProduto = new Button();
            btnServiço = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(593, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            btnProduto.Location = new Point(305, 218);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(75, 23);
            btnProduto.TabIndex = 2;
            btnProduto.Text = "Produto";
            btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnServiço
            // 
            btnServiço.Location = new Point(305, 247);
            btnServiço.Name = "btnServiço";
            btnServiço.Size = new Size(75, 23);
            btnServiço.TabIndex = 3;
            btnServiço.Text = "Serviço";
            btnServiço.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnServiço);
            Controls.Add(btnProduto);
            Controls.Add(btnVoltar);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnVoltar;
        private Button btnProduto;
        private Button btnServiço;
    }
}