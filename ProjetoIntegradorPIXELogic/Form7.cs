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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        //funçoes



        //Eventos

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (Auxiliares.verificaCampo("Cliente", txtCliente) == false &&
                Auxiliares.verificaCampo("Endereço", txtEndereco) == false &&
                Auxiliares.verificaCampo("Telefone", txtTelefone) == false &&
                Auxiliares.verificaCampo("CPF", txtCPF) == false &&
                Auxiliares.verificaCampo("CEP", txtCEP) == false &&
                Auxiliares.verificaCampo("RG", txtRG) == false &&
                Auxiliares.verificaCampo("Cidade", txtCidade) == false)
            {

                //Estrutura encadeiada para que cada item exiba sua própria mensagem

                if (Auxiliares.existe("clientes", "cliente", txtCliente) == false)
                {

                    if (Auxiliares.existe("clientes", "telefone", txtTelefone) == false)
                    {

                        if (Auxiliares.existe("clientes", "cpf", txtCPF) == false)
                        {

                            if (Auxiliares.existe("clientes", "rg", txtRG) == false)
                            {

                                if (MessageBox.Show($"Cliente: {txtCliente.Text}" +
                                    $"Endereço: {txtEndereco.Text}" +
                                    $"Telefone: {txtTelefone.Text}" +
                                    $"CPF: {txtCPF.Text}" +
                                    $"CEP: {txtCEP.Text}" +
                                    $"RG: {txtRG.Text}" +
                                    $"Cidade: {txtCidade.Text}",
                                    "Confirme os dados que serão cadastrados.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                                {

                                    string query = "insert into clientes (cliente,endereco,telefone,cpf,cep,rg,cidade;)" +
                                    $"values ('{txtCliente.Text}','{txtEndereco.Text}','{txtTelefone.Text}','{txtCPF.Text}'," +
                                    $"'{txtCEP.Text}','{txtRG.Text}','{txtCidade.Text}';)";
                                    Conexao.executaQuery(query);

                                }

                            }

                            else { MessageBox.Show("Insira outro RG", "Esse RG já está em uso!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                        }

                        else { MessageBox.Show("Insira outro CPF", "Esse CPF já está em uso!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                    else { MessageBox.Show("Insira outro número de telefone", "Esse número já está em uso!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else { MessageBox.Show("Insira outro nome, ou acrescente abreviações.", "Esse nome já existe!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            form5.Show();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
