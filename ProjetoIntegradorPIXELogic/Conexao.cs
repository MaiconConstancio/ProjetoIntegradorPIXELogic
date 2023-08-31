using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorPIXELogic
{ 
    internal class Conexao
    {

        const string host = "127.0.0.1";
        const string banco = "pixellogic_pi";
        const string usuario = "root";
        const string senha = "";

        public static MySqlConnection connection =
            new MySqlConnection($"Server={host};Database={banco};Uid={usuario};Pwd={senha};");

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

        public static Boolean existe(string campo, TextBox txt)
        {

            string query = $"select * from usuarios where {campo} = '{txt.Text}';";

            if (Conexao.executaQuery(query).Rows.Count > 0)
            {

                return true;

            }

<<<<<<< HEAD
            else
            {

                return false;

            }
=======
            else { return false; }
>>>>>>> login e cadastro finalizados

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
