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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            Form9 form9 = new Form9();
            form9.Show();
            this.Close();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (Auxiliares.verificaCampo("Código do produto",txtCodigo) == false &&
                Auxiliares.verificaCampo("Nome do produto",txtNome) == false &&
                Auxiliares.verificaCampo("Valor", txtValor) == false)
            {

                if (MessageBox.Show($"Codigo do produto: {txtCodigo.Text}" +
                    $"Nome do produto: {txtNome.Text}" +
                    $"Valor: {txtValor.Text}","Confirme as informaçoes!",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
                {

                    string query = "insert into produtos (alguma coisa, alguma coisa,valor) " +
                    $"values ('{txtCodigo.Text}','{txtNome.Text}','{txtValor.Text}')";
                    Conexao.executaQuery(query);

                }
               
            }

        }
    }
}
