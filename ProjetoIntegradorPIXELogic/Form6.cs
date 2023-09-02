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

        Form3 form3;
        
        public Form6(Form3 form)
        {
            
            InitializeComponent();
            form3 = form;

        }
        
        //Funçoes

        public static Boolean Preguica(TextBox txtLogin, TextBox txtSenha)
        {

            string query = $"select * from usuarios where email = '{txtLogin.Text}' and senha = '{txtSenha.Text}' and admin = true;";

            if (Conexao.executaQuery(query).Rows.Count > 0)
            {

                return true;

            }

            else { return false; }

        }

        //Eventos

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if(Preguica(txtLogin,txtSenha) == true)
            {

                this.Hide();
                form3.Show();
                form3.salvaInformacoesadm();
                Close();

            }

            else
            {

                this.Hide();
                form3.Show();
                MessageBox.Show("Digite um login e senha de um desenvolvedor!","Conta inválida",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Close();

            }

        }
    }
}
