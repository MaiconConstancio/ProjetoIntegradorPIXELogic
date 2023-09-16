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
    public partial class EmissaoRelatorioFinanceiroProdutos : Form
    {
        public EmissaoRelatorioFinanceiroProdutos()
        {
            InitializeComponent();
        }

        private void EmissaoRelatorioFinanceiroProdutos_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in Conexao.executaQuery("select * from vendas;").Rows)
            {

                PalcoEmissaoRelatorioFinanceiroProduto palcoListaDeProdutos = new PalcoEmissaoRelatorioFinanceiroProduto(row["produto"].ToString(), row["nome_cliente"].ToString(), row["valor"].ToString());

                palcoListaDeProdutos.TopLevel = false;
                panel1.Controls.Add(palcoListaDeProdutos);
                palcoListaDeProdutos.Location = new Point(0, 0 + panel1.Height);
                palcoListaDeProdutos.Show();

            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            SagaoPrincipal sagaoPrincipal = new SagaoPrincipal();
            sagaoPrincipal.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(sagaoPrincipal);
            sagaoPrincipal.Show();

        }
    }
}
