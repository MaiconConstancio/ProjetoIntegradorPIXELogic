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
    public partial class MontagemPrograma : Form
    {
        public MontagemPrograma()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (chkBoxGerenciamentoServiços.Checked == true)
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'função de serviços';");

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'função de serviços';");

            }

            if (chkBoxClientes.Checked == true)
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'função de clientes';");

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'função de clientes';");

            }

            if (chkBoxProdutos.Checked == true)
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'função de produtos';");

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'função de produtos';");

            }

            if (chkBoxFornecedores.Checked == true)
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'função de fornecedores';");

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'função de fornecedores';");

            }

            if (chkBoxColaboradores.Checked == true)
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'função de colaboradores';");

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'função de colaboradores';");

            }

            if (chkBoxEmissaoRelatoriosFinanceiros.Checked == true)
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'função de relatorio_produtos';");

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'função de relatorio_produtos';");

            }

            /*if (chkBoxEmissaoRelatoriosFinanceiros.Checked == true)
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'função de relatorio_serviços';");

            }*/

            if (chkBoxVendas.Checked == true)
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'função de vendas';");

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'função de vendas';");

            }

            if (chkBoxSuporteAoCliente.Checked == true)
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'função de suporte';");

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'função de suporte';");

            }

            RodaTodosForms.panel1.Controls.Clear();
            SagaoPrincipal sagaoPrincipal = new SagaoPrincipal();
            sagaoPrincipal.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(sagaoPrincipal);
            sagaoPrincipal.Show();

        }

        private void MontagemPrograma_Load(object sender, EventArgs e)
        {

            if (Conexao.executaQuery("select * from funcoes where nome = 'função de serviços' and habilitado_nao = true;").Rows.Count > 0 )
            {

                chkBoxGerenciamentoServiços.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'função de clientes' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxClientes.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'função de produtos' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxProdutos.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'função de fornecedores' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxFornecedores.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'função de colaboradores' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxColaboradores.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'função de vendas' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxVendas.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'função de relatorio_produtos' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxEmissaoRelatoriosFinanceiros.Checked = true;

            }

            /*if (Conexao.executaQuery("select * from funcoes where nome = 'função de relatorio_serviços' and habilitado_nao = true;").Rows.Count > 0)
            {*/



            /*}*/


            if (Conexao.executaQuery("select * from funcoes where nome = 'função de suporte' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxSuporteAoCliente.Checked = true;

            }

        }
    }
}
