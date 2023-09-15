﻿namespace ProjetoIntegradorPIXELogic
{
    partial class SagaoPrincipal
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
            btnSalvar = new WiLBiT.WiLBiTButton2();
            lblOrcamentoDeServicos = new Label();
            panel1 = new Panel();
            btnCadastros = new Button();
            btnVendas = new Button();
            btnRelatorioProdutos = new Button();
            btnRelatorioServicos = new Button();
            btnSuporte = new Button();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BackgroundColor = Color.FromArgb(72, 116, 245);
            btnSalvar.BorderColor = Color.FromArgb(0, 242, 254);
            btnSalvar.BorderRadius = 18;
            btnSalvar.BorderSize = 2;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.World);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(653, 12);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(135, 36);
            btnSalvar.TabIndex = 75;
            btnSalvar.Text = "Configurações";
            btnSalvar.TextColor = Color.Black;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblOrcamentoDeServicos
            // 
            lblOrcamentoDeServicos.AutoSize = true;
            lblOrcamentoDeServicos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrcamentoDeServicos.ForeColor = Color.MintCream;
            lblOrcamentoDeServicos.Location = new Point(26, 12);
            lblOrcamentoDeServicos.Name = "lblOrcamentoDeServicos";
            lblOrcamentoDeServicos.Size = new Size(69, 25);
            lblOrcamentoDeServicos.TabIndex = 76;
            lblOrcamentoDeServicos.Text = "MENU";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 0);
            panel1.TabIndex = 77;
            // 
            // btnCadastros
            // 
            btnCadastros.Name = "btnCadastros";
            btnCadastros.Size = new Size(75, 23);
            btnCadastros.TabIndex = 78;
            btnCadastros.Text = "Cadastros";
            btnCadastros.UseVisualStyleBackColor = true;
            btnCadastros.Click += btnCadastros_Click;
            // 
            // btnVendas
            // 
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(75, 23);
            btnVendas.TabIndex = 78;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = true;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnRelatorioProdutos
            // 
            btnRelatorioProdutos.Name = "btnRProduto";
            btnRelatorioProdutos.Size = new Size(75, 23);
            btnRelatorioProdutos.TabIndex = 78;
            btnRelatorioProdutos.Text = "Relatório Produto";
            btnRelatorioProdutos.UseVisualStyleBackColor = true;
            btnRelatorioProdutos.Click += btnRelatorioProdutos_Click;
            // 
            // btnRelatorioServicos
            // 
            btnRelatorioServicos.Name = "btnRServico";
            btnRelatorioServicos.Size = new Size(75, 23);
            btnRelatorioServicos.TabIndex = 78;
            btnRelatorioServicos.Text = "Relatório Seviço";
            btnRelatorioServicos.UseVisualStyleBackColor = true;
            btnRelatorioServicos.Click += btnRelatorioServicos_Click;
            // 
            // button5
            // 
            btnSuporte.Name = "btnSuporte";
            btnSuporte.Size = new Size(75, 23);
            btnSuporte.TabIndex = 78;
            btnSuporte.Text = "suporte";
            btnSuporte.UseVisualStyleBackColor = true;
            btnSuporte.Click += btnSuporte_Click;
            // 
            // SagaoPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lblOrcamentoDeServicos);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SagaoPrincipal";
            Text = "SagaoPrincipal";
            Load += SagaoPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
 
            RodaTodosForms.panel1.Controls.Clear();
            SelecionaQualCadastro selecionaQualCadastro = new SelecionaQualCadastro();
            selecionaQualCadastro.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(selecionaQualCadastro);
            selecionaQualCadastro.Show();

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            Vendas vendas = new Vendas();
            vendas.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(vendas);
            vendas.Show();

        }

        private void btnRelatorioProdutos_Click(object sender, EventArgs e)
        {



        }

        private void btnRelatorioServicos_Click(object sender, EventArgs e)
        {



        }

        private void btnSuporte_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            SuporteAoCliente suporteAoCliente = new SuporteAoCliente();
            suporteAoCliente.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(suporteAoCliente);
            suporteAoCliente.Show();

        }

        #endregion

        private WiLBiT.WiLBiTButton2 btnSalvar;
        private Label lblOrcamentoDeServicos;
        private Panel panel1;
        private Button btnCadastros;
        private Button btnVendas;
        private Button btnRelatorioProdutos;
        private Button btnRelatorioServicos;
        private Button btnSuporte;

    }
}