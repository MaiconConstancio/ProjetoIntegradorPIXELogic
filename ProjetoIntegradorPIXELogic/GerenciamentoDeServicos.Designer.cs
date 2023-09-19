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
            btnVoltar = new WiLBiT.WiLBiTButton2();
            btnNovoOrcamento = new WiLBiT.WiLBiTButton2();
            lblCliente = new Label();
            lblEstimativaDeEntrega = new Label();
            lblFuncionario = new Label();
            lblEndereco = new Label();
            lblValor = new Label();
            lblServico = new Label();
            lblEditar = new Label();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            panel1 = new Panel();
            btnCapturarImagem = new WiLBiT.WiLBiTButton2();
            btnImprimir = new WiLBiT.WiLBiTButton2();
            SuspendLayout();
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
            // btnNovoOrcamento
            // 
            btnNovoOrcamento.BackColor = Color.FromArgb(72, 116, 245);
            btnNovoOrcamento.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnNovoOrcamento.BorderColor = Color.FromArgb(0, 242, 254);
            btnNovoOrcamento.BorderRadius = 12;
            btnNovoOrcamento.BorderSize = 2;
            btnNovoOrcamento.FlatAppearance.BorderSize = 0;
            btnNovoOrcamento.FlatStyle = FlatStyle.Flat;
            btnNovoOrcamento.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoOrcamento.ForeColor = Color.Black;
            btnNovoOrcamento.Location = new Point(12, 406);
            btnNovoOrcamento.Name = "btnNovoOrcamento";
            btnNovoOrcamento.Size = new Size(150, 32);
            btnNovoOrcamento.TabIndex = 2;
            btnNovoOrcamento.Text = "Novo Orçamento";
            btnNovoOrcamento.TextColor = Color.Black;
            btnNovoOrcamento.UseVisualStyleBackColor = false;
            btnNovoOrcamento.Click += btnNovoOrcamento_Click;
            // 
            // lblCliente
            // 
            lblCliente.BorderStyle = BorderStyle.FixedSingle;
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblCliente.Location = new Point(12, 86);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(90, 30);
            lblCliente.TabIndex = 26;
            lblCliente.Text = "Cliente";
            lblCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEstimativaDeEntrega
            // 
            lblEstimativaDeEntrega.BorderStyle = BorderStyle.FixedSingle;
            lblEstimativaDeEntrega.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstimativaDeEntrega.ForeColor = Color.FromArgb(63, 136, 254);
            lblEstimativaDeEntrega.Location = new Point(504, 86);
            lblEstimativaDeEntrega.Name = "lblEstimativaDeEntrega";
            lblEstimativaDeEntrega.Size = new Size(206, 30);
            lblEstimativaDeEntrega.TabIndex = 27;
            lblEstimativaDeEntrega.Text = "Estimativa de entrega";
            lblEstimativaDeEntrega.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFuncionario
            // 
            lblFuncionario.BorderStyle = BorderStyle.FixedSingle;
            lblFuncionario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFuncionario.ForeColor = Color.FromArgb(63, 136, 254);
            lblFuncionario.Location = new Point(376, 86);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(122, 30);
            lblFuncionario.TabIndex = 28;
            lblFuncionario.Text = "Funcionario";
            lblFuncionario.TextAlign = ContentAlignment.MiddleCenter;
            lblFuncionario.Click += lblFuncionario_Click;
            // 
            // lblEndereco
            // 
            lblEndereco.BorderStyle = BorderStyle.FixedSingle;
            lblEndereco.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco.ForeColor = Color.FromArgb(63, 136, 254);
            lblEndereco.Location = new Point(270, 86);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(100, 30);
            lblEndereco.TabIndex = 29;
            lblEndereco.Text = "Endereço";
            lblEndereco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            lblValor.BorderStyle = BorderStyle.FixedSingle;
            lblValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(194, 86);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(70, 30);
            lblValor.TabIndex = 30;
            lblValor.Text = "Valor";
            lblValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblServico
            // 
            lblServico.BorderStyle = BorderStyle.FixedSingle;
            lblServico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblServico.ForeColor = Color.FromArgb(63, 136, 254);
            lblServico.Location = new Point(108, 86);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(80, 30);
            lblServico.TabIndex = 31;
            lblServico.Text = "Serviço";
            lblServico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEditar
            // 
            lblEditar.BorderStyle = BorderStyle.FixedSingle;
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditar.ForeColor = Color.FromArgb(63, 136, 254);
            lblEditar.Location = new Point(721, 86);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(70, 30);
            lblEditar.TabIndex = 33;
            lblEditar.Text = "Editar";
            lblEditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 12;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(168, 406);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 32);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Location = new Point(12, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 10);
            panel1.TabIndex = 35;
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
            btnCapturarImagem.TabIndex = 41;
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
            btnImprimir.TabIndex = 40;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextColor = Color.Black;
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // GerenciamentoDeServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCapturarImagem);
            Controls.Add(btnImprimir);
            Controls.Add(panel1);
            Controls.Add(btnSalvar);
            Controls.Add(lblEditar);
            Controls.Add(lblServico);
            Controls.Add(lblValor);
            Controls.Add(lblEndereco);
            Controls.Add(lblFuncionario);
            Controls.Add(lblEstimativaDeEntrega);
            Controls.Add(lblCliente);
            Controls.Add(btnNovoOrcamento);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GerenciamentoDeServicos";
            Text = "GerenciamentoDeServicos";
            Load += GerenciamentoDeServicos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTButton2 btnVoltar;
        private WiLBiT.WiLBiTButton2 btnNovoOrcamento;
        private Label lblCliente;
        private Label lblEstimativaDeEntrega;
        private Label lblFuncionario;
        private Label lblEndereco;
        private Label lblValor;
        private Label lblServico;
        private Label lblEditar;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private Panel panel1;
        private WiLBiT.WiLBiTButton2 btnCapturarImagem;
        private WiLBiT.WiLBiTButton2 btnImprimir;
    }
}