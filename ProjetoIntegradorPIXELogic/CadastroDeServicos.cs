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
    public partial class CadastroDeServicos : Form
    {
        public CadastroDeServicos()
        {
            InitializeComponent();
        }

        private void CadastroDeServicos_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer-----------------------------------
            lblCadastrodeServicos.Parent = LogoComoWallpaper;
            lblCadastrodeServicos.BackColor = Color.Transparent;

            lblNomedoServico.Parent = LogoComoWallpaper;
            lblNomedoServico.BackColor = Color.Transparent;

            lblValor.Parent = LogoComoWallpaper;
            lblValor.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer----------------------------
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            OrcamentoDeServicos orcamentoDeServicos = new OrcamentoDeServicos();
            orcamentoDeServicos.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(orcamentoDeServicos);
            orcamentoDeServicos.Show();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Funcoes.campoVazio("Nome do serviço", txtNomeDoServico) == false && Funcoes.campoVazio("Valor", maskValor) == false)
            {

                if (MessageBox.Show("já existe um serviço cadastrado com este nome, deseja continuar ?", "Serviço já cadastrado",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    if (MessageBox.Show($"Nome do serviço: {txtNomeDoServico.Text}\n\n" +
                                    $"Valor: {maskValor.Text}\n\n",
                                    "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                    {

                        string query = $"insert into usuario (nome_servico,valor) values " +
                            $"('{txtNomeDoServico.Text}','{maskValor.Text}');";
                        Conexao.executaQuery(query);

                        txtNomeDoServico.Clear();
                        maskValor.Text = "";

                    }

                    return;

                }

                if (MessageBox.Show($"Nome do serviço: {txtNomeDoServico.Text}\n\n" +
                                    $"Valor: {maskValor.Text}\n\n",
                                    "Confirme os dados!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                {

                    string query = $"insert into usuario (nome_servico,valor) values " +
                        $"('{txtNomeDoServico.Text}','{maskValor.Text}');";
                    Conexao.executaQuery(query);

                    txtNomeDoServico.Clear();
                    maskValor.Text = "";

                }

            }

        }
    }
}
