using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorPIXELogic
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer------------------------------------
            lblProduto.Parent = LogoComoWallpaper;
            lblProduto.BackColor = Color.Transparent;

            lblQuantidade.Parent = LogoComoWallpaper;
            lblQuantidade.BackColor = Color.Transparent;

            lblNomeDoCliente.Parent = LogoComoWallpaper;
            lblNomeDoCliente.BackColor = Color.Transparent;

            lblMetodoDePagamento.Parent = LogoComoWallpaper;
            lblMetodoDePagamento.BackColor = Color.Transparent;

            lblValor.Parent = LogoComoWallpaper;
            lblValor.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer------------------------------------
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            SagaoPrincipal sagaoPrincipal = new SagaoPrincipal();
            sagaoPrincipal.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(sagaoPrincipal);
            sagaoPrincipal.Show();

        }

        private void btnVerTodosOsItens_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            RelatorioDeVendas relatorioDeVendas = new RelatorioDeVendas();
            relatorioDeVendas.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(relatorioDeVendas);
            relatorioDeVendas.Show();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Funcoes.campoVazio("Produto", cmbProduto) == false && Funcoes.campoVazio("Qauntidade", txtQuantidade) == false &&
            Funcoes.campoVazio("Nome do cliente", txtNomeDoCliente) == false && Funcoes.campoVazio("Método de pagamento", cmbMetodoDePagamento) == false &&
            Funcoes.campoVazio("Valor", maskValor) == false)
            {

                if (Funcoes.existe("produtos", "nome", cmbProduto) == true)
                {

                    if (MessageBox.Show("Tem certeza que deseja cadastrar dois produtos identicos ?","Produto já existente!",MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        if (MessageBox.Show($"Produto: {cmbProduto.Text}\n\n" +
                            $"Quantidade: {txtQuantidade.Text}\n\n" +
                            $"Nome do cliente: {txtNomeDoCliente.Text}\n\n" +
                            $"Método de pagamento: {cmbMetodoDePagamento.Text}\n\n" +
                            $"Valor: {maskValor.Text}\n\n",
                            "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                        {

                            string query = $"insert into vendas (produto,quantidade,nome_cliente,metodo_pagamento,valor) values " +
                                $"('{cmbProduto.Text}','{txtQuantidade.Text}','{txtNomeDoCliente.Text}','{cmbMetodoDePagamento.Text}','{maskValor.Text}');";
                            Conexao.executaQuery(query);

                            cmbProduto.Text = "";
                            txtQuantidade.Clear();
                            txtNomeDoCliente.Clear();
                            cmbMetodoDePagamento.Text = "";
                            maskValor.Clear();

                        }

                    }

                }

                else
                {

                    if (MessageBox.Show($"Produto: {cmbProduto.Text}\n\n" +
                        $"Quantidade: {txtQuantidade.Text}\n\n" +
                        $"Nome do cliente: {txtNomeDoCliente.Text}\n\n" +
                        $"Método de pagamento: {cmbMetodoDePagamento.Text}\n\n" +
                        $"Valor: {maskValor.Text}\n\n",
                        "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                    {

                        string query = $"insert into vendas (produto,quantidade,nome_cliente,metodo_pagamento,valor) values " +
                            $"('{cmbProduto.Text}','{txtQuantidade.Text}','{txtNomeDoCliente.Text}','{cmbMetodoDePagamento.Text}','{maskValor.Text}');";
                        Conexao.executaQuery(query);

                        cmbProduto.Text = "";
                        txtQuantidade.Clear();
                        txtNomeDoCliente.Clear();
                        cmbMetodoDePagamento.Text = "";
                        maskValor.Clear();

                    }

                }

            }

        }
    }
}
