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
    public partial class CadastroDeProdutos : Form
    {
        public CadastroDeProdutos()
        {
            InitializeComponent();
        }

        private void CadastroDeProutos_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer------------------------------------
            lblCadastrodeprodutos.Parent = LogoComoWallpaper;
            lblCadastrodeprodutos.BackColor = Color.Transparent;

            lblNome.Parent = LogoComoWallpaper;
            lblNome.BackColor = Color.Transparent;

            lblFornecedor.Parent = LogoComoWallpaper;
            lblFornecedor.BackColor = Color.Transparent;

            lblQuantidade.Parent = LogoComoWallpaper;
            lblQuantidade.BackColor = Color.Transparent;

            lblValor.Parent = LogoComoWallpaper;
            lblValor.BackColor = Color.Transparent;

            lblVencimento.Parent = LogoComoWallpaper;
            lblVencimento.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer------------------------------------

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Funcoes.campoVazio("Nome", txtNome) == false && Funcoes.campoVazio("Fornecedor", txtFornecedor) == false &&
                Funcoes.campoVazio("Quantidade", txtQuantidade) == false && Funcoes.campoVazio("Valor", maskValor) == false &&
                Funcoes.campoVazio("", maskVencimento) == false)
            {

                if (Conexao.executaQuery($"select * from produtos where nome = '{txtNome.Text}' and fornecedor = '{txtFornecedor.Text}'").Rows.Count > 0)
                {

                    if (MessageBox.Show("Este fornecedor já está associado a este item.", "Fornecedor e produto duplicado!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        == DialogResult.Yes)
                    {

                        if (MessageBox.Show($"Nome: {txtNome.Text}\n\n" +
                           $"Fornecedor: {txtFornecedor.Text}\n\n" +
                           $"Quantidade: {txtQuantidade.Text}\n\n" +
                           $"Valor: {maskValor.Text}\n\n" +
                           $"Vencimento: {maskVencimento.Text}",
                           "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                        {

                            int dia = int.Parse(maskVencimento.Text.Split('/')[0]);
                            int mes = int.Parse(maskVencimento.Text.Split('/')[1]);
                            int ano = int.Parse(maskVencimento.Text.Split('/')[2]);

                            MessageBox.Show($"{ano}-{mes}-{dia}");

                            string query = $"insert into produtos (nome,fornecedor,quantidade,valor,vencimento) values " +
                                $"('{txtNome.Text}','{txtFornecedor.Text}','{txtQuantidade.Text}','{maskValor}','{ano}-{mes}-{dia}');";
                            Conexao.executaQuery(query);

                            txtNome.Clear();
                            txtFornecedor.Clear();
                            txtQuantidade.Clear();
                            maskValor.Text = "";
                            maskVencimento.Text = "";

                        }

                    }

                    return;

                }

                if (MessageBox.Show($"Nome: {txtNome.Text}\n\n" +
                           $"Fornecedor: {txtFornecedor.Text}\n\n" +
                           $"Quantidade: {txtQuantidade.Text}\n\n" +
                           $"Valor: {maskValor.Text}\n\n" +
                           $"Vencimento: {maskVencimento.Text}",
                           "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                {

                    string dia = maskVencimento.Text.Split('/')[0];
                    string mes = maskVencimento.Text.Split('/')[1];
                    string ano = maskVencimento.Text.Split('/')[2];

                    string query = $"insert into produtos (nome,fornecedor,quantidade,valor,vencimento) values " +
                        $"('{txtNome.Text}','{txtFornecedor.Text}','{txtQuantidade.Text}','{maskValor.Text}','{ano}-{mes}-{dia}');";
                    Conexao.executaQuery(query);

                    txtNome.Clear();
                    txtFornecedor.Clear();
                    txtQuantidade.Clear();
                    maskValor.Text = "";
                    maskVencimento.Text = "";

                }

            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            ListaDeProdutos listaDeProdutos = new ListaDeProdutos();
            listaDeProdutos.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(listaDeProdutos);
            listaDeProdutos.Show();

        }
    }
}
