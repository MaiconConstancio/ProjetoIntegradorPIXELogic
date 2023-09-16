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
    public partial class EmissaoRelatorioFinanceiroservico : Form
    {
        public EmissaoRelatorioFinanceiroservico()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            RodaTodosForms.panel1.Controls.Clear();
            SagaoPrincipal sagaoPrincipal = new SagaoPrincipal();
            sagaoPrincipal.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(sagaoPrincipal);
            sagaoPrincipal.Show();

        }

        private void EmissaoRelatorioFinanceiroservico_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in Conexao.executaQuery("select * from orcamentos;").Rows)
            {

                PalcoEmissaoRelatorioFinanceiroServicos palcoListaDeProdutos = new PalcoEmissaoRelatorioFinanceiroServicos(row["servico"].ToString(), row["nome_cliente"].ToString(), row["valor"].ToString());

                palcoListaDeProdutos.TopLevel = false;
                panel1.Controls.Add(palcoListaDeProdutos);
                palcoListaDeProdutos.Location = new Point(0, 0 + panel1.Height);
                palcoListaDeProdutos.Show();

            }

        }
    }
}
