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
    public partial class CadastroDeCliente : Form
    {
        public CadastroDeCliente()
        {
            InitializeComponent();
        }

        private void CadastroDeCliente_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer------------------------------------
            lblCliente.Parent = LogoComoWallpaper;
            lblCliente.BackColor = Color.Transparent;

            lblEndereco.Parent = LogoComoWallpaper;
            lblEndereco.BackColor = Color.Transparent;

            lblTelefone.Parent = LogoComoWallpaper;
            lblTelefone.BackColor = Color.Transparent;

            lblCPF.Parent = LogoComoWallpaper;
            lblCPF.BackColor = Color.Transparent;

            lblCEP.Parent = LogoComoWallpaper;
            lblCEP.BackColor = Color.Transparent;

            lblNumero.Parent = LogoComoWallpaper;
            lblNumero.BackColor = Color.Transparent;

            lblCidade.Parent = LogoComoWallpaper;
            lblCidade.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer------------------------------------
        }
    }
}
