using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            Conexao.executaQuery($"update usuario set primeiro_acesso = true where login = '{Program.acesso}'");

            if (chkBoxGerenciamentoServiços.Checked == true)
            {

                if (Conexao.executaQuery("select * from funcoes where nome = 'genciamento servico'").Rows.Count > 0)
                {

                    Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'gerenciamento servico';");

                }

                else { Conexao.executaQuery("insert into funcoes (nome,habilitado_nao) values ('gerenciamento servico', true)"); }

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'gerenciamento serviços';");

            }

            if (chkBoxClientes.Checked == true)
            {

                if (Conexao.executaQuery("select * from funcoes where nome = 'clientes'").Rows.Count == 0)
                {

                    Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'clientes';");

                }

                else { Conexao.executaQuery("insert into funcoes (nome,habilitado_nao) values ('clientes', true)"); }

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'clientes';");

            }

            if (chkBoxProdutos.Checked == true)
            {

                if (Conexao.executaQuery("select * from funcoes where nome = 'produtos'").Rows.Count == 0)
                {

                    Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'produtos';");

                }

                else { Conexao.executaQuery("insert into funcoes (nome,habilitado_nao) values ('produtos', true)"); }

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'produtos';");

            }

            if (chkBoxFornecedores.Checked == true)
            {

                if (Conexao.executaQuery("select * from funcoes where nome = 'fornecedores'").Rows.Count > 0)
                {

                    Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'fornecedores';");

                }

                else { Conexao.executaQuery("insert into funcoes (nome,habilitado_nao) values ('fornecedores', true)"); }

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'fornecedores';");

            }

            if (chkBoxColaboradores.Checked == true)
            {

                if (Conexao.executaQuery("select * from funcoes where nome = 'colaboradores'").Rows.Count > 0)
                {

                    Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'colaboradores';");

                }

                else { Conexao.executaQuery("insert into funcoes (nome,habilitado_nao) values ('colaboradores', true)"); }

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'colaboradores';");

            }

            if (chkBoxEmissaoRelatoriosFinanceiros.Checked == true)
            {

                if (Conexao.executaQuery("select * from funcoes where nome = 'relatorio de produtos'").Rows.Count > 0)
                {

                    Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'relatorio de produtos';");

                }

                else { Conexao.executaQuery("insert into funcoes (nome,habilitado_nao) values ('relatorio de produtos', true)"); }

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'relatorio de produtos';");

            }

            if (checkBox1.Checked == true)
            {

                if (Conexao.executaQuery("select * from funcoes where nome = 'relatorio de servicos'").Rows.Count > 0)
                {

                    Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'relatorio de servicos';");

                }

                else { Conexao.executaQuery("insert into funcoes (nome,habilitado_nao) values ('relatorio de servicos', true)"); }

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'relatorio de servicos';");

            }

            if (chkBoxVendas.Checked == true)
            {

                if (Conexao.executaQuery("select * from funcoes where nome = 'vendas'").Rows.Count > 0)
                {

                    Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'vendas';");

                }

                else { Conexao.executaQuery("insert into funcoes (nome,habilitado_nao) values ('vendas', true)"); }

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'vendas';");

            }

            if (chkBoxSuporteAoCliente.Checked == true)
            {

                if (Conexao.executaQuery("select * from funcoes where nome = 'suporte'").Rows.Count > 0)
                {

                    Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'suporte';");

                }

                else { Conexao.executaQuery("insert into funcoes (nome,habilitado_nao) values ('suporte', true)"); }

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'suporte';");

            }

            RodaTodosForms.panel1.Controls.Clear();
            SagaoPrincipal sagaoPrincipal = new SagaoPrincipal();
            sagaoPrincipal.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(sagaoPrincipal);
            sagaoPrincipal.Show();

        }

            if (Conexao.executaQuery("select * from funcoes where nome = 'servicos' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxGerenciamentoServiços.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'clientes' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxClientes.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'produtos' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxProdutos.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'fornecedores' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxFornecedores.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'colaboradores' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxColaboradores.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'vendas' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxVendas.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'relatorio de produtos' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxEmissaoRelatoriosFinanceiros.Checked = true;

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'relatorio de servicos' and habilitado_nao = true;").Rows.Count > 0)
            {

                checkBox1.Checked = true;

            }


            if (Conexao.executaQuery("select * from funcoes where nome = 'suporte' and habilitado_nao = true;").Rows.Count > 0)
            {

                chkBoxSuporteAoCliente.Checked = true;

            }

        }
    }
}
