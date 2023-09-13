namespace ProjetoIntegradorPIXELogic
{
    partial class COPIAeCOLA
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
            textBox1 = new TextBox();
            lblLogin = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(53, 81, 142);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Cyan;
            textBox1.Location = new Point(44, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 29);
            textBox1.TabIndex = 9;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(63, 136, 254);
            lblLogin.Location = new Point(346, 33);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(120, 37);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "TextBox";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(63, 136, 254);
            label1.Location = new Point(346, 87);
            label1.Name = "label1";
            label1.Size = new Size(154, 37);
            label1.TabIndex = 11;
            label1.Text = "comboBox";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(53, 81, 142);
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Cyan;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(44, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(296, 29);
            comboBox1.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.FromArgb(53, 81, 142);
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(44, 147);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 29);
            maskedTextBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(63, 136, 254);
            label2.Location = new Point(150, 139);
            label2.Name = "label2";
            label2.Size = new Size(220, 37);
            label2.TabIndex = 14;
            label2.Text = "MaskedTextBox";
            // 
            // COPIAeCOLA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(lblLogin);
            Controls.Add(textBox1);
            Name = "COPIAeCOLA";
            Text = "COPIAeCOLA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblLogin;
        private Label label1;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
    }
}