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
    public partial class RelatorioDeVendas : Form
    {
        public RelatorioDeVendas()
        {
            InitializeComponent();

        }

        decimal valor_total;

        private void RelatorioDeVendas_Load(object sender, EventArgs e)
        {

           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            while (true)
            {

                foreach (DataRow row in Conexao.executaQuery($"select * from vendas where nome_cliente = '{txtNomeDoCliente.Text}';").Rows)
                {

                    PalcoRelatorioDeVendas palcoRelatorioDeVendas = new PalcoRelatorioDeVendas(row["produto"].ToString(), row["quantidade"].ToString(), row["nome_cliente"].ToString(),
                                                                                               row["metodo_pagamento"].ToString(), row["valor"].ToString());

                    palcoRelatorioDeVendas.TopLevel = false;
                    panel1.Controls.Add(palcoRelatorioDeVendas);
                    palcoRelatorioDeVendas.Show();
                    valor_total = decimal.Parse(row["valor"].ToString());

                }

                lblTotal.Text = valor_total.ToString();

            }

        }
    }
}
