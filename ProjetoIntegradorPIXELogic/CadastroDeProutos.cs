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
    public partial class CadastroDeProutos : Form
    {
        public CadastroDeProutos()
        {
            InitializeComponent();
        }

        private void CadastroDeProutos_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer------------------------------------
            lblCadastrodeprodutos.Parent = LogoComoWallpaper;
            lblCadastrodeprodutos.BackColor = Color.Transparent;

            lblNome.Parent = LogoComoWallpaper;
            lblNome.BackColor = Color.Transparent;

            lblFornecedor.Parent = LogoComoWallpaper;
            lblFornecedor.BackColor = Color.Transparent;

            lblQuantidade.Parent = LogoComoWallpaper;
            lblQuantidade.BackColor = Color.Transparent;

            lblValor.Parent = LogoComoWallpaper;
            lblValor.BackColor = Color.Transparent;

            lblVencimento.Parent = LogoComoWallpaper;
            lblVencimento.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer------------------------------------
        }
    }
}
