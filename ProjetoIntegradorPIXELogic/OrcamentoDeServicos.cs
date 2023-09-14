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
    public partial class OrcamentoDeServicos : Form
    {
        public OrcamentoDeServicos()
        {
            InitializeComponent();
        }

        private void OrcamentoDeServicos_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer------------------------------------
            lblOrcamentoDeServicos.Parent = LogoComoWallpaper;
            lblOrcamentoDeServicos.BackColor = Color.Transparent;

            lblNomeDoCliente.Parent = LogoComoWallpaper;
            lblNomeDoCliente.BackColor = Color.Transparent;

            lblServico.Parent = LogoComoWallpaper;
            lblServico.BackColor = Color.Transparent;

            lblValor.Parent = LogoComoWallpaper;
            lblValor.BackColor = Color.Transparent;

            lblEndereco.Parent = LogoComoWallpaper;
            lblEndereco.BackColor = Color.Transparent;

            lblFuncionario.Parent = LogoComoWallpaper;
            lblFuncionario.BackColor = Color.Transparent;

            lblPrazoDeEntrega.Parent = LogoComoWallpaper;
            lblPrazoDeEntrega.BackColor = Color.Transparent;

            lblCidade.Parent = LogoComoWallpaper;
            lblCidade.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer------------------------------------
        }

        private void maskPrazoDeEntrega_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //maskPrazoDeEntrega.SelectionStart = 0;
        }
    }
}
