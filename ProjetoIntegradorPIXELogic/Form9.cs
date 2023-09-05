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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            form5.Show();
            this.Close();

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {

            Form10 form10 = new Form10();
            form10.Show();
            this.Close();

        }

        private void btnServiço_Click(object sender, EventArgs e)
        {
            
            Form11 form11 = new Form11();
            form11.Show();
            this.Close();

        }
    }
}
