﻿using System;
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
    public partial class Lista : System.Windows.Forms.Form
    {
        public Lista()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            string query = "select * from produtos;";
            foreach (DataRow row in Conexao.executaQuery(query).Rows)
            {

                Itens itens = new Itens(row["nome"].ToString(), row["fornecedor"].ToString(), row["quantidade"].ToString(), row["valor"].ToString(),
                                        row["vencimento"].ToString());
                
                itens.TopLevel = false;
                itens.Location = new Point(0, 0 + panel1.Height - 2);
                panel1.Controls.Add(itens);
                itens.Show();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1.panel1.Controls.Clear();
            Cadastro cadastro = new Cadastro();
            cadastro.TopLevel = false;
            Form1.panel1.Controls.Add(cadastro);
            cadastro.Show();

        }
    }
}