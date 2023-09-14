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
    public partial class CadastroDeServicos : Form
    {
        public CadastroDeServicos()
        {
            InitializeComponent();
        }

        private void CadastroDeServicos_Load(object sender, EventArgs e)
        {
            lblCadastrodeServicos.Parent = LogoComoWallpaper;
            lblCadastrodeServicos.BackColor = Color.Transparent;

            lblNomedoServico.Parent = LogoComoWallpaper;
            lblNomedoServico.BackColor = Color.Transparent;
            
            lblValor.Parent = LogoComoWallpaper;
            lblValor.BackColor = Color.Transparent;
        }
    }
}
