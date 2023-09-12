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

            if (Funcoes.campoVazio("Nome", txtNome) == false && Funcoes.campoVazioCombo("Serviço", comboBox1) == false &&
                Funcoes.campoVazioCombo("Valor", comboBox2) == false && Funcoes.campoVazio("Endereço", txtEndereco) == false &&
                Funcoes.campoVazio("Funcionario", txtfuncionario) == false && Funcoes.campoVazio("Estimativa de entrega", txtEstimativa) == false)
            {


                if (Conexao.executaQuery($"select * from orcamentos where nome_cliente = '{txtNome.Text}'").Rows.Count > 0)
                {

                    if (MessageBox.Show("Deseja cadastrar outro item no nome deste cliente? ?", "Confirmar venda!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        if (MessageBox.Show($"Nome: {txtNome.Text}\n\n" +
                            $"Serviço: {comboBox1.Text}\n\n" +
                            $"Valor:  {comboBox2.Text}\n\n" +
                            $"CNPJ: {txtEndereco.Text}\n\n" +
                            $"Funcionario: {txtfuncionario.Text}\n\n" +
                            $"Estimativa de entrega: {txtEstimativa.Text}\n\n",
                            "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {

                            string query = $"insert into orcamentos (nome_cliente,servico,valor,endereco,funcionario,estimativa_entrega) values " +
                                $"('{txtNome.Text}','{comboBox1.Text}','{comboBox2.Text}','{txtEndereco.Text}','{txtfuncionario.Text}','{txtEstimativa.Text}');";
                            Conexao.executaQuery(query);

                            txtNome.Clear();
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                            txtEndereco.Clear();
                            txtfuncionario.Clear();
                            txtEstimativa.Clear();

                        }

                    }

                    return;

                }

                if (MessageBox.Show($"Nome: {txtNome.Text}\n\n" +
                            $"Serviço: {comboBox1.Text}\n\n" +
                            $"Valor:  {comboBox2.Text}\n\n" +
                            $"CNPJ: {txtEndereco.Text}\n\n" +
                            $"Funcionario: {txtfuncionario.Text}\n\n" +
                            $"Estimativa de entrega: {txtEstimativa.Text}\n\n",
                            "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    string query = $"insert into orcamentos (nome_cliente,servico,valor,endereco,funcionario,estimativa_entrega) values " +
                        $"('{txtNome.Text}','{comboBox1.Text}','{comboBox2.Text}','{txtEndereco.Text}','{txtfuncionario.Text}','{txtEstimativa.Text}');";
                    Conexao.executaQuery(query);

                    txtNome.Clear();
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    txtEndereco.Clear();
                    txtfuncionario.Clear();
                    txtEstimativa.Clear();

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

        private void Cadastro_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in Conexao.executaQuery("select nome_servico from servicos;").Rows)
            {

                comboBox1.Items.Add(row["nome_servico"].ToString());

            }

            foreach (DataRow row in Conexao.executaQuery("select valor from servicos;").Rows)
            {

                comboBox2.Items.Add(row["valor"].ToString());

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            Form1.panel1.Controls.Clear();
            form2.TopLevel = false;
            Form1.panel1.Controls.Add(form2);
            form2.Show();

        }
    }
}
