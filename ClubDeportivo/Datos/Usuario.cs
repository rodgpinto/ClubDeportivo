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
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon;

            try
            // Creamos la conexión a la base de datos
            {
                //Si getInstancia devuelve null, no hay conexión establecida y se cierra el programa
                Conexion? conexion = Conexion.getInstancia();
                if (conexion == null)
                {
                    return tabla;
                }
                sqlCon = Conexion.getInstancia().CrearConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tabla;
            }

            try
            {
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Usuario", MySqlDbType.VarChar).Value = Usuario;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = Pass;

                sqlCon.Open();
                MySqlDataReader resultado = comando.ExecuteReader();
                tabla.Load(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar iniciar sesión: " + ex.Message);
            }
            finally
            {            // cerramos la conexión

                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return tabla;
        }
    }
}
