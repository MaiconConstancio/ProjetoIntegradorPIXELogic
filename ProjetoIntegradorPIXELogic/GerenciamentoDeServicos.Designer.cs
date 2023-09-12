namespace ProjetoIntegradorPIXELogic
{
    partial class GerenciamentoDeServicos
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
            wilBitButton21 = new WiLBiT.WiLBiTButton2();
            wilBitButton23 = new WiLBiT.WiLBiTButton2();
            SuspendLayout();
            // 
            // wilBitButton21
            // 
            wilBitButton21.BackColor = Color.FromArgb(72, 116, 245);
            wilBitButton21.BackgroundColor = Color.FromArgb(72, 116, 245);
            wilBitButton21.BorderColor = Color.FromArgb(0, 242, 254);
            wilBitButton21.BorderRadius = 22;
            wilBitButton21.BorderSize = 2;
            wilBitButton21.FlatAppearance.BorderSize = 0;
            wilBitButton21.FlatStyle = FlatStyle.Flat;
            wilBitButton21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            wilBitButton21.ForeColor = Color.Black;
            wilBitButton21.Location = new Point(671, 12);
            wilBitButton21.Name = "wilBitButton21";
            wilBitButton21.Size = new Size(117, 39);
            wilBitButton21.TabIndex = 20;
            wilBitButton21.Text = "VOLTAR";
            wilBitButton21.TextColor = Color.Black;
            wilBitButton21.UseVisualStyleBackColor = false;
            // 
            // wilBitButton23
            // 
            wilBitButton23.BackColor = Color.FromArgb(72, 116, 245);
            wilBitButton23.BackgroundColor = Color.FromArgb(72, 116, 245);
            wilBitButton23.BorderColor = Color.FromArgb(0, 242, 254);
            wilBitButton23.BorderRadius = 22;
            wilBitButton23.BorderSize = 2;
            wilBitButton23.FlatAppearance.BorderSize = 0;
            wilBitButton23.FlatStyle = FlatStyle.Flat;
            wilBitButton23.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            wilBitButton23.ForeColor = Color.Black;
            wilBitButton23.Location = new Point(12, 396);
            wilBitButton23.Name = "wilBitButton23";
            wilBitButton23.Size = new Size(196, 42);
            wilBitButton23.TabIndex = 21;
            wilBitButton23.Text = "Novo Orçamento";
            wilBitButton23.TextColor = Color.Black;
            wilBitButton23.UseVisualStyleBackColor = false;
            // 
            // GerenciamentoDeServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(wilBitButton23);
            Controls.Add(wilBitButton21);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GerenciamentoDeServicos";
            Text = "GerenciamentoDeServicos";
            ResumeLayout(false);
        }

        #endregion

        private WiLBiT.WiLBiTButton2 wilBitButton21;
        private WiLBiT.WiLBiTButton2 wilBitButton23;
    }
}