using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorPIXELogic
{
    public partial class OrcamentoDeServicos : Form
    {
        public OrcamentoDeServicos()
        {
            InitializeComponent();
        }

        private void OrcamentoDeServicos_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer-----------------------------------
            lblOrcamentoDeServicos.Parent = LogoComoWallpaper;
            lblOrcamentoDeServicos.BackColor = Color.Transparent;

            lblNomeDoCliente.Parent = LogoComoWallpaper;
            lblNomeDoCliente.BackColor = Color.Transparent;

            lblServico.Parent = LogoComoWallpaper;
            lblServico.BackColor = Color.Transparent;

            lblValor.Parent = LogoComoWallpaper;
            lblValor.BackColor = Color.Transparent;

            lblEndereco.Parent = LogoComoWallpaper;
            lblEndereco.BackColor = Color.Transparent;

            lblFuncionario.Parent = LogoComoWallpaper;
            lblFuncionario.BackColor = Color.Transparent;

            lblPrazoDeEntrega.Parent = LogoComoWallpaper;
            lblPrazoDeEntrega.BackColor = Color.Transparent;

            lblCidade.Parent = LogoComoWallpaper;
            lblCidade.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer----------------------------
        }

        private void maskPrazoDeEntrega_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //maskPrazoDeEntrega.SelectionStart = 0;
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Funcoes.campoVazio("Nome do cliente", txtNomeDoCliente) == false && Funcoes.campoVazio("Serviço", cmbServico) == false &&
                Funcoes.campoVazio("Valor", maskValor) == false && Funcoes.campoVazio("Endereço", txtEndereco) == false &&
                Funcoes.campoVazio("Funcionario", txtFuncionario) == false && Funcoes.campoVazio("Estimativa de entrega", maskPrazoDeEntrega) == false)
            {

                if (Conexao.executaQuery($"select * from orcamentos where nome_cliente = '{txtNomeDoCliente.Text}' and servico = '{cmbServico}'").Rows.Count > 0)
                {

                    if (MessageBox.Show("Este cliente já está cadastrado com este mesmo item, deseja cadastrar novamente ?", "Registro duplicado",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        if (MessageBox.Show($"Nome do cliente: {txtNomeDoCliente.Text}\n\n" +
                                    $"Serviço: {cmbServico.Text}\n\n" +
                                    $"Valor: {maskValor.Text}\n\n" +
                                    $"Endereço: {txtEndereco.Text}\n\n" +
                                    $"Funcionario: {txtFuncionario.Text}\n\n" +
                                    $"Estimativa de entrega: '{maskPrazoDeEntrega.Text}'",
                                    "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                        {

                            string dia = maskPrazoDeEntrega.Text.Split('/')[0];
                            string mes = maskPrazoDeEntrega.Text.Split('/')[1];
                            string ano = maskPrazoDeEntrega.Text.Split('/')[2];

                            string query = $"insert into orcamentos (servico,valor,nome_cliente,endereco,funcionario,estimativa_entrega) values " +
                                $"('{cmbServico.Text}','{maskValor.Text}','{txtNomeDoCliente.Text}','{txtEndereco.Text}','{txtFuncionario.Text}','{ano}-{mes}-{dia}');";
                            Conexao.executaQuery(query);

                            txtNomeDoCliente.Clear();
                            txtEndereco.Clear();
                            txtFuncionario.Clear();
                            maskValor.Text = "";
                            maskPrazoDeEntrega.Text = "";
                            cmbServico.Text = "";
                            txtCidade.Clear();

                        }

                    }

                    return;

                }

                if (MessageBox.Show($"Nome do cliente: {txtNomeDoCliente.Text}\n\n" +
                                    $"Serviço: {cmbServico.Text}\n\n" +
                                    $"Valor: {maskValor.Text}\n\n" +
                                    $"Endereço: {txtEndereco.Text}\n\n" +
                                    $"Funcionario: {txtFuncionario.Text}\n\n" +
                                    $"Estimativa de entrega: {maskPrazoDeEntrega.Text}",
                                    "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                {

                    string dia = maskPrazoDeEntrega.Text.Split('/')[0];
                    string mes = maskPrazoDeEntrega.Text.Split('/')[1];
                    string ano = maskPrazoDeEntrega.Text.Split('/')[2];

                    string query = $"insert into orcamentos (servico,valor,nome_cliente,endereco,funcionario,estimativa_entrega) values " +
                        $"('{cmbServico.Text}','{maskValor.Text}','{txtNomeDoCliente.Text}','{txtEndereco.Text}','{txtFuncionario.Text}','{ano}-{mes}-{dia}');";
                    Conexao.executaQuery(query);

                    txtNomeDoCliente.Clear();
                    txtEndereco.Clear();
                    txtFuncionario.Clear();
                    maskValor.Text = "";
                    maskPrazoDeEntrega.Text = "";
                    cmbServico.Text = "";
                    txtCidade.Clear();

                }

            }


        }

        private void btnNovoServico_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            CadastroDeServicos cadastroDeServicos = new CadastroDeServicos();
            cadastroDeServicos.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(cadastroDeServicos);
            cadastroDeServicos.Show();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            GerenciamentoDeServicos gerenciamentoDeServicos = new GerenciamentoDeServicos();
            gerenciamentoDeServicos.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(gerenciamentoDeServicos);
            gerenciamentoDeServicos.Show();

        }
    }
}
