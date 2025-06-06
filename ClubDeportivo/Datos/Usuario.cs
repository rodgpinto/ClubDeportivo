using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    // Clase Usuario para manejar el inicio de sesión
    internal class Usuario
    {

        // Constructor de la clase Usuario
        public DataTable Login(string Usuario, string Pass)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                // Creamos la conexión a la base de datos Utilizamos el Store 'Procedure IngresoLogin'
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Usuario", MySqlDbType.VarChar).Value = Usuario;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = Pass;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar iniciar sesión: " + ex.Message);
            }
            // cerramos la conexión
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
