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
    public partial class SuporteAoCliente : Form
    {
        public SuporteAoCliente()
        {
            InitializeComponent();
        }

        private void SuporteAoCliente_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer------------------------------------
            lblSuporteAoCliente.Parent = imgWallpaper;
            lblSuporteAoCliente.BackColor = Color.Transparent;

            lblAtendimento.Parent = imgWallpaper;
            lblAtendimento.BackColor = Color.Transparent;

            lblHorario.Parent = imgWallpaper;
            lblHorario.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer------------------------------------
        }
    }
}
