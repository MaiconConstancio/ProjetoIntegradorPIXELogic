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
    public partial class EmissaoRelatorioFinanceiroProdutos : Form
    {
        private Bitmap capturaDeTela = null;
        public EmissaoRelatorioFinanceiroProdutos()
        {
            InitializeComponent();
        }

        private void EmissaoRelatorioFinanceiroProdutos_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in Conexao.executaQuery("select * from vendas;").Rows)
            {

                PalcoEmissaoRelatorioFinanceiroProduto palcoListaDeProdutos = new PalcoEmissaoRelatorioFinanceiroProduto(row["produto"].ToString(), row["nome_cliente"].ToString(), row["valor"].ToString());

                palcoListaDeProdutos.TopLevel = false;
                panel1.Controls.Add(palcoListaDeProdutos);
                palcoListaDeProdutos.Location = new Point(0, 0 + panel1.Height);
                palcoListaDeProdutos.Show();

            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            SagaoPrincipal sagaoPrincipal = new SagaoPrincipal();
            sagaoPrincipal.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(sagaoPrincipal);
            sagaoPrincipal.Show();

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

        private void btnCapturarImagem_Click_1(object sender, EventArgs e)
        {
            capturaDeTela = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(capturaDeTela, new Rectangle(0, 0, this.Width, this.Height));
            MessageBox.Show("Captura de tela concluída!");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
