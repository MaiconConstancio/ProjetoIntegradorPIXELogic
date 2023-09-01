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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCerto_Click(object sender, EventArgs e)
        {

            Form5 areaTrabalho = new Form5();
            areaTrabalho.Show();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
