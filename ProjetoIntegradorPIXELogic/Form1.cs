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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void Form1_Load(object sender, EventArgs e)
        {

            Lista lista = new Lista();
            lista.TopLevel = false;
            panel1.Controls.Add(lista);
            lista.Show();

        }
    }
}
