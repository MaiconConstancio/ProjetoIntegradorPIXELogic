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
    public partial class CadastroDeFornecedores : Form
    {
        public CadastroDeFornecedores()
        {
            InitializeComponent();
        }

        private void lblNovaSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtNovoLogin__TextChanged(object sender, EventArgs e)
        {
        }

        private void CadastroDeFornecedores_Load(object sender, EventArgs e)
        {
            //--------------------------- Setor do Designer ------------------------------------
            lblCadastroDeFornecedores.Parent = LogoComoWallpaper;
            lblCadastroDeFornecedores.BackColor = Color.Transparent;

            lblFornecedor.Parent = LogoComoWallpaper;
            lblFornecedor.BackColor = Color.Transparent;

            lblEndereco.Parent = LogoComoWallpaper;
            lblEndereco.BackColor = Color.Transparent;

            lblTelefone.Parent = LogoComoWallpaper;
            lblTelefone.BackColor = Color.Transparent;

            lblCNPJ.Parent = LogoComoWallpaper;
            lblCNPJ.BackColor = Color.Transparent;

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

            if (Funcoes.campoVazio("Nome", txtFornecedor) == false && Funcoes.campoVazio("Endereço", txtEndereço) == false &&
                Funcoes.campoVazio("Telefone", maskedTelefone) == false && Funcoes.campoVazio("CNPJ", maskedCNJP) == false &&
                Funcoes.campoVazio("CEP", maskedCEP) == false && Funcoes.campoVazio("Número", maskedNumero) == false &&
                Funcoes.campoVazio("Cidade", txtCidade) == false)
            {

                if (Funcoes.existe("fornecedores", "nome", txtFornecedor) == false)
                {

                    if (Funcoes.existeINT("fornecedores", "telefone", maskedTelefone) == false)
                    {

                        if (Funcoes.existeINT("fornecedores", "cnpj", maskedCNJP) == false)
                        {

                            if (Conexao.executaQuery($"select * from fornecedores where cep = {maskedCEP.Text} and numero = {maskedNumero.Text}").Rows.Count > 0)
                            {

                                if (MessageBox.Show("Tem certeza que deseja cadastrar dois fornecedores no mesmo endereço ?", "Endereço identico a outro fornecedor!",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {

                                    if (MessageBox.Show($"Nome: {txtFornecedor.Text}\n\n" +
                                    $"Endereço: {txtEndereço.Text}\n\n" +
                                    $"Telefone: {maskedTelefone.Text}\n\n" +
                                    $"CNPJ: {maskedCNJP.Text}\n\n" +
                                    $"CEP: {maskedCEP.Text}\n\n" +
                                    $"Número: {maskedNumero.Text}\n\n" +
                                    $"Cidade: {txtCidade.Text}",
                                    "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                                    {

                                        string query = $"insert into fornecedores (nome,endereco,telefone,cnpj,cep,numero,cidade) values " +
                                            $"('{txtFornecedor.Text}','{txtEndereço.Text}','{maskedTelefone.Text}','{maskedCNJP.Text}'," +
                                            $"'{maskedCEP.Text}','{maskedNumero.Text}','{txtCidade.Text}');";
                                        Conexao.executaQuery(query);

                                        txtFornecedor.Clear();
                                        txtEndereço.Clear();
                                        txtCidade.Clear();
                                        maskedNumero.Text = "";
                                        maskedCNJP.Text = "";
                                        maskedCEP.Text = "";
                                        maskedTelefone.Text = "";

                                    }

                                }

                                return;

                            }

                            if (MessageBox.Show($"Nome: {txtFornecedor.Text}\n\n" +
                                    $"Endereço: {txtEndereço.Text}\n\n" +
                                    $"Telefone: {maskedTelefone.Text}\n\n" +
                                    $"CNPJ: {maskedCNJP.Text}\n\n" +
                                    $"CEP: {maskedCEP.Text}\n\n" +
                                    $"Número: {maskedNumero.Text}\n\n" +
                                    $"Cidade: {txtCidade.Text}",
                                    "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                            {

                                string query = $"insert into fornecedores (nome,endereco,telefone,cnpj,cep,numero,cidade) values " +
                                    $"('{txtFornecedor.Text}','{txtEndereço.Text}','{maskedTelefone.Text}','{maskedCNJP.Text}'," +
                                    $"'{maskedCEP.Text}','{maskedNumero.Text}','{txtCidade.Text}');";
                                Conexao.executaQuery(query);

                                txtFornecedor.Clear();
                                txtEndereço.Clear();
                                txtCidade.Clear();
                                maskedNumero.Text = "";
                                maskedCNJP.Text = "";
                                maskedCEP.Text = "";
                                maskedTelefone.Text = "";

                            }

                        }

                        else { MessageBox.Show("Por favor digite outro CNPJ", "CNPJ já cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                    else { MessageBox.Show("Por favor digite outro Telefone", "Telefone já cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                else { MessageBox.Show("Este fornecedor já etá cadastrado, revise a lita de fornecedores.", "Fornecedor já cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            ListaDeFornecedores listaDeFornecedores = new ListaDeFornecedores();
            listaDeFornecedores.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(listaDeFornecedores);
            listaDeFornecedores.Show();

        }

        private void LogoComoWallpaper_Click(object sender, EventArgs e)
        {

        }
    }
}
