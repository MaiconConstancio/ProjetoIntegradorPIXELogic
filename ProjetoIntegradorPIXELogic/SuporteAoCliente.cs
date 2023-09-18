using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ProjetoIntegradorPIXELogic
{
    public partial class SuporteAoCliente : Form
    {
        public SuporteAoCliente()
        {
            InitializeComponent();
        }

        private void SuporteAoCliente_Load(object sender, EventArgs e)
        {
            //---------------------------Setor do Designer-----------------------------------
            lblSuporteAoCliente.Parent = imgWallpaper;
            lblSuporteAoCliente.BackColor = Color.Transparent;

            lblAtendimento.Parent = imgWallpaper;
            lblAtendimento.BackColor = Color.Transparent;

            lblHorario.Parent = imgWallpaper;
            lblHorario.BackColor = Color.Transparent;
            //---------------------------FIM do Setor do Designer----------------------------
        }

        private void btnEntraEmContato_Click(object sender, EventArgs e)
        {
            string numeroWhatsApp = "+5517991733578";
            string mensagemWhatsApp = "Eaiii Conradiitoooo, me ajuda pf??";

            string urlWhatsApp = $"https://api.whatsapp.com/send?phone={numeroWhatsApp}&text={Uri.EscapeDataString(mensagemWhatsApp)}";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = urlWhatsApp,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o WhatsApp: {ex.Message}");
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
    }
}
