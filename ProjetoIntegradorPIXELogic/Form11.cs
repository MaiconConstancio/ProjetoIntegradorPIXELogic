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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            Form9 form9 = new Form9();
            form9.Show();
            this.Close();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Auxiliares.verificaCampo("Código do serviço",txtCodigoServico) == false &&
                Auxiliares.verificaCampo("Nome do produto", txtNomeProduto) == false &&
                Auxiliares.verificaCampo("Valor", txtValor) == false &&
                Auxiliares.verificaCampo("Tempo para terminaro", txtTempoEntrega) == false )
            {

                if (comboBoxStatus.Text != "")
                {

                    if (MessageBox.Show($"Código de serviço: {txtCodigoServico.Text}\n" +
                        $"Nome do produto: {txtNomeProduto.Text}\n" +
                        $"Valor: {txtValor.Text}\n" +
                        $"Tempo para terminar: {txtTempoEntrega.Text}\n" +
                        $"Status de produção: {comboBoxStatus.Text}","Confirme os dados!",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
                    {

                        string query = "insert into servicos (alguma coisa, alguma coisa,valor,alguma coisa,alguma coisa) " +
                       $"values ('{txtCodigoServico.Text}','{txtNomeProduto.Text}','{txtValor.Text}'," +
                       $"'{txtTempoEntrega.Text}','{comboBoxStatus.Text}';)";
                        Conexao.executaQuery(query);

                    }

                }

                else { MessageBox.Show("Por favor informe o status do serviço!","Campo vázio",MessageBoxButtons.OK,MessageBoxIcon.Error)}

            }

        }
    }
}
