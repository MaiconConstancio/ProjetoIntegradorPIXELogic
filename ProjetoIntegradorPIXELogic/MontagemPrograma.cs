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



        private void MontagemPrograma_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer-----------------------------------
            lblTituloMontaPrograma.Parent = LogoComoWallpaper;
            lblTituloMontaPrograma.BackColor = Color.Transparent;

            imgCliente.Parent = LogoComoWallpaper;
            imgCliente.BackColor = Color.Transparent;

            lblCliente.Parent = LogoComoWallpaper;
            lblCliente.BackColor = Color.Transparent;

            imgFornecedor.Parent = LogoComoWallpaper;
            imgFornecedor.BackColor = Color.Transparent;

            lblFornecedor.Parent = LogoComoWallpaper;
            lblFornecedor.BackColor = Color.Transparent;

            imgColaboradores.Parent = LogoComoWallpaper;
            imgColaboradores.BackColor = Color.Transparent;

            lblColaboradores.Parent = LogoComoWallpaper;
            lblColaboradores.BackColor = Color.Transparent;

            imgProdutos.Parent = LogoComoWallpaper;
            imgProdutos.BackColor = Color.Transparent;

            lblProdutos.Parent = LogoComoWallpaper;
            lblProdutos.BackColor = Color.Transparent;

            imgRelatorioProdutos.Parent = LogoComoWallpaper;
            imgRelatorioProdutos.BackColor = Color.Transparent;

            lblRelatorioProdutos.Parent = LogoComoWallpaper;
            lblRelatorioProdutos.BackColor = Color.Transparent;

            imgRelatorioServicos.Parent = LogoComoWallpaper;
            imgRelatorioServicos.BackColor = Color.Transparent;

            lblRelatorioServicos.Parent = LogoComoWallpaper;
            lblRelatorioServicos.BackColor = Color.Transparent;

            imgSuport.Parent = LogoComoWallpaper;
            imgSuport.BackColor = Color.Transparent;

            lblSuport.Parent = LogoComoWallpaper;
            lblSuport.BackColor = Color.Transparent;

            imgGerenciamentoServicos.Parent = LogoComoWallpaper;
            imgGerenciamentoServicos.BackColor = Color.Transparent;

            lblGerenciamentoServicos.Parent = LogoComoWallpaper;
            lblGerenciamentoServicos.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer----------------------------




            if (Conexao.executaQuery("select * from funcoes where nome = 'gerenciamento servico' and habilitado_nao = true;").Rows.Count > 0)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Conexao.executaQuery($"update usuario set primeiro_acesso = true where login = '{Program.acesso}'");

            if (chkBoxGerenciamentoServiços.Checked == true)
            {

                if (Conexao.executaQuery("select * from funcoes where nome = 'gerenciamento servico'").Rows.Count > 0)
                {

                    Conexao.executaQuery("update funcoes set habilitado_nao = true where nome = 'gerenciamento servico';");

                }

                else { Conexao.executaQuery("insert into funcoes (nome,habilitado_nao) values ('gerenciamento servico', true)"); }

            }

            else
            {

                Conexao.executaQuery("update funcoes set habilitado_nao = false where nome = 'gerenciamento servico';");

            }

            if (chkBoxClientes.Checked == true)
            {

                if (Conexao.executaQuery("select * from funcoes where nome = 'clientes';").Rows.Count > 0)
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

                if (Conexao.executaQuery("select * from funcoes where nome = 'produtos'").Rows.Count > 0)
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

        private void imgSuport_Click(object sender, EventArgs e)
        {
            if (chkBoxSuporteAoCliente.Checked)
            {
                chkBoxSuporteAoCliente.Checked = false;
            }
            else
            {
                chkBoxSuporteAoCliente.Checked = true;
            }
        }

        private void lblSuport_Click(object sender, EventArgs e)
        {

            if (chkBoxSuporteAoCliente.Checked)
            {
                chkBoxSuporteAoCliente.Checked = false;
            }
            else
            {
                chkBoxSuporteAoCliente.Checked = true;
            }
        }

        private void imgGerenciamentoServicos_Click(object sender, EventArgs e)
        {
            if (chkBoxGerenciamentoServiços.Checked)
            {
                chkBoxGerenciamentoServiços.Checked = false;
            }
            else
            {
                chkBoxGerenciamentoServiços.Checked = true;
            }
        }

        private void lblGerenciamentoServicos_Click(object sender, EventArgs e)
        {
            if (chkBoxGerenciamentoServiços.Checked)
            {
                chkBoxGerenciamentoServiços.Checked = false;
            }
            else
            {
                chkBoxGerenciamentoServiços.Checked = true;
            }
        }

        private void imgRelatorioServicos_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void lblRelatorioServicos_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void imgRelatorioProdutos_Click(object sender, EventArgs e)
        {

            if (chkBoxEmissaoRelatoriosFinanceiros.Checked)
            {
                chkBoxEmissaoRelatoriosFinanceiros.Checked = false;
            }
            else
            {
                chkBoxEmissaoRelatoriosFinanceiros.Checked = true;
            }
        }

        private void lblRelatorioProdutos_Click(object sender, EventArgs e)
        {
            if (chkBoxEmissaoRelatoriosFinanceiros.Checked)
            {
                chkBoxEmissaoRelatoriosFinanceiros.Checked = false;
            }
            else
            {
                chkBoxEmissaoRelatoriosFinanceiros.Checked = true;
            }
        }

        private void imgProdutos_Click(object sender, EventArgs e)
        {
            if (chkBoxProdutos.Checked)
            {
                chkBoxProdutos.Checked = false;
            }
            else
            {
                chkBoxProdutos.Checked = true;
            }
        }

        private void lblProdutos_Click(object sender, EventArgs e)
        {
            if (chkBoxProdutos.Checked)
            {
                chkBoxProdutos.Checked = false;
            }
            else
            {
                chkBoxProdutos.Checked = true;
            }
        }

        private void imgColaboradores_Click(object sender, EventArgs e)
        {
            if (chkBoxColaboradores.Checked)
            {
                chkBoxColaboradores.Checked = false;
            }
            else
            {
                chkBoxColaboradores.Checked = true;
            }
        }

        private void lblColaboradores_Click(object sender, EventArgs e)
        {
            if (chkBoxColaboradores.Checked)
            {
                chkBoxColaboradores.Checked = false;
            }
            else
            {
                chkBoxColaboradores.Checked = true;
            }
        }

        private void imgFornecedor_Click(object sender, EventArgs e)
        {
            if (chkBoxFornecedores.Checked)
            {
                chkBoxFornecedores.Checked = false;
            }
            else
            {
                chkBoxFornecedores.Checked = true;
            }
        }

        private void lblFornecedor_Click(object sender, EventArgs e)
        {
            if (chkBoxFornecedores.Checked)
            {
                chkBoxFornecedores.Checked = false;
            }
            else
            {
                chkBoxFornecedores.Checked = true;
            }
        }

        private void imgVenda_Click(object sender, EventArgs e)
        {
            if (chkBoxVendas.Checked)
            {
                chkBoxVendas.Checked = false;
            }
            else
            {
                chkBoxVendas.Checked = true;
            }
        }

        private void lblVenda_Click(object sender, EventArgs e)
        {
            if (chkBoxVendas.Checked)
            {
                chkBoxVendas.Checked = false;
            }
            else
            {
                chkBoxVendas.Checked = true;
            }
        }

        private void imgCliente_Click(object sender, EventArgs e)
        {
            if (chkBoxClientes.Checked)
            {
                chkBoxClientes.Checked = false;
            }
            else
            {
                chkBoxClientes.Checked = true;
            }
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {
            if (chkBoxClientes.Checked)
            {
                chkBoxClientes.Checked = false;
            }
            else
            {
                chkBoxClientes.Checked = true;
            }
        }
    }


}
