﻿namespace ProjetoIntegradorPIXELogic
{
    partial class PalcoEmissaoRelatorioFinanceiroServicos
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
            lblOrcamentoDeServicos = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(668, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(29, 28);
            btnExcluir.TabIndex = 86;
            btnExcluir.Text = "X";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 87;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(200, 12);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 88;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(393, 12);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 89;
            label3.Text = "label3";
            // 
            // PalcoEmissaoRelatorioFinanceiroServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(779, 36);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(lblOrcamentoDeServicos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PalcoEmissaoRelatorioFinanceiroServicos";
            Text = "PalcoEmissaoRelatorioFinanceiroServicos";
            Load += PalcoEmissaoRelatorioFinanceiroServicos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTButton btnExcluir;
        private Label lblOrcamentoDeServicos;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}