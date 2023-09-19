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

            //---------------------------FIM do Setor do Designer----------------------------

            if (Conexao.executaQuery("select * from funcoes where nome = 'gerenciamento servico' and habilitado_nao = true;").Rows.Count > 0)
            {

                if (panel1.Controls.Count == 0)
                {

                    panel1.Controls.Add(btnServico);
                    btnServico.Location = new Point(panel1.Width - 129, 0);

                }

                else
                {

                    panel1.Controls.Add(btnServico);
                    btnServico.Location = new Point(panel1.Width, 0);

                }

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'clientes' and habilitado_nao = true;").Rows.Count > 0)
            {

                if (panel1.Controls.Count == 0)
                {

                    panel1.Controls.Add(btnClientes);
                    btnClientes.Location = new Point(panel1.Width - 129, 0);

                }

                else
                {

                    panel1.Controls.Add(btnClientes);
                    btnClientes.Location = new Point(panel1.Width, 0);

                }

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'produtos' and habilitado_nao = true;").Rows.Count > 0)
            {

                if (panel1.Controls.Count == 0)
                {

                    panel1.Controls.Add(btnProdutos);
                    btnProdutos.Location = new Point(panel1.Width - 129, 0);

                }

                else
                {

                    panel1.Controls.Add(btnProdutos);
                    btnProdutos.Location = new Point(panel1.Width, 0);

                }

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'fornecedores' and habilitado_nao = true;").Rows.Count > 0)
            {

                if (panel1.Controls.Count == 0)
                {

                    panel1.Controls.Add(btnFornecedores);
                    btnFornecedores.Location = new Point(panel1.Width - 129, 0);

                }

                else
                {

                    panel1.Controls.Add(btnFornecedores);
                    btnFornecedores.Location = new Point(panel1.Width, 0);

                }

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'colaboradores' and habilitado_nao = true;").Rows.Count > 0)
            {

                if (panel1.Controls.Count == 0)
                {

                    panel1.Controls.Add(btnFuncionarios);
                    btnFuncionarios.Location = new Point(panel1.Width - 129, 0);

                }

                else
                {

                    panel1.Controls.Add(btnFuncionarios);
                    btnFuncionarios.Location = new Point(panel1.Width, 0);

                }

            }

            panel1.Location = new Point(this.Width / 2 - panel1.Width / 2, 215);

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
