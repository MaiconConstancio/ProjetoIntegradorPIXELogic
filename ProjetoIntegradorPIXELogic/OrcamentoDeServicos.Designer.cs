namespace ProjetoIntegradorPIXELogic
{
    partial class OrcamentoDeServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrcamentoDeServicos));
            lblCidade = new Label();
            lblPrazoDeEntrega = new Label();
            lblFuncionario = new Label();
            lblEndereco = new Label();
            lblValor = new Label();
            lblServico = new Label();
            lblOrcamentoDeServicos = new Label();
            btnSalvar = new WiLBiT.WiLBiTButton2();
            lblNomeDoCliente = new Label();
            btnNovoServico = new WiLBiT.WiLBiTButton2();
            btnVoltar = new WiLBiT.WiLBiTButton2();
            txtNomeDoCliente = new TextBox();
            cmbServico = new ComboBox();
            maskValor = new MaskedTextBox();
            txtEndereco = new TextBox();
            txtFuncionario = new TextBox();
            txtCidade = new TextBox();
            LogoComoWallpaper = new PictureBox();
            maskPrazoDeEntrega = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).BeginInit();
            SuspendLayout();
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.ForeColor = Color.FromArgb(63, 136, 254);
            lblCidade.Location = new Point(175, 321);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(113, 37);
            lblCidade.TabIndex = 52;
            lblCidade.Text = "Cidade:";
            // 
            // lblPrazoDeEntrega
            // 
            lblPrazoDeEntrega.AutoSize = true;
            lblPrazoDeEntrega.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrazoDeEntrega.ForeColor = Color.FromArgb(63, 136, 254);
            lblPrazoDeEntrega.Location = new Point(64, 286);
            lblPrazoDeEntrega.Name = "lblPrazoDeEntrega";
            lblPrazoDeEntrega.Size = new Size(243, 37);
            lblPrazoDeEntrega.TabIndex = 50;
            lblPrazoDeEntrega.Text = "Prazo de entrega:";
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblFuncionario.ForeColor = Color.FromArgb(63, 136, 254);
            lblFuncionario.Location = new Point(102, 249);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(175, 37);
            lblFuncionario.TabIndex = 48;
            lblFuncionario.Text = "Funcionario:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco.ForeColor = Color.FromArgb(63, 136, 254);
            lblEndereco.Location = new Point(145, 214);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(142, 37);
            lblEndereco.TabIndex = 46;
            lblEndereco.Text = "Endereço:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.FromArgb(63, 136, 254);
            lblValor.Location = new Point(209, 177);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(92, 37);
            lblValor.TabIndex = 44;
            lblValor.Text = "Valor:";
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblServico.ForeColor = Color.FromArgb(63, 136, 254);
            lblServico.Location = new Point(131, 142);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(119, 37);
            lblServico.TabIndex = 42;
            lblServico.Text = "Serviço:";
            // 
            // lblOrcamentoDeServicos
            // 
            lblOrcamentoDeServicos.AutoSize = true;
            lblOrcamentoDeServicos.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrcamentoDeServicos.ForeColor = Color.Cyan;
            lblOrcamentoDeServicos.Location = new Point(245, 50);
            lblOrcamentoDeServicos.Name = "lblOrcamentoDeServicos";
            lblOrcamentoDeServicos.Size = new Size(310, 37);
            lblOrcamentoDeServicos.TabIndex = 41;
            lblOrcamentoDeServicos.Text = "Orçamento de serviços";
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
            btnSalvar.Location = new Point(349, 384);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 32);
            btnSalvar.TabIndex = 39;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNomeDoCliente
            // 
            lblNomeDoCliente.AutoSize = true;
            lblNomeDoCliente.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeDoCliente.ForeColor = Color.FromArgb(63, 136, 254);
            lblNomeDoCliente.Location = new Point(36, 104);
            lblNomeDoCliente.Name = "lblNomeDoCliente";
            lblNomeDoCliente.Size = new Size(236, 37);
            lblNomeDoCliente.TabIndex = 54;
            lblNomeDoCliente.Text = "Nome do cliente:";
            // 
            // btnNovoServico
            // 
            btnNovoServico.BackColor = Color.FromArgb(72, 116, 245);
            btnNovoServico.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnNovoServico.BorderColor = Color.FromArgb(0, 242, 254);
            btnNovoServico.BorderRadius = 14;
            btnNovoServico.BorderSize = 2;
            btnNovoServico.FlatAppearance.BorderSize = 0;
            btnNovoServico.FlatStyle = FlatStyle.Flat;
            btnNovoServico.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoServico.ForeColor = Color.Black;
            btnNovoServico.Location = new Point(12, 406);
            btnNovoServico.Name = "btnNovoServico";
            btnNovoServico.Size = new Size(150, 32);
            btnNovoServico.TabIndex = 55;
            btnNovoServico.Text = "Novo serviço";
            btnNovoServico.TextColor = Color.Black;
            btnNovoServico.UseVisualStyleBackColor = false;
            btnNovoServico.Click += btnNovoServico_Click;
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
            btnVoltar.TabIndex = 56;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.Black;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtNomeDoCliente
            // 
            txtNomeDoCliente.BackColor = Color.FromArgb(53, 81, 142);
            txtNomeDoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeDoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDoCliente.ForeColor = Color.Cyan;
            txtNomeDoCliente.Location = new Point(273, 110);
            txtNomeDoCliente.Name = "txtNomeDoCliente";
            txtNomeDoCliente.Size = new Size(254, 29);
            txtNomeDoCliente.TabIndex = 57;
            // 
            // cmbServico
            // 
            cmbServico.BackColor = Color.FromArgb(53, 81, 142);
            cmbServico.FlatStyle = FlatStyle.Popup;
            cmbServico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbServico.ForeColor = Color.Cyan;
            cmbServico.FormattingEnabled = true;
            cmbServico.Location = new Point(252, 146);
            cmbServico.Name = "cmbServico";
            cmbServico.Size = new Size(296, 29);
            cmbServico.TabIndex = 58;
            // 
            // maskValor
            // 
            maskValor.BackColor = Color.FromArgb(53, 81, 142);
            maskValor.BorderStyle = BorderStyle.FixedSingle;
            maskValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskValor.Location = new Point(302, 182);
            maskValor.Mask = "$ 000,00";
            maskValor.Name = "maskValor";
            maskValor.Size = new Size(196, 29);
            maskValor.TabIndex = 59;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.FromArgb(53, 81, 142);
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.ForeColor = Color.Cyan;
            txtEndereco.Location = new Point(289, 218);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(223, 29);
            txtEndereco.TabIndex = 60;
            txtEndereco.TextChanged += txtEndereco_TextChanged;
            // 
            // txtFuncionario
            // 
            txtFuncionario.BackColor = Color.FromArgb(53, 81, 142);
            txtFuncionario.BorderStyle = BorderStyle.FixedSingle;
            txtFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionario.ForeColor = Color.Cyan;
            txtFuncionario.Location = new Point(278, 254);
            txtFuncionario.Name = "txtFuncionario";
            txtFuncionario.Size = new Size(245, 29);
            txtFuncionario.TabIndex = 61;
            txtFuncionario.TextChanged += txtFuncionario_TextChanged;
            // 
            // txtCidade
            // 
            txtCidade.BackColor = Color.FromArgb(53, 81, 142);
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.ForeColor = Color.Cyan;
            txtCidade.Location = new Point(289, 326);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(223, 29);
            txtCidade.TabIndex = 63;
            txtCidade.TextChanged += txtCidade_TextChanged;
            // 
            // LogoComoWallpaper
            // 
            LogoComoWallpaper.Dock = DockStyle.Fill;
            LogoComoWallpaper.Image = (Image)resources.GetObject("LogoComoWallpaper.Image");
            LogoComoWallpaper.Location = new Point(0, 0);
            LogoComoWallpaper.Name = "LogoComoWallpaper";
            LogoComoWallpaper.Size = new Size(800, 450);
            LogoComoWallpaper.SizeMode = PictureBoxSizeMode.Zoom;
            LogoComoWallpaper.TabIndex = 64;
            LogoComoWallpaper.TabStop = false;
            // 
            // maskPrazoDeEntrega
            // 
            maskPrazoDeEntrega.BackColor = Color.FromArgb(53, 81, 142);
            maskPrazoDeEntrega.BorderStyle = BorderStyle.FixedSingle;
            maskPrazoDeEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskPrazoDeEntrega.Location = new Point(309, 290);
            maskPrazoDeEntrega.Mask = "00/00/0000";
            maskPrazoDeEntrega.Name = "maskPrazoDeEntrega";
            maskPrazoDeEntrega.Size = new Size(183, 29);
            maskPrazoDeEntrega.TabIndex = 65;
            maskPrazoDeEntrega.MaskInputRejected += maskPrazoDeEntrega_MaskInputRejected;
            // 
            // OrcamentoDeServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(maskPrazoDeEntrega);
            Controls.Add(txtCidade);
            Controls.Add(txtFuncionario);
            Controls.Add(txtEndereco);
            Controls.Add(maskValor);
            Controls.Add(cmbServico);
            Controls.Add(txtNomeDoCliente);
            Controls.Add(btnVoltar);
            Controls.Add(btnNovoServico);
            Controls.Add(lblCidade);
            Controls.Add(lblPrazoDeEntrega);
            Controls.Add(lblFuncionario);
            Controls.Add(lblEndereco);
            Controls.Add(lblValor);
            Controls.Add(lblServico);
            Controls.Add(lblOrcamentoDeServicos);
            Controls.Add(btnSalvar);
            Controls.Add(lblNomeDoCliente);
            Controls.Add(LogoComoWallpaper);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrcamentoDeServicos";
            Text = "OrcamentoDeServicos";
            Load += OrcamentoDeServicos_Load;
            ((System.ComponentModel.ISupportInitialize)LogoComoWallpaper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCidade;
        private Label lblPrazoDeEntrega;
        private Label lblFuncionario;
        private Label lblEndereco;
        private Label lblValor;
        private Label lblServico;
        private Label lblOrcamentoDeServicos;
        private WiLBiT.WiLBiTButton2 btnSalvar;
        private Label lblNomeDoCliente;
        private WiLBiT.WiLBiTButton2 btnNovoServico;
        private WiLBiT.WiLBiTButton2 btnVoltar;
        private TextBox txtNomeDoCliente;
        private ComboBox cmbServico;
        private MaskedTextBox maskValor;
        private TextBox txtEndereco;
        private TextBox txtFuncionario;
        private TextBox txtCidade;
        private PictureBox LogoComoWallpaper;
        private MaskedTextBox maskPrazoDeEntrega;
    }
}