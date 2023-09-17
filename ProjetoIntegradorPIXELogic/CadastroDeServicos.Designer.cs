﻿namespace ProjetoIntegradorPIXELogic
{
    partial class CadastroDeServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeServicos));
            btnSalvar = new WiLBiT.WiLBiTButton2();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            lblCadastrodeServicos = new Label();
            lblNomedoServico = new Label();
            lblValor = new Label();
            txtNomeDoServico = new TextBox();
            LogoComoWallpaper = new PictureBox();
            maskValor = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 14;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(326, 301);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(148, 42);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "SALVAR";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 12;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(714, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(74, 30);
            btnVoltar.TabIndex = 16;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblCadastrodeServicos
            // 
            lblCadastrodeServicos.AutoSize = true;
            lblCadastrodeServicos.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastrodeServicos.ForeColor = Color.FromArgb(63, 136, 254);
            lblCadastrodeServicos.Location = new Point(221, 93);
            lblCadastrodeServicos.Name = "lblCadastrodeServicos";
            lblCadastrodeServicos.Size = new Size(358, 47);
            lblCadastrodeServicos.TabIndex = 17;
            lblCadastrodeServicos.Text = "Cadastro de serviços";
            // 
            // lblNomedoServico
            // 
            lblNomedoServico.AutoSize = true;
            lblNomedoServico.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomedoServico.ForeColor = Color.FromArgb(63, 136, 254);
            lblNomedoServico.Location = new Point(33, 184);
            lblNomedoServico.Name = "lblNomedoServico";
            lblNomedoServico.Size = new Size(216, 32);
            lblNomedoServico.TabIndex = 18;
            lblNomedoServico.Text = "Nome do serviço:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(219, 248);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(81, 32);
            lblValor.TabIndex = 19;
            lblValor.Text = "Valor:";
            // 
            // txtNomeDoServico
            // 
            txtNomeDoServico.BackColor = Color.FromArgb(53, 81, 142);
            txtNomeDoServico.BorderStyle = BorderStyle.FixedSingle;
            txtNomeDoServico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDoServico.ForeColor = Color.Cyan;
            txtNomeDoServico.Location = new Point(252, 186);
            txtNomeDoServico.Name = "txtNomeDoServico";
            txtNomeDoServico.Size = new Size(296, 29);
            txtNomeDoServico.TabIndex = 66;
            // 
            // LogoComoWallpaper
            // 
            LogoComoWallpaper.Dock = DockStyle.Fill;
            LogoComoWallpaper.Image = (Image)resources.GetObject("LogoComoWallpaper.Image");
            LogoComoWallpaper.Location = new Point(0, 0);
            LogoComoWallpaper.Name = "LogoComoWallpaper";
            LogoComoWallpaper.Size = new Size(800, 450);
            LogoComoWallpaper.TabIndex = 68;
            LogoComoWallpaper.TabStop = false;
            // 
            // maskValor
            // 
            maskValor.BackColor = Color.FromArgb(53, 81, 142);
            maskValor.BorderStyle = BorderStyle.FixedSingle;
            maskValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskValor.Location = new Point(302, 249);
            maskValor.Mask = "$ 000,00";
            maskValor.Name = "maskValor";
            maskValor.Size = new Size(196, 29);
            maskValor.TabIndex = 69;
            // 
            // CadastroDeServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(maskValor);
            Controls.Add(txtNomeDoServico);
            Controls.Add(lblValor);
            Controls.Add(lblNomedoServico);
            Controls.Add(lblCadastrodeServicos);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(LogoComoWallpaper);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroDeServicos";
            Text = "CadastroDeServicos";
            Load += CadastroDeServicos_Load;
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private Label lblCadastrodeServicos;
        private Label lblNomedoServico;
        private Label lblValor;
        private TextBox txtNomeDoServico;
        private PictureBox LogoComoWallpaper;
        private MaskedTextBox maskValor;
    }
}