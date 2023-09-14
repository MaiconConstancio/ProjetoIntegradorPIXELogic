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
    public partial class CadastroDeFornecedores : Form
    {
        public CadastroDeFornecedores()
        {
            InitializeComponent();
        }

        private void lblNovaSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtNovoLogin__TextChanged(object sender, EventArgs e)
        {
        }

        private void CadastroDeFornecedores_Load(object sender, EventArgs e)
        {
            //--------------------------- Setor do Designer -------------------------------------
            lblEscolhaSeusColaboradoresESuasCredenciais.Parent = LogoComoWallpaper;
            lblEscolhaSeusColaboradoresESuasCredenciais.BackColor = Color.Transparent;

            lblFornecedor.Parent = LogoComoWallpaper;
            lblFornecedor.BackColor = Color.Transparent;

            lblEndereco.Parent = LogoComoWallpaper;
            lblEndereco.BackColor = Color.Transparent;

            lblTelefone.Parent = LogoComoWallpaper;
            lblTelefone.BackColor = Color.Transparent;

            lblCNPJ.Parent = LogoComoWallpaper;
            lblCNPJ.BackColor = Color.Transparent;

            lblCEP.Parent = LogoComoWallpaper;
            lblCEP.BackColor = Color.Transparent;

            lblNumero.Parent = LogoComoWallpaper;
            lblNumero.BackColor = Color.Transparent;

            lblCidade.Parent = LogoComoWallpaper;
            lblCidade.BackColor = Color.Transparent;
            //--------------------------- FIM do Setor do Designer -------------------------------------
        }
    }
}
