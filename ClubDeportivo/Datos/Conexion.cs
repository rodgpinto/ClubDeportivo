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

        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        //Creamos la conexion a la base de datos
        private static Conexion? instancia = null;

        private Conexion()
        {

            bool correcto = false;
            int mensaje;

            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";

            while (correcto != true)
            {
                // Armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese clave", "DATOS DE INSTALACIÓN MySQL");

                if(T_servidor == "" || T_puerto == "" ||
                   T_usuario == "" || T_clave == "")
                {
                    MessageBox.Show("Debe completar todos los campos", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue; 
                }

                mensaje = (int)MessageBox.Show("Su ingreso: SERVIDOR = " +
                        T_servidor + ", PUERTO= " +
                        T_puerto + ", USUARIO: " +
                        T_usuario + ", CLAVE: " +
                        T_clave, "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
                this.baseDatos = "clubdeportivo";
                this.servidor = T_servidor; // "localhost";
                this.puerto = T_puerto; //"3306";
                this.usuario = T_usuario;
                this.clave = T_clave;
            }
        }
            

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

            string cadena = $"server={this.servidor};" +
                            $"port={this.puerto};" +
                            $"username={this.usuario}" +
                            $";password={this.clave};" +
                            $"Database={this.baseDatos}";

            MySqlConnection conexion = new MySqlConnection(cadena);
            return conexion;
        }
    }
}