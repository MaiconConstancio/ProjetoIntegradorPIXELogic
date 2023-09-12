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

            if (Funcoes.campoVazio("Nome", txtNome) == false && Funcoes.campoVazio("Fornecedor", txtFornecedor) == false &&
                Funcoes.campoVazio("Quantidade", txtQuantidade) == false && Funcoes.campoVazio("Valor", txtValor) == false)
            {

                if (MessageBox.Show("Este produto ja está cadastrado, deseja continuar ?","Produto já cadastrado!",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    if (MessageBox.Show($"Nome: {txtNome.Text}\n\n" +
                    $"Fornecedor: {txtFornecedor.Text}\n\n" +
                    $"Quantidade: {txtQuantidade.Text}\n\n" +
                    $"Valor: {txtValor.Text}\n\n" +
                    $"Vencimento: {txtVencimento.Text}\n\n",
                    "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {

                        string query = $"insert into produtos (nome,fornecedor,quantidade,valor,vencimento) values " +
                            $"('{txtNome.Text}','{txtFornecedor.Text}','{txtQuantidade.Text}','{txtValor.Text}','{txtVencimento.Text}');";
                        Conexao.executaQuery(query);

                        txtNome.Clear();
                        txtFornecedor.Clear();
                        txtQuantidade.Clear();
                        txtValor.Clear();
                        txtVencimento.Clear();

                    }

                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.panel1.Controls.Clear();
            Lista lista = new Lista();
            lista.TopLevel = false;
            Form1.panel1.Controls.Add(lista);
            lista.Show();


        }
    }
}
