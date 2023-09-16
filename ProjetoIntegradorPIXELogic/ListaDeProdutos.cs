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
    public partial class ListaDeProdutos : Form
    {
        public ListaDeProdutos()
        {
            InitializeComponent();
        }


        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            RodaTodosForms.panel1.Controls.Clear();
            SelecionaQualCadastro selecionaQualCadastro = new SelecionaQualCadastro();
            selecionaQualCadastro.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(selecionaQualCadastro);
            selecionaQualCadastro.Show();
            
        }

        private void ListaDeProdutos_Load(object sender, EventArgs e)
        {



            foreach (DataRow row in Conexao.executaQuery("select * from produtos;").Rows)
            {

                RodaTodosForms.panel1.Controls.Clear();
                PalcoListaDeProdutos palcoListaDeProdutos = new PalcoListaDeProdutos(row["nome"].ToString(), row["fornecedor"].ToString(), row["quantidade"].ToString(),
                                                                                     row["valor"].ToString(), row["vencimento"].ToString());

                palcoListaDeProdutos.TopLevel = false;
                RodaTodosForms.panel1.Controls.Add(palcoListaDeProdutos);
                palcoListaDeProdutos.Show();

            }

        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            CadastroDeProdutos cadastroDeProdutos = new CadastroDeProdutos();
            cadastroDeProdutos.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(cadastroDeProdutos);
            cadastroDeProdutos.Show();

        }
    }
}
