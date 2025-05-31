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
        public byte[] ObtenerFotoPorSocioId(int socioId)
        {
            byte[] foto = Array.Empty<byte>(); 
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                string query = "SELECT foto FROM carnet WHERE socioId = @socioId LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@socioId", socioId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            foto = (byte[])reader["foto"];
                        }
                    }
                }
            }
            return foto;
        }
    }
}

