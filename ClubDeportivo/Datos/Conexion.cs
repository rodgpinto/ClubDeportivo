using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ClubDeportivo.Datos
{
    internal class Conexion
    {
        private static Conexion? instancia = null;

        private Conexion() { }

        public static Conexion getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        public MySqlConnection CrearConexion()
        {
            string cadena = "server=localhost; port=3306; user=root; password=1234; database=clubdeportivo;";
            MySqlConnection conexion = new MySqlConnection(cadena);
            return conexion;
        }
    }
}