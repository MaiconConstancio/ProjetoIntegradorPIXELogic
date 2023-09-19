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

                PalcoListaDeFornecedores palcoDaLista = new PalcoListaDeFornecedores(row["nome"].ToString(), row["endereco"].ToString(), row["telefone"].ToString(),
                                                             row["cnpj"].ToString(), row["cep"].ToString(), row["numero"].ToString(), row["cidade"].ToString());

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
