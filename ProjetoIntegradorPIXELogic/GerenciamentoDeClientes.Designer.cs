﻿namespace ProjetoIntegradorPIXELogic
{
    partial class GerenciamentoDeClientes
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
            btnNovoCadastro = new WiLBiT.WiLBiTButton2();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            lblEditar = new Label();
            lblStatus = new Label();
            lblServico = new Label();
            lblValor = new Label();
            lblEndereco = new Label();
            lblFuncionario = new Label();
            lblEstimativaDeEntrega = new Label();
            lblCliente = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnCapturarImagem = new WiLBiT.WiLBiTButton2();
            btnImprimir = new WiLBiT.WiLBiTButton2();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.BackColor = Color.FromArgb(72, 116, 245);
            btnNovoCadastro.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnNovoCadastro.BorderColor = Color.FromArgb(0, 242, 254);
            btnNovoCadastro.BorderRadius = 12;
            btnNovoCadastro.BorderSize = 2;
            btnNovoCadastro.FlatAppearance.BorderSize = 0;
            btnNovoCadastro.FlatStyle = FlatStyle.Flat;
            btnNovoCadastro.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoCadastro.ForeColor = Color.Black;
            btnNovoCadastro.Location = new Point(12, 406);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(150, 32);
            btnNovoCadastro.TabIndex = 2;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.TextColor = Color.Black;
            btnNovoCadastro.UseVisualStyleBackColor = false;
            btnNovoCadastro.Click += btnNovoCadastro_Click;
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
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblEditar
            // 
            lblEditar.BorderStyle = BorderStyle.FixedSingle;
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditar.ForeColor = Color.FromArgb(63, 136, 254);
            lblEditar.Location = new Point(718, 86);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(70, 30);
            lblEditar.TabIndex = 44;
            lblEditar.Text = "Ação";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(63, 136, 254);
            lblStatus.Location = new Point(609, 86);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(103, 30);
            lblStatus.TabIndex = 43;
            lblStatus.Text = "Cidade";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblServico
            // 
            lblServico.BorderStyle = BorderStyle.FixedSingle;
            lblServico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblServico.ForeColor = Color.FromArgb(63, 136, 254);
            lblServico.Location = new Point(98, 86);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(80, 30);
            lblServico.TabIndex = 42;
            lblServico.Text = "CPF";
            lblServico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            lblValor.BorderStyle = BorderStyle.FixedSingle;
            lblValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(313, 86);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(70, 30);
            lblValor.TabIndex = 41;
            lblValor.Text = "CEP";
            lblValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEndereco
            // 
            lblEndereco.BorderStyle = BorderStyle.FixedSingle;
            lblEndereco.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco.ForeColor = Color.FromArgb(63, 136, 254);
            lblEndereco.Location = new Point(503, 86);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(100, 30);
            lblEndereco.TabIndex = 40;
            lblEndereco.Text = "Endereço";
            lblEndereco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFuncionario
            // 
            lblFuncionario.BorderStyle = BorderStyle.FixedSingle;
            lblFuncionario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFuncionario.ForeColor = Color.FromArgb(63, 136, 254);
            lblFuncionario.Location = new Point(184, 86);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(123, 30);
            lblFuncionario.TabIndex = 39;
            lblFuncionario.Text = "Telefone";
            lblFuncionario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEstimativaDeEntrega
            // 
            lblEstimativaDeEntrega.BorderStyle = BorderStyle.FixedSingle;
            lblEstimativaDeEntrega.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstimativaDeEntrega.ForeColor = Color.FromArgb(63, 136, 254);
            lblEstimativaDeEntrega.Location = new Point(389, 86);
            lblEstimativaDeEntrega.Name = "lblEstimativaDeEntrega";
            lblEstimativaDeEntrega.Size = new Size(108, 30);
            lblEstimativaDeEntrega.TabIndex = 38;
            lblEstimativaDeEntrega.Text = "Numero";
            lblEstimativaDeEntrega.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            lblCliente.BorderStyle = BorderStyle.FixedSingle;
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblCliente.Location = new Point(12, 86);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(80, 30);
            lblCliente.TabIndex = 37;
            lblCliente.Text = "Cliente";
            lblCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Location = new Point(11, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 10);
            panel1.TabIndex = 46;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnCapturarImagem
            // 
            btnCapturarImagem.BackColor = Color.FromArgb(72, 116, 245);
            btnCapturarImagem.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnCapturarImagem.BorderColor = Color.FromArgb(0, 242, 254);
            btnCapturarImagem.BorderRadius = 12;
            btnCapturarImagem.BorderSize = 2;
            btnCapturarImagem.FlatAppearance.BorderSize = 0;
            btnCapturarImagem.FlatStyle = FlatStyle.Flat;
            btnCapturarImagem.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapturarImagem.ForeColor = Color.Black;
            btnCapturarImagem.Location = new Point(12, 12);
            btnCapturarImagem.Name = "btnCapturarImagem";
            btnCapturarImagem.Size = new Size(154, 32);
            btnCapturarImagem.TabIndex = 49;
            btnCapturarImagem.Text = "Captura de tela";
            btnCapturarImagem.TextColor = Color.Black;
            btnCapturarImagem.UseVisualStyleBackColor = false;
            btnCapturarImagem.Click += btnCapturarImagem_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnImprimir.BorderColor = Color.FromArgb(0, 242, 254);
            btnImprimir.BorderRadius = 12;
            btnImprimir.BorderSize = 2;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Location = new Point(169, 12);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(112, 32);
            btnImprimir.TabIndex = 48;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextColor = Color.Black;
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // GerenciamentoDeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCapturarImagem);
            Controls.Add(btnImprimir);
            Controls.Add(panel1);
            Controls.Add(lblEditar);
            Controls.Add(lblStatus);
            Controls.Add(lblServico);
            Controls.Add(lblValor);
            Controls.Add(lblEndereco);
            Controls.Add(lblFuncionario);
            Controls.Add(lblEstimativaDeEntrega);
            Controls.Add(lblCliente);
            Controls.Add(btnVoltar);
            Controls.Add(btnNovoCadastro);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GerenciamentoDeClientes";
            Text = "    ";
            Load += GerenciamentoDeClientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEscolhaSeusColaboradoresESuasCredenciais;
        private WiLBiT.WiLBiTButton2 btnNovoCadastro;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private Label lblEditar;
        private Label lblStatus;
        private Label lblServico;
        private Label lblValor;
        private Label lblEndereco;
        private Label lblFuncionario;
        private Label lblEstimativaDeEntrega;
        private Label lblCliente;
        private Panel panel1;
        private PictureBox pictureBox1;
        private WiLBiT.WiLBiTButton2 btnCapturarImagem;
        private WiLBiT.WiLBiTButton2 btnImprimir;
    }
}