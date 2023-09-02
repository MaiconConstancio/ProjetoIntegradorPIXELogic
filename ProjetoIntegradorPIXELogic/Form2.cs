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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public string armazenamentoLogin { get; set; }
        public string armazenamentoSenha { get; set; }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if(Auxiliares.verificaCampo("email",txtNovoLogin) == false && Auxiliares.verificaCampo("senha",txtNovaSenha) == false)
            {

                if (Auxiliares.existe("email", txtNovoLogin) == false)
                {

                    if (Auxiliares.existe("senha", txtNovaSenha) == false)
                    {

                        //login

                        string query = $"update usuarios set email = '{txtNovoLogin.Text}' where email = '{this.armazenamentoLogin}';";
                        Conexao.executaQuery(query);

                        string verifica = $"select * from usuarios where email = '{txtNovoLogin.Text}'";
                        if (Conexao.executaQuery(verifica).Rows.Count > 0 )
                        {

                            MessageBox.Show("Novo email cadastrado com sucesso!","Concluido",MessageBoxButtons.OK,MessageBoxIcon.None);

                        }
                        
                        else
                        {

                            MessageBox.Show("Por favor consulte o desenvolvedor!","Erro no sistema",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                        }

                        //senha

                        string query2 = $"update usuarios set senha = '{txtNovaSenha.Text}' where senha = '{this.armazenamentoSenha}';";
                        Conexao.executaQuery(query2);

                        string verifica2 = $"select * from usuarios where senha = '{txtNovaSenha.Text}'";
                        if (Conexao.executaQuery(verifica2).Rows.Count > 0)
                        {

                            MessageBox.Show("Nova senha cadastrada com sucesso!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.None);

                            string criacaoSenha = $"update usuarios set recriouSenha = true where email = '{txtNovoLogin.Text}';";
                            Conexao.executaQuery(criacaoSenha);

                            Close();

                            Form1 form1 = new Form1();
                            form1.Show();

                        }

                        else
                        {

                            MessageBox.Show("Por favor consulte o desenvolvedor!", "Erro no sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }


                    }

                    else { MessageBox.Show("Insira uma nova senha", "senha já existente!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else
                { MessageBox.Show("Insira um novo login", "login já existente!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
