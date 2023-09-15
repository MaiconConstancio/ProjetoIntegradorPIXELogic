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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (Funcoes.campoVazio("Nome", txtNome) == false && Funcoes.campoVazio("Empresa", txtEmpresa) == false &&
                Funcoes.campoVazio("Login", txtLogin) == false && Funcoes.campoVazio("Senha", txtSenha) == false)
            {

                if (MessageBox.Show($"Nome: {txtNome.Text}\n\n" +
                            $"Empresa: {txtEmpresa.Text}\n\n" +
                            $"Login: {txtLogin.Text}\n\n" +
                            $"Senha: {txtSenha.Text}\n\n",
                            "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                {

                    string query = $"insert into usuario (nome,cargo,login,senha) values " +
                        $"('{txtNome.Text}','dono','{txtLogin.Text}','{txtSenha.Text}');";
                    Conexao.executaQuery(query);

                    txtNome.Clear();
                    txtEmpresa.Clear();
                    txtLogin.Clear();
                    txtSenha.Clear();

                    RodaTodosForms.panel1.Controls.Clear();
                    TelaLoginPaginaInicial telaLogin = new TelaLoginPaginaInicial();
                    telaLogin.TopLevel = false;
                    RodaTodosForms.panel1.Controls.Add(telaLogin);
                    telaLogin.Show();

                }

            }

        }
    }
}
