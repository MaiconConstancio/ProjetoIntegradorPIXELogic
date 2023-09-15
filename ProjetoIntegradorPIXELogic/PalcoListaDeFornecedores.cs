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
    public partial class PalcoListaDeFornecedores : Form
    {
        public PalcoListaDeFornecedores(string lb1, string lb2, string lb3, string lb4, string lb5, string lb6, string lb7)
        {
            InitializeComponent();

            label1.Text = lb1;
            label2.Text = lb2;
            label3.Text = lb3;
            label4.Text = lb4;
            label5.Text = lb5;
            label6.Text = lb6;
            label7.Text = lb7;
        }

        private void PalcoListaDeFornecedores_Load(object sender, EventArgs e)
        {



        }
    }
}
