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
    public partial class Cadastro : System.Windows.Forms.Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Funcoes.campoVazio("Produto", comboProduto) == false && Funcoes.campoVazio("Quantidade", txtQuantidade) == false &&
                Funcoes.campoVazio("Nome do cliente", txtNomeCliente) == false && Funcoes.campoVazio("Valor", comboValor) == false &&
                Funcoes.campoVazio("Método de pagamento", comboMPagamento) == false)
            {


                if (MessageBox.Show($"Produto: {comboProduto.Text}\n\n" +
                $"Quantidade: {txtQuantidade.Text}\n\n" +
                $"Nome do Cliente: {txtNomeCliente.Text}\n\n" +
                $"Método de pagamento: {comboMPagamento.Text}\n\n" +
                $"Valor: {comboValor.Text}\n\n",
                "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                {

                    string queryi = $"insert into vendas (produto, quantidade, nome_cliente, metodo_pagamento, valor) values " +
                        $"('{comboProduto.Text}','{txtQuantidade.Text}','{txtNomeCliente.Text}','{comboMPagamento.Text}','{comboValor.Text}');";
                    Conexao.executaQuery(queryi);

                    comboProduto.Text = "";
                    txtQuantidade.Clear();
                    txtNomeCliente.Clear();
                    comboMPagamento.Text = "";
                    comboValor.Text = "";

                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void btnVTItens_Click(object sender, EventArgs e)
        {
            Form1.panel1.Controls.Clear();
            Lista lista = new Lista();
            lista.TopLevel = false;
            Form1.panel1.Controls.Add(lista);
            lista.Show();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
           foreach (DataRow row in Conexao.executaQuery("select * from produtos").Rows)
            {
                comboProduto.Items.Add(row["produtos"]);
                comboValor.Items.Add(row["valor"]);
                
            }
            comboMPagamento.Items.Add("Cartao de debito");
            comboMPagamento.Items.Add("Cartao de crédito");
            comboMPagamento.Items.Add("Pix");
            comboMPagamento.Items.Add("Dinheiro");
        }
    }
}
