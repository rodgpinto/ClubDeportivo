using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class Socio
    {
        public DataTable ListarSocios()
        {
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("ListarSocios", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar socios: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return tabla;
        }
    }
}

