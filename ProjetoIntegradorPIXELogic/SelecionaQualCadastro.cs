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
    public partial class SelecionaQualCadastro : Form
    {
        public SelecionaQualCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton24_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            GerenciamentoDeServicos gerenciamentoDeServicos = new GerenciamentoDeServicos();
            gerenciamentoDeServicos.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(gerenciamentoDeServicos);
            gerenciamentoDeServicos.Show();

        }

        private void wilBitButton23_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            GerenciamentoDeClientes gerenciamentoDeClientes = new GerenciamentoDeClientes();
            gerenciamentoDeClientes.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(gerenciamentoDeClientes);
            gerenciamentoDeClientes.Show();

        }

        private void SelecionaQualCadastro_Load(object sender, EventArgs e)
        {

            //---------------------------Setor do Designer-----------------------------------
            lblEscolhaQualCadastroDesejaRealizar.Parent = LogoComoWallpaper;
            lblEscolhaQualCadastroDesejaRealizar.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer----------------------------

            if (Conexao.executaQuery("select * from funcoes where nome = 'servicos' and habilitado_nao = true;").Rows.Count > 0)
            {

                Controls.Add(btnServico);

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'clientes' and habilitado_nao = true;").Rows.Count > 0)
            {

                Controls.Add(btnClientes);

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'produtos' and habilitado_nao = true;").Rows.Count > 0)
            {

                Controls.Add(btnProdutos);

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'fornecedores' and habilitado_nao = true;").Rows.Count > 0)
            {

                Controls.Add(btnFornecedores);

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'colaboradores' and habilitado_nao = true;").Rows.Count > 0)
            {

                Controls.Add(btnFuncionarios);

            }

        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            ListaDeColaboradores listaDeColaboradores = new ListaDeColaboradores();
            listaDeColaboradores.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(listaDeColaboradores);
            listaDeColaboradores.Show();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            SagaoPrincipal sagaoPrincipal = new SagaoPrincipal();
            sagaoPrincipal.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(sagaoPrincipal);
            sagaoPrincipal.Show();

        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            ListaDeFornecedores listaDeFornecedores = new ListaDeFornecedores();
            listaDeFornecedores.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(listaDeFornecedores);
            listaDeFornecedores.Show();

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            ListaDeProdutos listaDeProdutos = new ListaDeProdutos();
            listaDeProdutos.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(listaDeProdutos);
            listaDeProdutos.Show();

        }

        private void LogoComoWallpaper_Click(object sender, EventArgs e)
        {



        }
    }
}
