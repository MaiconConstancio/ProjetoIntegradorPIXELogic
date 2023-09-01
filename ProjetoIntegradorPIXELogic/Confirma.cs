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
    public partial class Confirma : Form
    {
        public Confirma()
        {
            InitializeComponent();

            txtLogin.Text = this.ArmazenamentoLogin;
            txtSenha.Text = this.ArmazenamentoSenha;

        }

        public string ArmazenamentoLogin { get; set; }
        public string ArmazenamentoSenha { get; set; }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.ArmazenaConfirmar = "Confirmar";


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.ArmazenaCancela = "Cancelar";



        }

    }

}
