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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string verifica = $"select (email,senha) from usuarios where email = '{txtNovoLogin.Text}' and senha = '{txtNovaSenha.Text}'";
            DataTable resultado = Conexao.executaQuery(verifica);

            if (resultado.Rows.Count > 0 )
            {

                MessageBox.Show("Usuário já cadastrado, por favor insira um novo!", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                string query = $"insert into usuarios ('email','senha') values ('{txtNovoLogin.Text}','{txtNovaSenha.Text}')";
                Conexao.executaQuery(query);

                Form3 form3 = new Form3();
                form3.Show();

            }

        }
    }
}
