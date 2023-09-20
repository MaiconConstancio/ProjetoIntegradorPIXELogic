using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoIntegradorPIXELogic
{
    public partial class RelatorioDeVendas : Form
    {
        private Bitmap capturaDeTela = null;
        decimal valor;

        public RelatorioDeVendas()
        {
            InitializeComponent();

        }

        public RelatorioDeVendas(string txt)
        {
            InitializeComponent();

            txtNomeDoCliente.Text = txt;

        }

        decimal valor_total;

        private void RelatorioDeVendas_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in Conexao.executaQuery($"select * from vendas;").Rows)
            {

                PalcoRelatorioDeVendas palcoRelatorioDeVendas = new PalcoRelatorioDeVendas(row["produto"].ToString(), row["quantidade"].ToString(),
                                                                                           row["nome_cliente"].ToString(), row["metodo_pagamento"].ToString(), row["valor"].ToString());
                palcoRelatorioDeVendas.TopLevel = false;
                panel1.Controls.Add(palcoRelatorioDeVendas);
                palcoRelatorioDeVendas.Location = new Point(0, panel1.Height);
                palcoRelatorioDeVendas.Show();

                decimal soma = valor + (decimal.Parse(row["valor"].ToString()) * decimal.Parse(row["quantidade"].ToString()));

                valor = soma;

            }

            lblTotal.Text = $"Total: {valor}";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            RodaTodosForms.panel1.Controls.Clear();
            Vendas vendas = new Vendas();
            vendas.TopLevel = false;
            RodaTodosForms.panel1.Controls.Add(vendas);
            vendas.Show();

        }

        private void txtNomeDoCliente_TextChanged(object sender, EventArgs e)
        {

            PalcoRelatorioDeVendas.txt = txtNomeDoCliente.Text;

            panel1.Controls.Clear();

            foreach (DataRow row in Conexao.executaQuery($"select * from vendas where nome_cliente = '{txtNomeDoCliente.Text}'").Rows)
            {

                PalcoRelatorioDeVendas palcoRelatorioDeVendas = new PalcoRelatorioDeVendas(row["produto"].ToString(), row["quantidade"].ToString(),
                                                                                           row["nome_cliente"].ToString(), row["metodo_pagamento"].ToString(), row["valor"].ToString());
                palcoRelatorioDeVendas.TopLevel = false;
                panel1.Controls.Add(palcoRelatorioDeVendas);
                palcoRelatorioDeVendas.Location = new Point(0, panel1.Height);
                palcoRelatorioDeVendas.Show();

                decimal soma = valor + decimal.Parse(row["valor"].ToString());

                valor = soma;

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
