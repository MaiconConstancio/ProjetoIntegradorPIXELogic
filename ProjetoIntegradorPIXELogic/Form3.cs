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

        public string confirmacao { get;set; }

        private void btnAvançar_Click(object sender, EventArgs e)
        {

            if (Auxiliares.verificaCampo("Nome", txtNome) == false && Auxiliares.verificaCampo("senha", txtSenha) == false)
            {

                if (comboBoxCargo.Text != "")
                {

                    if (Auxiliares.existe("nome", txtNome) == false)
                    {

                        if (Auxiliares.existe("senha", txtSenha) == false)
                        {

                            if (comboBoxCargo.Text == "Administrador do sistema")
                            {
                                Form6 form6 = new Form6();
                                
                                if (this.confirmacao == "ok")
                                {

                                    if (MessageBox.Show($"Email: {txtNome.Text}@Adm \n\n Cargo: {comboBoxCargo.Text} \n\n Senha: {txtSenha.Text}", "Confirme o cadastro",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                                    {

                                        string query = $"insert into usuarios (nome,empresa,email,senha,admin)" +
                                       $"values ('{txtNome.Text}', '{comboBoxCargo.Text}', '{txtNome.Text}@Adm', '{txtSenha.Text}', true)";

                                        Conexao.executaQuery(query);

                                        txtNome.Clear();
                                        txtSenha.Clear();
                                        comboBoxCargo.Items.Clear();

                                    }

                                    else
                                    {

                                        txtNome.Clear();
                                        txtSenha.Clear();
                                        comboBoxCargo.Items.Clear();

                                    }

                                }

                                else
                                {

                                    MessageBox.Show("Digite um login e senha válidos!","Acesso negado",MessageBoxButtons.OK,MessageBoxIcon.Error);

                                }

                            }

                            else
                            {



                                string query = $"insert into usuarios (nome,empresa,email,senha,admin)" +
                                $"values ('{txtNome.Text}', '{comboBoxCargo.Text}', '{txtNome.Text}@funcionario', '{txtSenha.Text}', false)";

                                Conexao.executaQuery(query);


                                txtSenha.Clear();
                                txtNome.Clear();
                                comboBoxCargo.Items.Clear();

                            }

                        }

                        else { MessageBox.Show("Insira uma nova senha", "senha já existente!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                    else { MessageBox.Show("Insira uma novo nome", "Esse nome já existe!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else { MessageBox.Show($"Por favor selecione um cargo!", $"Campo vázio!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

        }

        private void btnPular_Click(object sender, EventArgs e)
        {

            /*Form4 funcoes = new Form4();
            funcoes.Show();*/

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
