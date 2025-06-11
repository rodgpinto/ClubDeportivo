using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Importa este namespace para usar MessageBox

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

        private Conexion()
        {
            // Intenta conectar usando los valores predefinidos
            while (true)
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
                    // Si hay una excepción, pide al usuario que ingrese los datos nuevamente
                    MessageBox.Show($"Error al conectar. " +
                                $"\nPor favor, ingrese los datos de conexión manualmente.", 
                                    "Error de conexión", 
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                IngresarDatos();
                }
            }
        }

        // Método para ingresar datos de conexión por medio de cuadros de diálogo
        private void IngresarDatos()
        {
            this.servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
            this.puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
            this.usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
            this.clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese clave", "DATOS DE INSTALACIÓN MySQL");
        }

        // Método estático para obtener la instancia de la conexión
        public static Conexion getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
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
