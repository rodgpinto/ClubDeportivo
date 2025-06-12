using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 
namespace ClubDeportivo.Datos
{
    internal class Conexion
    {
        // Atributos para almacenar los datos de conexión
        private string baseDatos = "clubdeportivo";
        private string servidor = "localhost";
        private string puerto = "3306";
        private string usuario = "root";
        private string clave = "1234";
        private static Conexion? instancia = null;
        private bool condicion = true;
        private Conexion()
        {
            // Intenta conectar usando los valores predefinidos
            while (condicion)
            {
                try
                {
                    // Intenta crear una conexión con los valores predefinidos
                    MySqlConnection conexion = CrearConexion();
                    conexion.Open();
                    conexion.Close();
                    break; // Si la conexión tiene éxito, sale del bucle
                }
                catch (Exception)
                {
                    // Si hay alguna diferencia, pide al usuario que ingrese los datos nuevamente
                    DialogResult result = MessageBox.Show($"Error al conectar. " +
                                 $"\n¿Desea ingresar los datos de conexión manualmente?",
                                     "Error de conexión",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        // invoca el método para ingresar los datos de conexión
                        IngresarDatos();
                    }
                    else
                    {   // Si el usuario no quiere ingresar los datos, lanza una excepción
                        throw new Exception("El usuario canceló la configuración de conexión.");

                    }

                }
            }
        }

        // Método para ingresar datos de conexión por medio de cuadros de diálogo
        private void IngresarDatos()
        {
            this.servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese servidor", "DATOS DE CONEXIÓN MySQL", servidor);
            this.puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL", puerto);
            this.usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese usuario", "DATOS DE CONEXIÓN MySQL", usuario);
            this.clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese clave", "DATOS DE CONEXIÓN MySQL", clave);
        }

        // Método estático para obtener la instancia de la conexión
        public static Conexion getInstancia()
        {
            //Si instancia es null intenta establecer conexión
            if (instancia == null)
                try
                {

                    instancia = new Conexion();

                }
                catch (Exception)
                {   // Si no se puede establecer la conexión, muestra un mensaje de error y cierra la aplicación
                    MessageBox.Show($"El programa se cerrará.", "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                    return null;
                }
            return instancia;
        }

        // Método para crear la conexión a la base de datos
        public MySqlConnection CrearConexion()
        {
            string cadena = $"server={this.servidor};" +
                            $"port={this.puerto};" +
                            $"username={this.usuario};" +
                            $"password={this.clave};" +
                            $"Database={this.baseDatos}";

            MySqlConnection conexion = new MySqlConnection(cadena);
            return conexion;
        }
    }
}
