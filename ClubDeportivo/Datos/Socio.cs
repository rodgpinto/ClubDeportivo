using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    // Creamos la clase Socio que hereda de Persona
    internal class Socio : Persona
    {
        private DateTime fechaAlta;
        private bool estado;
        // Creamos el constructor
        public Socio() : base()
        {
        }

        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public bool Estado { get => estado; set => estado = value; }

        // Implementamos el método ListarPersonas() de la clase Persona
        public DataTable ListarSocios()
        {
            return ListarPersonas("socios ");
        }

        // Método para obtener la foto del carnet de un socio por su ID
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

        // Implementamos el método ObtenerIdPorDNI() de la clase Persona
        public override int? ObtenerIdPorDNI(string dni)
        {
            int? socioId = null;

            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT s.id_socio 
                    FROM socios s
                    INNER JOIN persona p ON s.persona_id = p.Codigo 
                    WHERE p.dni = @dni;", conn))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        socioId = Convert.ToInt32(result);
                }
            }

            return socioId;
        }

        // Método para listar socios con cuota vencida
        public DataTable VerSociosConUltimaCuotaVencida()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("VerSociosConUltimaCuotaVencida", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar socios con cuota vencida: " + ex.Message);
            }

            return tabla;
        }

        // Método para obtener los datos del carnet de los socios
        public DataTable ObtenerDatosCarnet()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("obtener_datos_carnet", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del carnet: " + ex.Message);
            }

            return tabla;
        }



    }
}

