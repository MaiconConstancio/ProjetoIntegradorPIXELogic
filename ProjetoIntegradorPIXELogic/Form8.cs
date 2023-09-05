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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (Auxiliares.verificaCampo("Nome do fornecedor", txtNomedoFornecedor) == false &&
                Auxiliares.verificaCampo("Endereço", txtEndereco) == false &&
                Auxiliares.verificaCampo("Telefone", txtTelefone) == false &&
                Auxiliares.verificaCampo("CNPJ", txtCNPJ) == false &&
                Auxiliares.verificaCampo("CEP", txtCEP) == false &&
                Auxiliares.verificaCampo("Número", txtNumero) == false &&
                Auxiliares.verificaCampo("Cidade", txtCidade) == false &&
                Auxiliares.verificaCampo("Produto", txtProduto) == false)
            {

                //Estrutura encadeiada para que cada item exiba sua própria mensagem

                if (Auxiliares.existe("fornecedor", "telefone", txtTelefone) == false)
                {

                    if (Auxiliares.existe("fornecedor", "cnpj", txtCNPJ) == false)
                    {

                        if (Auxiliares.existe("fornecedor", "numero", txtNumero) == false)
                        {

                            if (MessageBox.Show($"Nome do fornecedor: {txtNomedoFornecedor.Text}" +
                                  $"Endereço: {txtEndereco.Text}" +
                                  $"Telefone: {txtTelefone.Text}" +
                                  $"CNPJ: {txtCNPJ.Text}" +
                                  $"CEP: {txtCEP.Text}" +
                                  $"Número: {txtNumero.Text}" +
                                  $"Cidade: {txtCidade.Text}" +
                                  $"Produto: {txtProduto.Text}",
                                  "Confirme os dados que serão cadastrados.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                            {

                                string query = "insert into clientes (nome,endereco,telefone,cnpj,cep,numero,cidade,produto;)" +
                                $"values ('{txtNomedoFornecedor.Text}','{txtEndereco.Text}','{txtTelefone.Text}','{txtCNPJ.Text}'," +
                                $"'{txtCEP.Text}','{txtNumero.Text}','{txtCidade.Text}','{txtProduto.Text}';)";
                                Conexao.executaQuery(query);

                            }

                        }

                        else { MessageBox.Show("Insira outro Número", "Esse Número já está em uso!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                    else { MessageBox.Show("Insira outro cnpj", "Esse cnpj já está em uso!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else { MessageBox.Show("Insira outro telefone", "Esse telefone já existe!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

        }
    }
}
