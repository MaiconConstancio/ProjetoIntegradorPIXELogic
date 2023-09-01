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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public static Boolean Preguica(TextBox txtLogin, TextBox txtSenha)
        {

            string query = $"select * from usuarios where email = '{txtLogin.Text}' and senha = '{txtSenha.Text}' and admin = true;";

            if (Conexao.executaQuery(query).Rows.Count > 0)
            {

                return true;

            }

            else { return false; }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if(Preguica(txtLogin,txtSenha) == true)
            {

                Form3 form3 = new Form3();
                form3.confirmacao = "ok";
                Close();

            }

            else
            {

                Form3 form3 = new Form3();
                form3.confirmacao = "cancel";
                Close();

            }

        }
    }
}
