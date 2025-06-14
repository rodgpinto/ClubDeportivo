using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    public partial class ModificarNoSocio : Form
    {
        public ModificarNoSocio()
        {
            InitializeComponent();

            // Inicializar el formulario con los controles deshabilitados
            btnConsultar.Enabled = false;
            grpbDatos.Enabled = false;
            btnIngresar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnEliminarNoSocio.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.None;

            // Configurar el DateTimePicker para mostrar la fecha en formato "dd/MM/yyyy"
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
        }


        // Evento para cerrar el formulario actual
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        // Evento para buscar un No Socio por su DNI
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.");
                return;
            }
            else if (dni.Contains(" ") || dni.Contains("."))
            {
                MessageBox.Show("El DNI no debe contener espacios ni puntos.");
                return;
            }
            else if (!int.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI debe tener 8 dígitos numéricos.");
                return;
            }

            NoSocio noSocio = new NoSocio();
            int? noSocioId = noSocio.ObtenerIdPorDNI(dni);

            if (noSocioId == null)
            {
                // Si no se encuentra el No Socio, mostrar un mensaje y preguntar si desea registrarlo
                DialogResult resultado = MessageBox.Show(
                    "El No Socio no existe. ¿Desea registrarlo ahora?",
                    "No Socio no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                grpbDatos.Enabled = false;


                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                    RegistrarNoSocio registroNoSocio = new RegistrarNoSocio();
                    registroNoSocio.ShowDialog();
                }
            }
            else
            {
                // Si se encuentra el No Socio, habilita los controles y muestra el ID del No Socio
                lblNoSocioID2.Text = noSocioId.ToString();
                MessageBox.Show("No Socio encontrado. Puede continuar.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConsultar.Enabled = true;
                btnEliminarNoSocio.Enabled = true;
                grpbDatos.Enabled = true;
                btnIngresar.Enabled = true;
                btnLimpiar.Enabled = true;


            }
        }

        // Evento para consultar los datos del No Socio ingresado por su DNI 
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.");
                return;
            }

            else if (dni.Contains(" ") || dni.Contains("."))
            {
                MessageBox.Show("El DNI no debe contener espacios ni puntos.");
                return;
            }
            else if (!int.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI debe tener 8 dígitos numéricos.");
                return;
            }

            try
            {
                NoSocio noSocio = new NoSocio();
                int? noSocioId = noSocio.ObtenerIdPorDNI(dni);

                if (noSocioId == null)
                {
                    MessageBox.Show("El socio no existe en el sistema.");
                    return;
                }

                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand(@"
                                                                SELECT n.id_NoSocio, 
                                                                       p.nombre, 
                                                                       p.apellido, 
                                                                       p.dni, 
                                                                       p.direccion, 
                                                                       p.fecha_nacimiento
                                                                FROM nosocios n
                                                                INNER JOIN persona p ON n.personaId = p.codigo
                                                                WHERE p.dni = @dni", conexion))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);



                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32("id_NoSocio");
                                string nombre = reader.GetString("nombre");
                                string apellido = reader.GetString("apellido");
                                string direccion = reader.GetString("direccion");
                                string dniLeido = reader.GetInt32("dni").ToString();

                                DateTime fechaNacimiento = reader["fecha_nacimiento"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["fecha_nacimiento"])
                                    : DateTime.MinValue;

                                // Mostrar formulario nuevo con los datos
                                ConsultarNoSocio consultaForm = new ConsultarNoSocio(id, nombre, apellido, dniLeido, direccion, fechaNacimiento);
                                this.Hide();
                                consultaForm.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron datos del socio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar datos: " + ex.Message);
            }
        }

        // Evento para eliminar por completo de la bse de datos un No Socio por su ID
        private void btnEliminarNoSocio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNoSocioID2.Text))
            {
                MessageBox.Show("Primero debe consultar un No Socio antes de poder eliminarlo.");
                return;
            }

            int idNoSocio = Convert.ToInt32(lblNoSocioID2.Text);

            // Confirmación antes de eliminar
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar por completo este No Socio y todos sus datos relacionados?",
                                                  "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            // Intentar eliminar el No Socio por su ID usando el Store Procedure 'EliminarNoSocioPorIDCompleto'
            try
            {
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand("EliminarNoSocioPorIDCompleto", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_nosocio", idNoSocio);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("No Socio eliminado correctamente.");
                    btnLimpiar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        // Evento para mostrar un tooltip al hacer clic en el label de aviso
        private void lblAviso_Click(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.Show("Este botón ELIMINA toda la informacion del No Socio",
                          lblAviso,
                          lblAviso.Width, 0, 2500); // ms 
        }


        // Evento para actualizar los datos del No Socio ingresado según los campos completados
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int idNoSocio = Convert.ToInt32(lblNoSocioID2.Text);

            string? nombre = string.IsNullOrWhiteSpace(txtNombre.Text) ? null : txtNombre.Text.Trim();
            string? apellido = string.IsNullOrWhiteSpace(txtApellido.Text) ? null : txtApellido.Text.Trim();
            string? dni = string.IsNullOrWhiteSpace(txtDNI2.Text) ? null : txtDNI2.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni) || dni.Contains("."))
            {
                MessageBox.Show("El DNI no debe contener espacios ni puntos.");
                return;
            }
            else if (!int.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI debe tener 8 dígitos numéricos.");
                return;
            }
            string? direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) ? null : txtDireccion.Text.Trim();
            DateTime? fechaNacimiento = dtpFechaNacimiento.Checked ? dtpFechaNacimiento.Value : (DateTime?)null;

            try
            {
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand("ActualizarDatosNoSocioParcial", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_nosocio", idNoSocio);
                        cmd.Parameters.AddWithValue("@p_nombre", (object?)nombre ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_apellido", (object?)apellido ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_dni", dni != null ? Convert.ToInt32(dni) : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_direccion", (object?)direccion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_fecha_nacimiento", fechaNacimiento.HasValue ? fechaNacimiento.Value : (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos del No Socio actualizados correctamente.");
                        btnLimpiar.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para limpiar todos los campos del formulario y deshabilitar los controles
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            lblNoSocioID2.Text = "";

            txtDNI.Focus();

            btnConsultar.Enabled = false;
            grpbDatos.Enabled = false;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI2.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtDireccion.Text = "";

            btnIngresar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnConsultar.Enabled = false;
            btnEliminarNoSocio.Enabled = false;
        }


        // Evento para cerrar el formulario actual
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAvisoDNI_MouseLeave(object sender, EventArgs e)
        {

            ToolTip toolTip1 = new ToolTip();
            toolTip1.Show("Ingresa el DNI, sin puntos y sin espacios",
                          lblAvisoDNI,
                          lblAvisoDNI.Width, 0, 2500); // ms 
        }
    }
}

