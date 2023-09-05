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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            form5.Show();
            this.Close();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            //Serviços

            string nome_s = $"select * from servicos where nomedocliente = '{textBox1.Text}';";
            string rg_s = $"select * from servicos where rg = '{textBox1.Text}';";
            string cpf_s =$"select * from servicos where cpf = '{textBox1.Text}';";
            string telefone_s = $"select * from sevicos where telefone = '{textBox1.Text}'";

            //Produtos

            string nome_p = $"select * from produtos where nomedocliente = '{textBox1.Text}';";
            string rg_p = $"select * from produtos where rg = '{textBox1.Text}';";
            string cpf_p = $"select * from produtos where cpf = '{textBox1.Text}';";
            string telefone_p = $"select * from produtos where telefone = '{textBox1.Text}'";

            //executa todas

            DataTable dt = new DataTable();

            dt = Conexao.executaQuery(nome_s);
            dt = Conexao.executaQuery(rg_s);
            dt = Conexao.executaQuery(cpf_s);
            dt = Conexao.executaQuery(telefone_s);
            dt = Conexao.executaQuery(nome_p);
            dt = Conexao.executaQuery(rg_p);
            dt = Conexao.executaQuery(cpf_p);
            dt = Conexao.executaQuery(telefone_p);

        }
    }
}
