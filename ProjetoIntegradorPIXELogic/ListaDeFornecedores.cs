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
    public partial class ListaDeFornecedores : Form
    {
        public ListaDeFornecedores()
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
            CadastroDeFornecedores cadastroDeFornecedores = new CadastroDeFornecedores();
            cadastroDeFornecedores.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(cadastroDeFornecedores);
            cadastroDeFornecedores.Show();

        }

        private void ListaDeFornecedores_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in Conexao.executaQuery("select * from fornecedores;").Rows)
            {

                PalcoListaDeFornecedores palcoDaLista = new PalcoListaDeFornecedores(row["nome"].ToString(), row["endereco"].ToString(), row["telefone"].ToString(),
                                                             row["cnpj"].ToString(), row["cep"].ToString(), row["numero"].ToString(), row["cidade"].ToString());

                palcoDaLista.TopLevel = false;
                panel1.Controls.Add(palcoDaLista);
                palcoDaLista.Location = new Point(0, 0 + panel1.Height);
                palcoDaLista.Show();

            }

        }
    }
}
