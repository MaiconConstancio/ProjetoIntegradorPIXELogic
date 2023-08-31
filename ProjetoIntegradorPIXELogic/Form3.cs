using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {

            if (Auxiliares.verificaCampo("Nome", txtNome) == false)
            {

                if (Auxiliares.existe("nome", txtNome) == false &&
                    Auxiliares.existe("email", txtLogin) == false &&
                    Auxiliares.existe("senha", txtSenha) == false)
                {

                    if (txtCargo.Text == "Dono" || txtCargo.Text == "Gerente")
                    {

                        string sql = $"insert into usuarios (nome,empresa,email,senha,admin)" +
                        $"values ('{txtNome.Text}', '{txtCargo.Text}', '{txtLogin.Text}', '{txtSenha.Text}', true)";

                        Conexao.executaQuery(sql);

                    }

                    else
                    {

                        string query = $"insert into usuarios (nome,empresa,email,senha,admin)" +
                        $"values ('{txtNome.Text}', '{txtCargo.Text}', '{txtLogin.Text}', '{txtSenha.Text}', false)";

                        Conexao.executaQuery(query);

                    }

                    txtLogin.Clear();
                    txtSenha.Clear();
                    txtCargo.Clear();
                    txtNome.Clear();

                }

            }

        }

        private void btnPular_Click(object sender, EventArgs e)
        {

            Form4 funcoes = new Form4();
            funcoes.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
