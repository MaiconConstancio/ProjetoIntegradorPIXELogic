using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador
{
    internal class Auxiliares
    {
    
        public static Boolean existe(string campo,TextBox txt)
        {

            string query = $"select * from usuarios where {campo} = '{txt.Text}';";
            DataTable dataTable = Conexao.executaQuery(query); ;
            
            if (dataTable.Rows.Count > 0)
            {

                return true;

            }

            else { return false; }

        }

        public static Boolean verificaCampo(string campo ,TextBox txt1)
        {

            if (txt1.Text == "")
            {

                MessageBox.Show($"Por favor digite um(a) {campo}",$"{campo} vázio!",MessageBoxButtons.OK,MessageBoxIcon.Error);

                return true;

            }

            return false;

        }
    
    }
}
