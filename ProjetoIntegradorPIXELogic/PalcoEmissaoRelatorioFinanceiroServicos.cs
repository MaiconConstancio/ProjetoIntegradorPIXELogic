﻿using System;
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
    public partial class PalcoEmissaoRelatorioFinanceiroServicos : Form
    {
        public PalcoEmissaoRelatorioFinanceiroServicos(string lb1, string lb2, string lb3)
        {
            InitializeComponent();

            label1.Text = lb1;
            label2.Text = lb2;
            label3.Text = lb3;

        }

        private void PalcoEmissaoRelatorioFinanceiroServicos_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            Conexao.executaQuery($"set SQL_SAFE_UPDATES = 0; delete from orcamentos where servico = '{label1.Text}';");

            RodaTodosForms.panel1.Controls.Clear();
            EmissaoRelatorioFinanceiroservico form = new EmissaoRelatorioFinanceiroservico();
            form.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(form);
            form.Show();

        }
    }
}
