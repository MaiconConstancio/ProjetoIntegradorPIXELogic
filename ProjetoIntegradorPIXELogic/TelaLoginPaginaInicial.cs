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
    public partial class TelaLoginPaginaInicial : Form
    {
        public TelaLoginPaginaInicial()
        {
            InitializeComponent();
        }

        private void TelaLoginPaginaInicial_Load(object sender, EventArgs e)
        {
            imgLOGOloginPrincipal.Parent = imgWallpaperLoginPrincipal;
            imgLOGOloginPrincipal.BackColor = Color.Transparent;
        }
    }
}
