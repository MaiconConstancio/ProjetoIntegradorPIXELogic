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
    public partial class Lista : System.Windows.Forms.Form
    {
        public Lista()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            string query = "select * from usuario";
            DataTable linhas = Conexao.executaQuery(query);
            foreach (DataRow row in linhas.Rows)
            {

                Itens form3 = new Itens(row["nome"].ToString(), row["cargo"].ToString(), row["login"].ToString(), row["senha"].ToString());
                form3.TopLevel = false;
                form3.Location = new Point(0,0 + panel1.Height - 2);
                panel1.Controls.Add(form3);
                form3.Show();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cadastro form1 = new Cadastro();
            form1.Show();
            this.Close();

        }
    }
}
