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
    public partial class ListaDeColaboradores : Form
    {
        public ListaDeColaboradores()
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

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            CadastroDeColaboradores cadastroDeColaboradores = new CadastroDeColaboradores();
            cadastroDeColaboradores.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(cadastroDeColaboradores);
            cadastroDeColaboradores.Show();

        }

        private void ListaDeColaboradores_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in Conexao.executaQuery("select * from usuario;").Rows)
            {

                PalcoListaDeColaboradores palcoDaLista = new PalcoListaDeColaboradores(row["nome"].ToString(), row["cargo"].ToString(), row["login"].ToString(),
                                                             row["senha"].ToString());

                palcoDaLista.TopLevel = false;
                panel1.Controls.Add(palcoDaLista);
                palcoDaLista.Location = new Point(0, 0 + panel1.Height);
                palcoDaLista.Show();

            }

        }
    }
}
