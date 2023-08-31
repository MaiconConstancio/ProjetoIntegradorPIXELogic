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
            if(Conexao.campoVazio("nome",txtNome) == false && Conexao.campoVazio("Cargo", txtCargo) 
                && Conexao.campoVazio("login", txtLogin) == false && Conexao.campoVazio("senha", txtSenha))
            {

                if (Conexao.existe("nome", txtNome, 1) == false && Conexao.existe("email", txtLogin, 1) == false
                && Conexao.existe("senha", txtSenha, 1) == false)
                {

                    string query = $"insert into usuarios (nome,empresa,email,senha) values ('{txtNome.Text}','{txtCargo.Text}','{txtLogin.Text}','{txtSenha.Textmmmmm}')";
                    Conexao.executaQuery(query);

                }

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
