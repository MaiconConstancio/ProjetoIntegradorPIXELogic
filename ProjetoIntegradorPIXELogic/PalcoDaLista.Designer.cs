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
            btnEditar = new WiLBiT.WiLBiTButton();
            btnExcluir = new WiLBiT.WiLBiTButton();
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
            btnEditar.BackColor = Color.FromArgb(72, 116, 245);
            btnEditar.BorderColor = Color.FromArgb(72, 116, 245);
            btnEditar.BorderRadius = 6;
            btnEditar.BorderSize = 0;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(738, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(29, 28);
            btnEditar.TabIndex = 79;
            btnEditar.Text = "ED";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.BorderColor = Color.FromArgb(72, 116, 245);
            btnExcluir.BorderRadius = 6;
            btnExcluir.BorderSize = 0;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(769, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(29, 28);
            btnExcluir.TabIndex = 80;
            btnExcluir.Text = "EX";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // PalcoDaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 36);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(lblOrcamentoDeServicos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PalcoDaLista";
            Text = "PalcoDaLista";
            Load += PalcoDaLista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrcamentoDeServicos;
        private WiLBiT.WiLBiTButton btnEditar;
        private WiLBiT.WiLBiTButton btnExcluir;
    }
}