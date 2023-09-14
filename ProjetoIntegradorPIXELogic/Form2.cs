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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Conexao.executaQuery($"select * from servicos where nome_servico = '{txtNome.Text}'").Rows.Count > 0)
            {

                if (MessageBox.Show("Deseja substituir o valor deste item ?", "item repetido!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    if (MessageBox.Show($"Nome do serviço: {txtNome.Text}\n\n" +
                        $"Valor: {txtValor.Text}", "Confirme os dados!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        Conexao.executaQuery($"update servicos set valor = '{txtValor.Text}' where nome_servico = '{txtNome.Text}'");

                        txtNome.Clear();
                        txtValor.Clear();

                    }

                }

                return;

            }

            if (MessageBox.Show($"Nome do serviço: {txtNome.Text}\n\n" +
                        $"Valor: {txtValor.Text}", "Confirme os dados!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                Conexao.executaQuery($"insert into servicos (nome_servico,valor) values ('{txtNome.Text}','{txtValor.Text}')");

                txtNome.Clear();
                txtValor.Clear();

            }



        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            Cadastro cadastro = new Cadastro();
            Form1.panel1.Controls.Clear();
            cadastro.TopLevel = false;
            Form1.panel1.Controls.Add(cadastro);
            cadastro.Show();

        }
    }
}
