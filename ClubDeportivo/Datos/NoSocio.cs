using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{        //Creamos la clase NoSocio que hereda de Persona

    internal class NoSocio : Persona
            {

        public NoSocio() : base()
        {
        }

        // Implementamos el método ListarPersonas() de la clase Persona

        public DataTable ListarNoSocios()
        {
            return ListarPersonas("ListarNoSocios");
        }


        // Implementamos el método ObtenerIdPorDNI de la clase abstracta Persona que busca el ID del no socio por su DNI
        public override int? ObtenerIdPorDNI(string dni)
        {
            int? noSocioId = null;

            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(@"
                 SELECT ns.id_NoSocio
                   FROM nosocios ns
                    INNER JOIN persona p ON ns.personaId = p.codigo
                    WHERE p.dni = @dni;", conn))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        noSocioId = Convert.ToInt32(result);
                }
            }



            return noSocioId;
        }
    }
}
