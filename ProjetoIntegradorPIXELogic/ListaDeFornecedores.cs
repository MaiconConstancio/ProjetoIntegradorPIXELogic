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
    public partial class ListaDeFornecedores : Form
    {
        private Bitmap capturaDeTela = null;

        public ListaDeFornecedores()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            SelecionaQualCadastro selecionaQualCadastro = new SelecionaQualCadastro();
            selecionaQualCadastro.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(selecionaQualCadastro);
            selecionaQualCadastro.Show();

        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            CadastroDeFornecedores cadastroDeFornecedores = new CadastroDeFornecedores();
            cadastroDeFornecedores.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(cadastroDeFornecedores);
            cadastroDeFornecedores.Show();

        }

        private void ListaDeFornecedores_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in Conexao.executaQuery("select * from fornecedores;").Rows)
            {

                //telefone

                int dd = int.Parse(row["telefone"].ToString().Substring(0, 2));
                int numero1 = int.Parse(row["telefone"].ToString().Substring(2, 4));
                int numero2 = int.Parse(row["telefone"].ToString().Substring(7, 4));

                //cnpj

                int cnpj1 = int.Parse(row["cnpj"].ToString().Substring(0, 2));
                int cnpj2 = int.Parse(row["cnpj"].ToString().Substring(2, 3));
                int cnpj3 = int.Parse(row["cnpj"].ToString().Substring(5, 3));
                int cnpj4 = int.Parse(row["cnpj"].ToString().Substring(8, 3));
                int cnpj5 = int.Parse(row["cnpj"].ToString().Substring(11, 2));

                //MessageBox.Show($"{cnpj1}.{cnpj2}.{cnpj3}/{cnpj4}1-{cnpj5}");

                //cep

                int cep1 = int.Parse(row["cep"].ToString().Substring(0, 5));
                int cep2 = int.Parse(row["cep"].ToString().Substring(5, 3));

                PalcoListaDeFornecedores palcoDaLista = new PalcoListaDeFornecedores(row["nome"].ToString(), $"{cnpj1}.{cnpj2}.{cnpj3}/{cnpj4}1-{cnpj5}", $"({dd}){numero1}-{numero2}",
                                                                                     $"{cep1}-{cep2}", row["numero"].ToString(), row["endereco"].ToString(), row["cidade"].ToString());

                palcoDaLista.TopLevel = false;
                panel1.Controls.Add(palcoDaLista);
                palcoDaLista.Location = new Point(0, 0 + panel1.Height);
                palcoDaLista.Show();

            }

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblCNPJ_Click(object sender, EventArgs e)
        {
        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {
        }

        private void lblCEP_Click(object sender, EventArgs e)
        {
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {
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
    }
}
