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

            if (Auxiliares.verificaCampo("login", txtLogin) == false &&
            Auxiliares.verificaCampo("senha", txtSenha) == false)
            {

                if (Auxiliares.existe("email", txtLogin) == true)
                {

                    if (Auxiliares.existe("senha", txtSenha) == true)
                    {

                        string admin = $"select email,admin from usuarios where email = '{txtLogin.Text}' and admin = true;";

                        if (Conexao.executaQuery(admin).Rows.Count > 0)
                        {

                            Form3 form3 = new Form3();
                            form3.Show();

                        }

                        else
                        {

                            Form5 form5 = new Form5();
                            form5.Show();

                        }

                    }

                    else { MessageBox.Show("Digite uma senha v�lida", "senha inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else { MessageBox.Show("Digite um email v�lido", "email inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}