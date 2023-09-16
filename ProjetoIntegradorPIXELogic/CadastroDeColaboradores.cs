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

        private void LogoComoWallpaper_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Funcoes.campoVazio("Nome", txtNome) == false && Funcoes.campoVazio("Cargo", txtCargo) == false &&
                Funcoes.campoVazio("Login", txtLogin) == false && Funcoes.campoVazio("Senha", txtSenha) == false)
            {

                if (Funcoes.existe("usuario", "nome", txtNome) == false)
                {

                    if (Funcoes.existe("usuario", "login", txtLogin) == false)
                    {

                        if (Funcoes.existe("usuario", "senha", txtSenha) == false)
                        {

                            if (MessageBox.Show($"Nome: {txtNome.Text}\n\n" +
                            $"Cargo: {txtCargo.Text}\n\n" +
                            $"Login: {txtLogin.Text}\n\n" +
                            $"Senha: {txtSenha.Text}\n\n",
                            "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                            {

                                string query = $"insert into usuario (nome,cargo,login,senha) values " +
                                    $"('{txtNome.Text}','{txtCargo.Text}','{txtLogin.Text}','{txtSenha.Text}');";
                                Conexao.executaQuery(query);

                                txtNome.Clear();
                                txtCargo.Clear();
                                txtLogin.Clear();
                                txtSenha.Clear();

                            }

                        }

                        else { MessageBox.Show("Por favor digite outra senha.", "senha já existente", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                    else { MessageBox.Show("Por favor digite outro login", "Login já existente", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else { MessageBox.Show("Por favor digite outro nome.", "Nome já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            ListaDeColaboradores listaDeColaboradores = new ListaDeColaboradores();
            listaDeColaboradores.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(listaDeColaboradores);
            listaDeColaboradores.Show();

        }
    }
}
