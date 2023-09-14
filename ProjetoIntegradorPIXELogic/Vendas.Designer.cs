namespace ProjetoIntegradorPIXELogic
{
    partial class Vendas
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
            pictureBox1 = new PictureBox();
            cmbServico = new ComboBox();
            comboBox1 = new ComboBox();
            txtNomeDoCliente = new TextBox();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ESCRITA_SEM_Fundo10;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cmbServico
            // 
            cmbServico.BackColor = Color.FromArgb(53, 81, 142);
            cmbServico.FlatStyle = FlatStyle.Popup;
            cmbServico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbServico.ForeColor = Color.Cyan;
            cmbServico.FormattingEnabled = true;
            cmbServico.Location = new Point(21, 172);
            cmbServico.Name = "cmbServico";
            cmbServico.Size = new Size(228, 29);
            cmbServico.TabIndex = 59;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(53, 81, 142);
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Cyan;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(64, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(296, 29);
            comboBox1.TabIndex = 60;
            // 
            // txtNomeDoCliente
            // 
            txtNomeDoCliente.BackColor = Color.FromArgb(53, 81, 142);
            txtNomeDoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeDoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDoCliente.ForeColor = Color.Cyan;
            txtNomeDoCliente.Location = new Point(268, 172);
            txtNomeDoCliente.Name = "txtNomeDoCliente";
            txtNomeDoCliente.Size = new Size(259, 29);
            txtNomeDoCliente.TabIndex = 61;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(53, 81, 142);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Cyan;
            textBox1.Location = new Point(552, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 29);
            textBox1.TabIndex = 62;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(467, 281);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(264, 23);
            maskedTextBox1.TabIndex = 63;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(txtNomeDoCliente);
            Controls.Add(comboBox1);
            Controls.Add(cmbServico);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vendas";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cmbServico;
        private ComboBox comboBox1;
        private TextBox txtNomeDoCliente;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
    }
}