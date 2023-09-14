namespace ProjetoIntegradorPIXELogic
{
    partial class PalcoListaDeProdutos
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
            btnExcluir = new WiLBiT.WiLBiTButton();
            btnEditar = new WiLBiT.WiLBiTButton();
            lblOrcamentoDeServicos = new Label();
            SuspendLayout();
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
            btnExcluir.Location = new Point(768, 7);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(29, 28);
            btnExcluir.TabIndex = 86;
            btnExcluir.Text = "EX";
            btnExcluir.UseVisualStyleBackColor = false;
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
            btnEditar.Location = new Point(737, 7);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(29, 28);
            btnEditar.TabIndex = 85;
            btnEditar.Text = "ED";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // lblOrcamentoDeServicos
            // 
            lblOrcamentoDeServicos.AutoSize = true;
            lblOrcamentoDeServicos.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrcamentoDeServicos.ForeColor = Color.Cyan;
            lblOrcamentoDeServicos.Location = new Point(-103, -31);
            lblOrcamentoDeServicos.Name = "lblOrcamentoDeServicos";
            lblOrcamentoDeServicos.Size = new Size(1007, 37);
            lblOrcamentoDeServicos.TabIndex = 84;
            lblOrcamentoDeServicos.Text = "__________________________________________________________________________________________";
            // 
            // PalcoListaDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 36);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(lblOrcamentoDeServicos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PalcoListaDeProdutos";
            Text = "PalcoListaDeProdutos";
            Load += PalcoListaDeProdutos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTButton btnExcluir;
        private WiLBiT.WiLBiTButton btnEditar;
        private Label lblOrcamentoDeServicos;
    }
}