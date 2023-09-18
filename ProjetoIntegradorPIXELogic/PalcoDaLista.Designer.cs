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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblOrcamentoDeServicos
            // 
            lblOrcamentoDeServicos.AutoSize = true;
            lblOrcamentoDeServicos.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrcamentoDeServicos.ForeColor = Color.Cyan;
            lblOrcamentoDeServicos.Location = new Point(-103, -31);
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
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 13);
            label1.Margin = new Padding(30, 0, 60, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 81;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(140, 13);
            label2.Margin = new Padding(3, 0, 60, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 82;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(241, 13);
            label3.Margin = new Padding(3, 0, 60, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 83;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(342, 13);
            label4.Margin = new Padding(3, 0, 60, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 84;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(443, 13);
            label5.Margin = new Padding(3, 0, 60, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 85;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(547, 13);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 86;
            label6.Text = "label6";
            // 
            // PalcoDaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(779, 36);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}