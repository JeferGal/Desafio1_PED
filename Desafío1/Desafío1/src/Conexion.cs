
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1
{
    class Conexion
    {
        static string servidor = "localhost";
        static string bd = "desafio1";
        static string user = "root";
        static string password = "";
        static string puerto = "3306";

        static string cadena = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + bd + ";";
        public MySqlConnection conexion = new MySqlConnection(cadena);

        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error de conexión" + ex);
                return false;
            }
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }
    }

}

