using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorPIXELogic
{
    static class Funcoes
    {

        public static Boolean existe(string tabela,string campo, TextBox txt)
        {

            string query = $"select {campo} from {tabela} where {campo} = '{txt.Text}';";

            if (Conexao.executaQuery(query).Rows.Count > 0)
            {

                return true;

            }

            else
            {

                return false;

            }


        }

        public static Boolean existe(string tabela, string campo, MaskedTextBox mask)
        {

            string query = $"select {campo} from {tabela} where {campo} = '{mask.Text}';";

            if (Conexao.executaQuery(query).Rows.Count > 0)
            {

                return true;

            }

            else
            {

                return false;

            }


        }

        public static Boolean existe(string tabela, string campo, ComboBox combo)
        {

            string query = $"select {campo} from {tabela} where {campo} = '{combo.Text}';";

            if (Conexao.executaQuery(query).Rows.Count > 0)
            {

                return true;

            }

            else
            {

                return false;

            }


        }

        public static Boolean campoVazio(string campo, TextBox txt)
        {

            if (txt.Text == "")
            {

                MessageBox.Show($"Digite um(a) {campo}!", "Campo vázio!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;

            }

            else { return false; }

        }

        public static Boolean campoVazio(string campo, MaskedTextBox mask)
        {

            if (mask.Text == "")

            {

                MessageBox.Show($"Digite um(a) {campo}!", "Campo vázio!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;

            }

            else { return false; }

        }

        public static Boolean campoVazio(string campo, ComboBox combo)
        {

            if (combo.Text == "")

            {

                MessageBox.Show($"Digite um(a) {campo}!", "Campo vázio!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;

            }

            else { return false; }

        }


    }
}
