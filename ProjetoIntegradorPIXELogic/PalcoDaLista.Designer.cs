namespace ProjetoIntegradorPIXELogic
{
    partial class PalcoDaLista
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
            lblOrcamentoDeServicos = new Label();
            this.btnEditar = new WiLBiT.WiLBiTButton();
            this.btnExcluir = new WiLBiT.WiLBiTButton();
            SuspendLayout();
            // 
            // lblOrcamentoDeServicos
            // 
            lblOrcamentoDeServicos.AutoSize = true;
            lblOrcamentoDeServicos.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrcamentoDeServicos.ForeColor = Color.Cyan;
            lblOrcamentoDeServicos.Location = new Point(-15, -31);
            lblOrcamentoDeServicos.Name = "lblOrcamentoDeServicos";
            lblOrcamentoDeServicos.Size = new Size(1007, 37);
            lblOrcamentoDeServicos.TabIndex = 76;
            lblOrcamentoDeServicos.Text = "__________________________________________________________________________________________";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = Color.FromArgb(72, 116, 245);
            this.btnEditar.BorderColor = Color.FromArgb(72, 116, 245);
            this.btnEditar.BorderRadius = 6;
            this.btnEditar.BorderSize = 0;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = FlatStyle.Flat;
            this.btnEditar.ForeColor = Color.White;
            this.btnEditar.Location = new Point(738, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new Size(29, 28);
            this.btnEditar.TabIndex = 79;
            this.btnEditar.Text = "ED";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = Color.Red;
            this.btnExcluir.BorderColor = Color.FromArgb(72, 116, 245);
            this.btnExcluir.BorderRadius = 6;
            this.btnExcluir.BorderSize = 0;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = FlatStyle.Flat;
            this.btnExcluir.ForeColor = Color.White;
            this.btnExcluir.Location = new Point(769, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new Size(29, 28);
            this.btnExcluir.TabIndex = 80;
            this.btnExcluir.Text = "EX";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // PalcoDaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 36);
            Controls.Add(this.btnExcluir);
            Controls.Add(this.btnEditar);
            Controls.Add(lblOrcamentoDeServicos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PalcoDaLista";
            Text = "PalcoDaLista";
            Load += this.PalcoDaLista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrcamentoDeServicos;
        private WiLBiT.WiLBiTButton btnEditar;
        private WiLBiT.WiLBiTButton btnExcluir;
    }
}