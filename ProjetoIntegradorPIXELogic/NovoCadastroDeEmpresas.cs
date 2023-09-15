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
    public partial class NovoCadastroDeEmpresas : Form
    {
        public NovoCadastroDeEmpresas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NovoCadastroDeEmpresas_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer------------------------------------
            lblCadastroDeNovasConta.Parent = LogoComoWallpaper;
            lblCadastroDeNovasConta.BackColor = Color.Transparent;

            lblNome.Parent = LogoComoWallpaper;
            lblNome.BackColor = Color.Transparent;

            lblEmpresa.Parent = LogoComoWallpaper;
            lblEmpresa.BackColor = Color.Transparent;

            lblEmail.Parent = LogoComoWallpaper;
            lblEmail.BackColor = Color.Transparent;

            lblLogin.Parent = LogoComoWallpaper;
            lblLogin.BackColor = Color.Transparent;

            lblSenha.Parent = LogoComoWallpaper;
            lblSenha.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer------------------------------------
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            TelaLoginPaginaInicial telaLogin = new TelaLoginPaginaInicial();
            telaLogin.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(telaLogin);
            telaLogin.Show();

        }
    }
}
