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
    public partial class ListaDeColaboradores : Form
    {
        private Bitmap capturaDeTela = null;

        public ListaDeColaboradores()
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
            CadastroDeColaboradores cadastroDeColaboradores = new CadastroDeColaboradores();
            cadastroDeColaboradores.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(cadastroDeColaboradores);
            cadastroDeColaboradores.Show();

        }

        private void ListaDeColaboradores_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in Conexao.executaQuery("select * from usuario;").Rows)
            {

                PalcoListaDeColaboradores palcoDaLista = new PalcoListaDeColaboradores(row["nome"].ToString(), row["cargo"].ToString(), row["login"].ToString(),
                                                             row["senha"].ToString());

                palcoDaLista.TopLevel = false;
                panel1.Controls.Add(palcoDaLista);
                palcoDaLista.Location = new Point(0, 0 + panel1.Height);
                palcoDaLista.Show();

            }

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
