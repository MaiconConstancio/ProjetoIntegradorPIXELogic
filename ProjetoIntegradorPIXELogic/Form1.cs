using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoIntegradorPIXELogic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {
        
           if(Auxiliares.verificaCampo("email", txtLogin) == false &&
            Auxiliares.verificaCampo("senha", txtSenha) == false)
            {

                if (Auxiliares.existe("email", txtLogin) == true)
                {

                    if (Auxiliares.existe("senha", txtSenha) == true)
                    {

                        string admin = $"select email,admin from usuarios where email = '{txtLogin.Text}' and admin = true;";

                        if (Conexao.executaQuery(admin).Rows.Count > 0)
                        {

                            Form1 form = new Form1();
                            form.Show();

                        }

                        else
                        {

                            Form1 form = new Form1();
                            form.Show();
                            /*digite o form*/

                        }

                    }

                    else { MessageBox.Show($" Por favor digite uma senha v�lida!", $"Senha inv�lida!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else { MessageBox.Show($" Por favor digite um login v�lido!", $"Login inv�lido!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            
 

        }

    }