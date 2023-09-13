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
    public partial class CadastroDeColaboradores : Form
    {
        public CadastroDeColaboradores()
        {
            InitializeComponent();
        }

        private void CadastroDeColaboradores_Load(object sender, EventArgs e)
        {
            //--------------------------- Setor do Designer -------------------------------------
            lblEscolhaSeusColaboradoresESuasCredenciais.Parent = LogoComoWallpaper;
            lblEscolhaSeusColaboradoresESuasCredenciais.BackColor = Color.Transparent;

            lblNome.Parent = LogoComoWallpaper;
            lblNome.BackColor = Color.Transparent;

            lblCargo.Parent = LogoComoWallpaper;
            lblCargo.BackColor = Color.Transparent;

            lblLogin.Parent = LogoComoWallpaper;
            lblLogin.BackColor = Color.Transparent;

            lblSenha.Parent = LogoComoWallpaper;
            lblSenha.BackColor = Color.Transparent;
            //--------------------------- FIM do Setor do Designer -------------------------------------
        }
    }
}
