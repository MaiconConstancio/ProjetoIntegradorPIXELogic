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
    public partial class PalcoGerenciamentoDeServicos : Form
    {
        public PalcoGerenciamentoDeServicos(string lb1, string lb2, string lb3, string lb4, string lb5, string lb6)
        {
            InitializeComponent();

            label1.Text = lb1;
            label2.Text = lb2;
            label3.Text = lb3;
            label4.Text = lb4;
            label5.Text = lb5;
            label6.Text = lb6;

        }

        private void PalcoGerenciamentoDeServicos_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            Conexao.executaQuery($"set SQL_SAFE_UPDATES = 0; delete from orcamentos where servico = '{label1.Text}';");

            RodaTodosForms.panel1.Controls.Clear();
            GerenciamentoDeServicos form = new GerenciamentoDeServicos();
            form.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(form);
            form.Show();

        }
    }
}
