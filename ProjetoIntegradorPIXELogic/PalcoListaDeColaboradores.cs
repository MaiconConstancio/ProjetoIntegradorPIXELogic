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
    public partial class PalcoListaDeColaboradores : Form
    {
        public PalcoListaDeColaboradores(string lb1, string lb2, string lb3, string lb4)
        {
            InitializeComponent();

            label1.Text = lb1;
            label2.Text = lb2;
            label3.Text = lb3;
            label4.Text = lb4;
        }

        private void PalcoListaDeColaboradores_Load(object sender, EventArgs e)
        {



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (Conexao.executaQuery($"select * from usuario where login = '{Program.acesso}' and cargo = 'dono'").Rows.Count > 0 ||
                                    Conexao.executaQuery($"select * from usuario where login = '{Program.acesso}' and cargo = 'gerente'").Rows.Count > 0 ||
                                    Conexao.executaQuery($"select * from usuario where login = '{Program.acesso}' and cargo = 'desenvolvedor'").Rows.Count > 0)
            {

                Conexao.executaQuery($"set SQL_SAFE_UPDATES = 0; delete from usuario where nome = '{label1.Text}';");

                RodaTodosForms.panel1.Controls.Clear();
                ListaDeColaboradores form = new ListaDeColaboradores();
                form.TopLevel = false;
                RodaTodosForms.panel1.Controls.Add(form);
                form.Show();

            }

            else { MessageBox.Show("Somente cargos superiores podem excluir outros colaboradores!", "Exclusão negada", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void label4_Click(object sender, EventArgs e)
        {



        }
    }
}
