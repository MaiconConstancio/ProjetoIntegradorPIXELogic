using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorPIXELlogic
{
    public class Conexao
    {

        const string host = "localhost";

        const string banco = "pixellogic_pi";
        const string usuario = "root";
        const string senha = "";

        public static MySqlConnection connection = new MySqlConnection($"Server={host};Database={banco};Uid={usuario};Pwd={senha};");


        public static DataTable executaQuery(string query)
        {

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader read = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(read);
                return dataTable;
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro ao realizar consulta:");
                Console.WriteLine(erro.Message);
                return null;
            }
            finally
            {
                connection.Dispose();
            }

        }

        public static Boolean existe(string campo, TextBox txt,int opcao)
        {

             string query = $"select {campo} from usuarios where {campo} = '{txt.Text}';";

             if (Conexao.executaQuery(query).Rows.Count > 0)
             {

                 return true;

             }

             else
             {

                 MessageBox.Show($"Por favor digite um(a) {campo} novo(a).", $"{campo} já existente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
      
    }
  
}
