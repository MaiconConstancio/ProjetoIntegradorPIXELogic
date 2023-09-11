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
    public partial class Cadastro : System.Windows.Forms.Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

                            if (MessageBox.Show($"Nome: {txtNome.Text}\n" +
                            $"Cargo: {txtCargo.Text}\n\n" +
                            $"Login: {txtLogin.Text}\n\n" +
                            $"Senha: {txtSenha.Text}\n\n",
                            "Confirme seus dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                            {

                                string query = $"insert into usuario (nome,cargo,login,senha) values ('{txtNome.Text}','{txtCargo.Text}','{txtLogin.Text}','{txtSenha.Text}')";
                                Conexao.executaQuery(query);

                                txtNome.Clear();
                                txtCargo.Clear();
                                txtLogin.Clear();
                                txtSenha.Clear();

                            }

                        }

                        else { MessageBox.Show("Por favor digite outra senha.", "Senha já cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                    else { MessageBox.Show("Por favor digite outro login.", "login já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else { MessageBox.Show("Por favor digite outro nome.", "Nome já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.panel1.Controls.Clear();
            Lista lista = new Lista();
            lista.TopLevel = false;
            Form1.panel1.Controls.Add(lista);
            lista.Show();


        }
    }
}
