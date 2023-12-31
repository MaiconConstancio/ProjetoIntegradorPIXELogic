﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorPIXELogic
{
    public partial class SagaoPrincipal : Form
    {
        public SagaoPrincipal()
        {
            InitializeComponent();
        }

        private void SagaoPrincipal_Load(object sender, EventArgs e)
        {

            if (Conexao.executaQuery($"select * from usuario where login = '{Program.acesso}' and cargo = 'dono';").Rows.Count > 0 ||
                Conexao.executaQuery($"select * from usuario where login = '{Program.acesso}' and cargo = 'gerente';").Rows.Count > 0 ||
                Conexao.executaQuery($"select * from usuario where login = '{Program.acesso}' and cargo = 'desenvolvedor';").Rows.Count > 0)
            {

                Controls.Add(btnSalvar);

            }


            if (Conexao.executaQuery("select * from funcoes where nome = 'servicos' and habilitado_nao = true;").Rows.Count > 0 ||
                Conexao.executaQuery("select * from funcoes where nome = 'clientes' and habilitado_nao = true;").Rows.Count > 0 ||
                Conexao.executaQuery("select * from funcoes where nome = 'produtos' and habilitado_nao = true;").Rows.Count > 0 ||
                Conexao.executaQuery("select * from funcoes where nome = 'fornecedores' and habilitado_nao = true;").Rows.Count > 0 ||
                Conexao.executaQuery("select * from funcoes where nome = 'colaboradores' and habilitado_nao = true;").Rows.Count > 0)
            {

                btnCadastros.Location = new Point(0, 0 + panel1.Height);
                panel1.Controls.Add(btnCadastros);

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'vendas' and habilitado_nao = true;").Rows.Count > 0)
            {

                btnVendas.Location = new Point(0, 0 + panel1.Height);
                panel1.Controls.Add(btnVendas);

            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'relatorio de produtos' and habilitado_nao = true;").Rows.Count > 0)
            {


                btnRelatorioProdutos.Location = new Point(0, 0 + panel1.Height);
                panel1.Controls.Add(btnRelatorioProdutos);


            }

            if (Conexao.executaQuery("select * from funcoes where nome = 'relatorio de servicos' and habilitado_nao = true;").Rows.Count > 0)
            {

                btnRelatorioServicos.Location = new Point(0, 0 + panel1.Height);
                panel1.Controls.Add(btnRelatorioServicos);

            }


            if (Conexao.executaQuery("select * from funcoes where nome = 'suporte' and habilitado_nao = true;").Rows.Count > 0)
            {

                btnSuporte.Location = new Point(0, 0 + panel1.Height);
                panel1.Controls.Add(btnSuporte);


            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            MontagemPrograma montagemPrograma = new MontagemPrograma();
            montagemPrograma.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(montagemPrograma);
            montagemPrograma.Show();

        }

        private void btnCadastrosNovo_Click(object sender, EventArgs e)
        {

        }

        private void lblOrcamentoDeServicos_Click(object sender, EventArgs e)
        {

        }
    }
}
