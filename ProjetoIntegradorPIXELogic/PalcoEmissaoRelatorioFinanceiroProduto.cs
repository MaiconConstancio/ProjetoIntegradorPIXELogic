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
    public partial class PalcoEmissaoRelatorioFinanceiroProduto : Form
    {
        public PalcoEmissaoRelatorioFinanceiroProduto(string lb1, string lb2, string lb3)
        {
            InitializeComponent();

            label1.Text = lb1;
            label2.Text = lb2;
            label3.Text = lb3;

        }

        private void PalcoEmissaoRelatorioFinanceiroProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
