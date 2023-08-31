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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            if(Conexao.campoVazio("nome",txtNome) == false && Conexao.campoVazio("Cargo", txtCargo) == false
                && Conexao.campoVazio("login", txtLogin) == false && Conexao.campoVazio("senha", txtSenha) == false)
            {

                if (Conexao.existe("nome", txtNome) == false)
                {

                    if (Conexao.existe("email", txtLogin) == false)
                    {

                        if (Conexao.existe("senha", txtSenha) == false)
                        {

                            string query = $"insert into usuarios (nome,empresa,email,senha) values ('{txtNome.Text}','{txtCargo.Text}','{txtLogin.Text}','{txtSenha.Text}')";
                            Conexao.executaQuery(query);

                            txtCargo.Clear();
                            txtLogin.Clear();
                            txtSenha.Clear();
                            txtNome.Clear();

                        }

                        else { MessageBox.Show("Por favor digite uma senha nova.", "senha já existente!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                    else { MessageBox.Show("Por favor digite um email novo.", "email já existente!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else { MessageBox.Show("Por favor digite um nome novo.", "nome já existente!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

        }

        private void btnPular_Click(object sender, EventArgs e)
        {

            Form4 escolhaFerramentas = new Form4();
            escolhaFerramentas.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
