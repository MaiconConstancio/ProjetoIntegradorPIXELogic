namespace ProjetoIntegradorPIXELogic
{
    partial class Form5
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
            btnHierarquia = new Button();
            btnAbasPerm = new Button();
            label2 = new Label();
            listFerramentas = new ListView();
            SuspendLayout();
            // 
            // btnHierarquia
            // 
            btnHierarquia.BackColor = Color.FromArgb(0, 242, 254);
            btnHierarquia.FlatStyle = FlatStyle.Flat;
            btnHierarquia.Location = new Point(638, 415);
            btnHierarquia.Name = "btnHierarquia";
            btnHierarquia.Size = new Size(150, 23);
            btnHierarquia.TabIndex = 20;
            btnHierarquia.Text = "Editar hierarquia";
            btnHierarquia.UseVisualStyleBackColor = false;
            // 
            // btnAbasPerm
            // 
            btnAbasPerm.BackColor = Color.FromArgb(0, 242, 254);
            btnAbasPerm.FlatStyle = FlatStyle.Flat;
            btnAbasPerm.Location = new Point(638, 12);
            btnAbasPerm.Name = "btnAbasPerm";
            btnAbasPerm.Size = new Size(150, 23);
            btnAbasPerm.TabIndex = 21;
            btnAbasPerm.Text = "Editar abas e permissões";
            btnAbasPerm.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(63, 136, 254);
            label2.Location = new Point(297, 187);
            label2.Name = "label2";
            label2.Size = new Size(242, 15);
            label2.TabIndex = 22;
            label2.Text = "Escolha a ferramenta que deseja trabalhar!";
            // 
            // listFerramentas
            // 
            listFerramentas.Location = new Point(0, 0);
            listFerramentas.Name = "listFerramentas";
            listFerramentas.Size = new Size(189, 450);
            listFerramentas.TabIndex = 23;
            listFerramentas.UseCompatibleStateImageBehavior = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 10, 22);
            ClientSize = new Size(800, 450);
            Controls.Add(listFerramentas);
            Controls.Add(label2);
            Controls.Add(btnAbasPerm);
            Controls.Add(btnHierarquia);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHierarquia;
        private Button btnAbasPerm;
        private Label label2;
        private ListView listFerramentas;
    }
}