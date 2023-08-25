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
    public partial class NovoLoginSenha : Form
    {
        public NovoLoginSenha()
        {
            InitializeComponent();
        }

        private void NovoLoginSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Credenciais cadastroFuncionario = new Credenciais();
            cadastroFuncionario.Show();
        }
    }
}
