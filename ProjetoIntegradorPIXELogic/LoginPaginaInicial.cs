namespace ProjetoIntegradorPIXELogic
{
    public partial class LoginPaginaInicial : Form
    {
        public LoginPaginaInicial()
        {
            InitializeComponent();
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {
            NovoLoginSenha primeiroAcesso = new NovoLoginSenha();
            primeiroAcesso.Show();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void LoginPaginaInicial_Load(object sender, EventArgs e)
        {
        }

        private void txtLogin__TextChanged(object sender, EventArgs e)
        {
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
        }

        private void txtSenha__TextChanged(object sender, EventArgs e)
        {
        }
    }
}