namespace ProjetoIntegradorPIXELogic
{
    partial class Form3
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
            btnAvançar = new Button();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSenha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnPular = new Button();
            comboBoxCargo = new ComboBox();
            SuspendLayout();
            // 
            // btnAvançar
            // 
            btnAvançar.BackColor = Color.FromArgb(0, 242, 254);
            btnAvançar.FlatStyle = FlatStyle.Flat;
            btnAvançar.Location = new Point(283, 329);
            btnAvançar.Name = "btnAvançar";
            btnAvançar.Size = new Size(181, 23);
            btnAvançar.TabIndex = 14;
            btnAvançar.Text = "AVANÇAR";
            btnAvançar.UseVisualStyleBackColor = false;
            btnAvançar.Click += btnAvançar_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(53, 81, 142);
            txtNome.Location = new Point(283, 163);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(181, 23);
            txtNome.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(63, 136, 254);
            label2.Location = new Point(314, 50);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 11;
            label2.Text = "Seja Bem-Vindo!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(63, 136, 254);
            label1.Location = new Point(269, 88);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 10;
            label1.Text = "Escolha sua equipe e suas credenciais";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(53, 81, 142);
            txtSenha.Location = new Point(283, 253);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(181, 23);
            txtSenha.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(283, 145);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 16;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(283, 189);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 17;
            label4.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(283, 235);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 18;
            label5.Text = "Senha";
            // 
            // btnPular
            // 
            btnPular.BackColor = Color.FromArgb(0, 242, 254);
            btnPular.FlatStyle = FlatStyle.Flat;
            btnPular.Location = new Point(12, 415);
            btnPular.Name = "btnPular";
            btnPular.Size = new Size(100, 23);
            btnPular.TabIndex = 19;
            btnPular.Text = "Pular etapa";
            btnPular.UseVisualStyleBackColor = false;
            btnPular.Click += btnPular_Click;
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Items.AddRange(new object[] { "Administrador do sistema", "funcionário" });
            comboBoxCargo.Location = new Point(283, 206);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(180, 23);
            comboBoxCargo.TabIndex = 20;
            comboBoxCargo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 10, 22);
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxCargo);
            Controls.Add(btnPular);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSenha);
            Controls.Add(btnAvançar);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAvançar;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private TextBox txtSenha;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnPular;
        private ComboBox comboBoxCargo;
    }
}