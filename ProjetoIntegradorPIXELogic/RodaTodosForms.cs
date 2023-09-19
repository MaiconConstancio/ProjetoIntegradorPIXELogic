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
    public partial class RodaTodosForms : Form
    {
        public RodaTodosForms()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            TelaLoginPaginaInicial telaLoginPaginaInicial = new TelaLoginPaginaInicial();
            telaLoginPaginaInicial.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(telaLoginPaginaInicial);
            telaLoginPaginaInicial.Show();


        }

        private void RodaTodosForms_Load(object sender, EventArgs e)
        {

        }
    }
}
