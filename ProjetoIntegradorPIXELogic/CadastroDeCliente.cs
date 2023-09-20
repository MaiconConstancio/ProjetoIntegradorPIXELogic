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
    public partial class CadastroDeCliente : Form
    {
        public CadastroDeCliente()
        {
            InitializeComponent();
        }

        private void CadastroDeCliente_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer-----------------------------------
            lblCliente.Parent = LogoComoWallpaper;
            lblCliente.BackColor = Color.Transparent;

            lblEndereco.Parent = LogoComoWallpaper;
            lblEndereco.BackColor = Color.Transparent;

            lblTelefone.Parent = LogoComoWallpaper;
            lblTelefone.BackColor = Color.Transparent;

            lblCPF.Parent = LogoComoWallpaper;
            lblCPF.BackColor = Color.Transparent;

            lblCEP.Parent = LogoComoWallpaper;
            lblCEP.BackColor = Color.Transparent;

            lblNumero.Parent = LogoComoWallpaper;
            lblNumero.BackColor = Color.Transparent;

            lblCidade.Parent = LogoComoWallpaper;
            lblCidade.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer----------------------------
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Funcoes.campoVazio("Nome", txtCliente) == false && Funcoes.campoVazio("Endereço", txtEndereco) == false &&
            Funcoes.campoVazio("Telefone", maskTelefone) == false && Funcoes.campoVazio("CPF", maskCPF) == false &&
            Funcoes.campoVazio("CEP", maskCEP) == false && Funcoes.campoVazio("Número", maskNumero) == false &&
            Funcoes.campoVazio("Cidade", txtCidade) == false)
            {

                if (Funcoes.existe("clientes", "nome", txtCliente) == false)
                {

                    if (Funcoes.existe("clientes", "telefone", maskTelefone) == false)
                    {

                        if (Funcoes.existe("clientes", "CPF", maskCPF) == false)
                        {

                            if (MessageBox.Show($"Nome: {txtCliente.Text}\n\n" +
                            $"Endereço: {txtEndereco.Text}\n\n" +
                            $"Telefone: {maskTelefone.Text}\n\n" +
                            $"CNPJ: {maskCPF.Text}\n\n" +
                            $"CEP: {maskCEP.Text}\n\n" +
                            $"Número: {maskNumero.Text}\n\n" +
                            $"Cidade: {txtCidade.Text}\n\n",
                            "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                            {

                                string query = $"insert into clientes (nome,endereco,cpf,telefone,cep,cidade,numero) values " +
                                    $"('{txtCliente.Text}','{txtEndereco.Text}',{maskCPF.Text},{maskTelefone.Text},{maskCEP.Text},'{txtCidade.Text}',{maskNumero.Text});";
                                Conexao.executaQuery(query);

                                txtCliente.Clear();
                                txtEndereco.Clear();
                                maskTelefone.Clear();
                                maskCPF.Clear();
                                maskCEP.Clear();
                                txtCidade.Clear();
                                maskNumero.Clear();

                            }

                        }

                        else { MessageBox.Show("Por favor digite outro CPF.", "CPF já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                    else { MessageBox.Show("Por favor digite outro telefone.", "telefone já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else { MessageBox.Show("Por favor digite outro nome.", "nome já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            GerenciamentoDeClientes gerenciamento = new GerenciamentoDeClientes();
            gerenciamento.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(gerenciamento);
            gerenciamento.Show();


        }
    }
}
