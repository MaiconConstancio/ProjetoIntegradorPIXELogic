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
    public partial class GerenciamentoDeServicos : Form
    {
        public GerenciamentoDeServicos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            SelecionaQualCadastro selecionaQualCadastro = new SelecionaQualCadastro();
            selecionaQualCadastro.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(selecionaQualCadastro);
            selecionaQualCadastro.Show();

        }

        private void GerenciamentoDeServicos_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in Conexao.executaQuery("select * from orcamentos;").Rows)
            {

                PalcoGerenciamentoDeServicos palcoGerenciamento = new PalcoGerenciamentoDeServicos(row["servico"].ToString(), row["valor"].ToString(), row["nome_cliente"].ToString(), row["endereco"].ToString(),
                                                                                                   row["funcionario"].ToString(), row["estimativa_entrega"].ToString());

                palcoGerenciamento.TopLevel = false;
                panel1.Controls.Add(palcoGerenciamento);
                palcoGerenciamento.Location = new Point(0, 0 + panel1.Height);
                palcoGerenciamento.Show();

            }

        }

        private void btnNovoOrcamento_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            OrcamentoDeServicos orcamentoDeServicos = new OrcamentoDeServicos();
            orcamentoDeServicos.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(orcamentoDeServicos);
            orcamentoDeServicos.Show();

        }

        private void lblFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
