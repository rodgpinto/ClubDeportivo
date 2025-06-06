using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    // Creamos la clase abstracta Persona con atributos comunes para Socio y No Socio
    public abstract class Persona
    {
        protected int codigo;
        protected string nombre;
        protected string apellido;
        protected string dni;
        protected string direccion;

        protected DateTime fechaNacimiento;

        //Constructor protegido para evitar instanciación directa
        protected Persona()
        {
        }

        // Encapsulamiento de propiedades
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string DNI { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }


        //Método para listar personas (lo utilizaremos en Socio)
        public static DataTable ListarPersonas(string mensaje)
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
                throw new Exception("Error al listar: "+mensaje + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return tabla;
        }


        //Método para obtener tanto socio como no socio segun el DNI
        public virtual int? ObtenerIdPorDNI(string dni)
        {
            int? id = null;

            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(@"
                        SELECT Codigo FROM persona 
                        WHERE dni = @dni;", conn))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        id = Convert.ToInt32(result);
                }
            }

            return id;
        }


    }
}