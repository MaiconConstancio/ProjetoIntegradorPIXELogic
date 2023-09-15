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
            lblStatus = new Label();
            lblEditar = new Label();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BorderColor = Color.FromArgb(0, 242, 254);
            btnVoltar.BorderRadius = 14;
            btnVoltar.BorderSize = 2;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(726, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(117, 39);
            btnVoltar.TabIndex = 20;
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
            btnNovoOrcamento.BorderRadius = 14;
            btnNovoOrcamento.BorderSize = 2;
            btnNovoOrcamento.FlatAppearance.BorderSize = 0;
            btnNovoOrcamento.FlatStyle = FlatStyle.Flat;
            btnNovoOrcamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoOrcamento.ForeColor = Color.Black;
            btnNovoOrcamento.Location = new Point(12, 398);
            btnNovoOrcamento.Name = "btnNovoOrcamento";
            btnNovoOrcamento.Size = new Size(189, 40);
            btnNovoOrcamento.TabIndex = 21;
            btnNovoOrcamento.Text = "Novo Orçamento";
            btnNovoOrcamento.TextColor = Color.Black;
            btnNovoOrcamento.UseVisualStyleBackColor = false;
            // 
            // lblCliente
            // 
            lblCliente.BorderStyle = BorderStyle.FixedSingle;
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblCliente.Location = new Point(10, 70);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(80, 30);
            lblCliente.TabIndex = 26;
            lblCliente.Text = "Cliente";
            lblCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEstimativaDeEntrega
            // 
            lblEstimativaDeEntrega.BorderStyle = BorderStyle.FixedSingle;
            lblEstimativaDeEntrega.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstimativaDeEntrega.ForeColor = Color.FromArgb(63, 136, 254);
            lblEstimativaDeEntrega.Location = new Point(493, 70);
            lblEstimativaDeEntrega.Name = "lblEstimativaDeEntrega";
            lblEstimativaDeEntrega.Size = new Size(207, 30);
            lblEstimativaDeEntrega.TabIndex = 27;
            lblEstimativaDeEntrega.Text = "Estimativa de entrega";
            lblEstimativaDeEntrega.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFuncionario
            // 
            lblFuncionario.BorderStyle = BorderStyle.FixedSingle;
            lblFuncionario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFuncionario.ForeColor = Color.FromArgb(63, 136, 254);
            lblFuncionario.Location = new Point(364, 70);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(123, 30);
            lblFuncionario.TabIndex = 28;
            lblFuncionario.Text = "Funcionario";
            lblFuncionario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEndereco
            // 
            lblEndereco.BorderStyle = BorderStyle.FixedSingle;
            lblEndereco.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco.ForeColor = Color.FromArgb(63, 136, 254);
            lblEndereco.Location = new Point(258, 70);
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
            lblValor.Location = new Point(182, 70);
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
            lblServico.Location = new Point(96, 70);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(80, 30);
            lblServico.TabIndex = 31;
            lblServico.Text = "Serviço";
            lblServico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(63, 136, 254);
            lblStatus.Location = new Point(706, 70);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(70, 30);
            lblStatus.TabIndex = 32;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEditar
            // 
            lblEditar.BorderStyle = BorderStyle.FixedSingle;
            lblEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditar.ForeColor = Color.FromArgb(63, 136, 254);
            lblEditar.Location = new Point(782, 70);
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
            btnSalvar.BorderRadius = 14;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(218, 398);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(117, 40);
            btnSalvar.TabIndex = 34;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // GerenciamentoDeServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(855, 450);
            Controls.Add(btnSalvar);
            Controls.Add(lblEditar);
            Controls.Add(lblStatus);
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
        private Label lblStatus;
        private Label lblEditar;
        private WiLBiT.WiLBiTButton2 btnSalvar;
    }
}