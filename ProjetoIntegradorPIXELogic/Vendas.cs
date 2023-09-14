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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer------------------------------------
            lblProduto.Parent = LogoComoWallpaper;
            lblProduto.BackColor = Color.Transparent;

            lblQuantidade.Parent = LogoComoWallpaper;
            lblQuantidade.BackColor = Color.Transparent;

            lblNomeDoCliente.Parent = LogoComoWallpaper;
            lblNomeDoCliente.BackColor = Color.Transparent;

            lblMetodoDePagamento.Parent = LogoComoWallpaper;
            lblMetodoDePagamento.BackColor = Color.Transparent;

            lblValor.Parent = LogoComoWallpaper;
            lblValor.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer------------------------------------
        }
    }
}
