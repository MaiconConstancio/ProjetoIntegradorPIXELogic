namespace ProjetoIntegradorPIXELogic
{
    partial class SuporteAoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuporteAoCliente));
            imgWallpaper = new PictureBox();
            btnEntraEmContato = new WiLBiT.WiLBiTButton2();
            lblSuporteAoCliente = new Label();
            lblAtendimento = new Label();
            lblHorario = new Label();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            ((System.ComponentModel.ISupportInitialize)imgWallpaper).BeginInit();
            SuspendLayout();
            // 
            // imgWallpaper
            // 
            imgWallpaper.Dock = DockStyle.Fill;
            imgWallpaper.Image = (Image)resources.GetObject("imgWallpaper.Image");
            imgWallpaper.Location = new Point(0, 0);
            imgWallpaper.Name = "imgWallpaper";
            imgWallpaper.Size = new Size(800, 450);
            imgWallpaper.TabIndex = 0;
            imgWallpaper.TabStop = false;
            // 
            // btnEntraEmContato
            // 
            btnEntraEmContato.BackColor = Color.FromArgb(18, 184, 238);
            btnEntraEmContato.BackgroundColor = Color.FromArgb(18, 184, 238);
            btnEntraEmContato.BorderColor = Color.FromArgb(192, 255, 255);
            btnEntraEmContato.BorderRadius = 14;
            btnEntraEmContato.BorderSize = 2;
            btnEntraEmContato.FlatAppearance.BorderSize = 0;
            btnEntraEmContato.FlatStyle = FlatStyle.Flat;
            btnEntraEmContato.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.World);
            btnEntraEmContato.ForeColor = Color.Black;
            btnEntraEmContato.Location = new Point(440, 372);
            btnEntraEmContato.Name = "btnEntraEmContato";
            btnEntraEmContato.Size = new Size(229, 36);
            btnEntraEmContato.TabIndex = 74;
            btnEntraEmContato.Text = "ENTRAR EM CONTATO";
            btnEntraEmContato.TextColor = Color.Black;
            btnEntraEmContato.UseVisualStyleBackColor = false;
            btnEntraEmContato.Click += btnEntraEmContato_Click;
            // 
            // lblSuporteAoCliente
            // 
            lblSuporteAoCliente.AutoSize = true;
            lblSuporteAoCliente.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuporteAoCliente.ForeColor = Color.Cyan;
            lblSuporteAoCliente.Location = new Point(368, 63);
            lblSuporteAoCliente.Name = "lblSuporteAoCliente";
            lblSuporteAoCliente.Size = new Size(372, 54);
            lblSuporteAoCliente.TabIndex = 75;
            lblSuporteAoCliente.Text = "Suporte ao Cliente";
            // 
            // lblAtendimento
            // 
            lblAtendimento.AutoSize = true;
            lblAtendimento.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtendimento.ForeColor = Color.Cyan;
            lblAtendimento.Location = new Point(449, 122);
            lblAtendimento.Name = "lblAtendimento";
            lblAtendimento.Size = new Size(204, 31);
            lblAtendimento.TabIndex = 76;
            lblAtendimento.Text = "Atendimento das:";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorario.ForeColor = Color.Cyan;
            lblHorario.Location = new Point(428, 159);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(254, 28);
            lblHorario.TabIndex = 77;
            lblHorario.Text = "2:10h às 3:50h da manhã.";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(18, 184, 238);
            btnVoltar.BackgroundColor = Color.FromArgb(18, 184, 238);
            btnVoltar.BorderColor = Color.FromArgb(192, 255, 255);
            btnVoltar.BorderRadius = 14;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.World);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(694, 16);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 36);
            btnVoltar.TabIndex = 78;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // SuporteAoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(lblHorario);
            Controls.Add(lblAtendimento);
            Controls.Add(lblSuporteAoCliente);
            Controls.Add(btnEntraEmContato);
            Controls.Add(imgWallpaper);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuporteAoCliente";
            Text = "SuporteAoCliente";
            Load += SuporteAoCliente_Load;
            ((System.ComponentModel.ISupportInitialize)imgWallpaper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgWallpaper;
        private WiLBiT.WiLBiTButton2 btnEntraEmContato;
        private Label lblSuporteAoCliente;
        private Label lblAtendimento;
        private Label lblHorario;
        private WiLBiT.WiLBiTButton2 btnVoltar;
    }
}