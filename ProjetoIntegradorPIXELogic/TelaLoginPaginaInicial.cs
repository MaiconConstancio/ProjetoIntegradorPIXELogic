using Microsoft.VisualBasic.Devices;
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
    public partial class TelaLoginPaginaInicial : Form
    {
        public TelaLoginPaginaInicial()
        {
            InitializeComponent();
        }

        private void TelaLoginPaginaInicial_Load(object sender, EventArgs e)
        {
            imgLOGOloginPrincipal.Parent = imgWallpaperLoginPrincipal;
            imgLOGOloginPrincipal.BackColor = Color.Transparent;
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {

            Program.acesso = $"{txtLogin.Text}";

            if (Funcoes.campoVazio("Login", txtLogin) == false && Funcoes.campoVazio("Senha", txtSenha) == false)
            {

                if (Funcoes.existe("usuario", "login", txtLogin) == true)
                {

                    if (Funcoes.existe("usuario", "senha", txtSenha) == true)
                    {


                        if (Conexao.executaQuery($"select * from usuario where login = '{txtLogin.Text}' and cargo = 'dono';").Rows.Count > 0 ||
                            Conexao.executaQuery($"select * from usuario where login = '{txtLogin.Text}' and cargo = 'gerente';").Rows.Count > 0 ||
                            Conexao.executaQuery($"select * from usuario where login = '{txtLogin.Text}' and cargo = 'desenvolvedor';").Rows.Count > 0)
                        {

                            if (Conexao.executaQuery($"Select * from usuario where login = '{txtLogin.Text}' and primeiro_acesso = false;").Rows.Count > 0)
                            {

                                RodaTodosForms.panel1.Controls.Clear();
                                MontagemPrograma montagemPrograma = new MontagemPrograma();
                                montagemPrograma.TopLevel = false;
                                RodaTodosForms.panel1.Controls.Add(montagemPrograma);
                                montagemPrograma.Show();

                            }

                            else
                            {

                                RodaTodosForms.panel1.Controls.Clear();
                                SagaoPrincipal sagaoPrincipal = new SagaoPrincipal();
                                sagaoPrincipal.TopLevel = false;
                                RodaTodosForms.panel1.Controls.Add(sagaoPrincipal);
                                sagaoPrincipal.Show();

                            }

                        }

                        else
                        {

                            RodaTodosForms.panel1.Controls.Clear();
                            SagaoPrincipal sagaoPrincipal = new SagaoPrincipal();
                            sagaoPrincipal.TopLevel = false;
                            RodaTodosForms.panel1.Controls.Add(sagaoPrincipal);
                            sagaoPrincipal.Show();

                        }

                    }

                    else
                    {

                        MessageBox.Show("Por favor digite a senha novamente!", "Senha inválida!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

                else
                {

                    MessageBox.Show("Por favor digite um login válido, ou crie uma nova conta.", "Conta não existente!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void lblNãotemconta_Click(object sender, EventArgs e)
        {

            if (Conexao.executaQuery("select * from usuario where primeiro_acesso = true").Rows.Count > 0)
            {


                MessageBox.Show("Não é possivel criar uma conta de colaboradores por aqui, consulte um superior", "Cadastro principal já efetuado!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                RodaTodosForms.panel1.Controls.Clear();
                NovoCadastroDeEmpresas novoCadastro = new NovoCadastroDeEmpresas();
                novoCadastro.TopLevel = false;
                RodaTodosForms.panel1.Controls.Add(novoCadastro);
                novoCadastro.Show();

            }

        }


    }
}
