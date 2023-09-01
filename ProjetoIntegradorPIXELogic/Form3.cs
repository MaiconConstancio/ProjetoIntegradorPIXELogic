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

        public string ArmazenaConfirmar { get; set; }
        public string ArmazenaCancela { get; set; }

        private void btnAvançar_Click(object sender, EventArgs e)
        {

            if (Auxiliares.verificaCampo("Nome", txtNome) == false && Auxiliares.verificaCampo("senha",txtSenha) == false)
            {

                if (Auxiliares.existe("nome", txtNome) == false) 
                {

                    if (Auxiliares.existe("senha", txtSenha) == false)
                    {

                        if (comboBoxCargo.Text == "Administrador do sistema")
                        {

                            Confirma confirma = new Confirma();
                            confirma.ArmazenamentoLogin = $"{txtNome.Text}@Adm";
                            confirma.ArmazenamentoSenha = $"{txtSenha.Text}";
                            confirma.Show();

                            if (this.ArmazenaConfirmar == "Confirmar")
                            {

                                string query = $"insert into usuarios (nome,empresa,email,senha,admin)" +
                                $"values ('{txtNome.Text}', '{comboBoxCargo.Text}', '{txtNome.Text}@Adm', '{txtSenha.Text}', true)";

                                Conexao.executaQuery(query);

                                txtNome.Clear();
                                txtSenha.Clear();
                                comboBoxCargo.Items.Clear();
                                confirma.Close();

                            }

                            else { }

                            if(this.ArmazenaCancela == "Cancelar")
                            {

                                confirma.Close();
                                txtNome.Clear();
                                txtSenha.Clear();
                                comboBoxCargo.Items.Clear();

                            }

                            else { }

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
