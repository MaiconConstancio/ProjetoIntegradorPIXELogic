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

            if (Auxiliares.verificaCampo("email", txtLogin) == false &&
            Auxiliares.verificaCampo("senha", txtSenha) == false)
            {

                if (Auxiliares.existe("email", txtLogin) == true)
                {

                    if (Auxiliares.existe("senha", txtSenha) == true)
                    {

                        string admin = $"select email,admin from usuarios where email = '{txtLogin.Text}' and admin = true;";

                        if (Conexao.executaQuery(admin).Rows.Count > 0)
                        {

                            string verifica = $"select * from usuarios where email = '{txtLogin.Text}' and recriouSenha = false;";

                            if(Conexao.executaQuery(verifica).Rows.Count > 0)
                            {

                                Form2 form2 = new Form2();
                                form2.armazenamentoLogin = txtLogin.Text;
                                form2.armazenamentoSenha = txtSenha.Text;
                                form2.Show();
                                this.Hide();

                            }
                            
                            else
                            {

                                Form3 form3 = new Form3();
                                form3.Show();
                                this.Hide();

                            }

                        }

                        else
                        {

                            string verifica2 = $"select * from usuarios where email = '{txtLogin.Text}' and recriouSenha = false;";

                            if (Conexao.executaQuery(verifica2).Rows.Count > 0)
                            {

                                Form2 form2 = new Form2();
                                form2.armazenamentoLogin = txtLogin.Text;
                                form2.armazenamentoSenha = txtSenha.Text;
                                form2.Show();
                                this.Hide();

                            }

                            else
                            {

                                Form5 form5 = new Form5();
                                form5.Show();
                                this.Hide();

                            }

                        }

                    }

                    else { MessageBox.Show($" Por favor digite uma senha v�lida!", $"Senha inv�lida!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else { MessageBox.Show($" Por favor digite um login v�lido!", $"Login inv�lido!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }



        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}