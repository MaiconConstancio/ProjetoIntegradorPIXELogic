using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorPIXELogic
{
    public partial class GerenciamentoDeClientes : Form
    {
        private Bitmap capturaDeTela = null;

        public GerenciamentoDeClientes()
        {
            InitializeComponent();
        }

        private void GerenciamentoDeClientes_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in Conexao.executaQuery("select * from clientes;").Rows)
            {

                //telefone

                int dd = int.Parse(row["telefone"].ToString().Substring(0, 2));
                int numero1 = int.Parse(row["telefone"].ToString().Substring(2, 4));
                int numero2 = int.Parse(row["telefone"].ToString().Substring(7, 4));

                //cpf

                int cpf1 = int.Parse(row["cpf"].ToString().Substring(0, 3));
                int cpf2 = int.Parse(row["cpf"].ToString().Substring(3, 3));
                int cpf3 = int.Parse(row["cpf"].ToString().Substring(6, 3));
                int cpf4 = int.Parse(row["cpf"].ToString().Substring(9, 2));

                //cep

                int cep1 = int.Parse(row["cep"].ToString().Substring(0, 5));
                int cep2 = int.Parse(row["cep"].ToString().Substring(5, 3));

                PalcoGerenciamentoDeClientes palcoDaLista = new PalcoGerenciamentoDeClientes(row["nome"].ToString(), $"{cpf1}.{cpf2}.{cpf3}-{cpf4}", $"({dd}){numero1}-{numero2}",
                                                                                             $"{cep1}-{cep2}", row["numero"].ToString(), row["endereco"].ToString(), row["cidade"].ToString());

                palcoDaLista.TopLevel = false;
                panel1.Controls.Add(palcoDaLista);
                palcoDaLista.Location = new Point(0, 0 + panel1.Height);
                palcoDaLista.Show();

            }

        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            CadastroDeCliente cadastroDeCliente = new CadastroDeCliente();
            cadastroDeCliente.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(cadastroDeCliente);
            cadastroDeCliente.Show();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            SelecionaQualCadastro selecionaQualCadastro = new SelecionaQualCadastro();
            selecionaQualCadastro.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(selecionaQualCadastro);
            selecionaQualCadastro.Show();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (capturaDeTela != null)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirCaptura);

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = pd;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    pd.Print();
                }
            }
            else
            {
                MessageBox.Show("Capture uma imagem antes de imprimir.", "Aviso");
            }
        }
        private void ImprimirCaptura(object sender, PrintPageEventArgs e)
        {
            if (capturaDeTela != null)
            {
                e.Graphics.DrawImage(capturaDeTela, e.PageBounds);
            }
        }
        private void btnCapturarImagem_Click(object sender, EventArgs e)
        {
            capturaDeTela = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(capturaDeTela, new Rectangle(0, 0, this.Width, this.Height));
            MessageBox.Show("Captura de tela concluída!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
