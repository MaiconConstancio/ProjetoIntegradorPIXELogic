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

            if(Conexao.campoVazio("Login",txtLogin) == false && Conexao.campoVazio("Senha",txtSenha) == false)
            {

                if (Conexao.existe("email", txtLogin) == true && Conexao.existe("senha", txtSenha) == true)
                {

                    Form3 form3 = new Form3();
                    form3.Show();

                }

                else
                {

                    MessageBox.Show("");

                }

            }

        }
    }
}