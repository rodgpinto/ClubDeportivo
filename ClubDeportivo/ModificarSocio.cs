using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace ClubDeportivo
{
    public partial class ModificarSocio : Form
    {
        public ModificarSocio()
        {
            InitializeComponent();
            // Inicializar el formulario con los controles deshabilitados

            btnConsultar.Enabled = false;
            btnEliminarSocio.Enabled = false;
            grpbDatos.Enabled = false;
            btnSubirFoto.Enabled = false;
            btnIngresar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnCarnet.Enabled = false;

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
        // Evento para buscar un socio por su DNI
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.");
                return;
            }

            else if(dni.Contains(" ") || dni.Contains("."))
            {
                MessageBox.Show("El DNI no debe contener espacios ni puntos.");
                return;
            }
            else if (!int.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI debe tener 8 dígitos numéricos.");
                return;
            }

            Socio socio = new Socio();
            int? socioId = socio.ObtenerIdPorDNI(dni);

            if (socioId == null)
            {
                // Si el socio no existe, mostrar un mensaje y preguntar si desea registrarlo
                DialogResult resultado = MessageBox.Show(
                    "El socio no existe. ¿Desea registrarlo ahora?",
                    "Socio no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                grpbDatos.Enabled = false;

                // Si el usuario acepta, abrir el formulario de registro de socio
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                    fRegistrarSocio formRegistro = new fRegistrarSocio();
                    formRegistro.ShowDialog();
                }
            }
            else
            {
                // Si el socio existe, habilitar los controles y mostrar el ID del socio
                lblSocioID2.Text = socioId.ToString();
                MessageBox.Show("Socio encontrado. Puede continuar.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConsultar.Enabled = true;
                btnEliminarSocio.Enabled = true;
                grpbDatos.Enabled = true;
                btnSubirFoto.Enabled = true;
                btnIngresar.Enabled = true;
                btnLimpiar.Enabled = true;
                btnCarnet.Enabled = true;


            }
        }


        // Evento para volver al formulario anterior
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        // Evento para consultar los datos del socio ingresado por su DNI
        private void btnConsultarSocio_Click(object sender, EventArgs e)
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
                // Verificar si el socio existe en la base de datos
                Socio socio = new Socio();
                int? socioId = socio.ObtenerIdPorDNI(dni);

                if (socioId == null)
                {
                    MessageBox.Show("El socio no existe en el sistema.");
                    return;
                }
                // Si el socio existe, consultar sus datos y mostrarlos en un nuevo formulario
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand(@"SELECT 
                                                                            p.codigo AS id,
                                                                            p.nombre,
                                                                            p.apellido,
                                                                            p.dni,
                                                                            p.direccion,
                                                                            p.fecha_nacimiento
                                                                        FROM persona p
                                                                        INNER JOIN socios s ON s.persona_id = p.codigo
                                                                        WHERE s.id_Socio = @id", conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", socioId);


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                string nombre = reader.GetString("nombre");
                                string apellido = reader.GetString("apellido");
                                string direccion = reader.GetString("direccion");
                                string dniLeido = reader.GetInt32("dni").ToString();
                                DateTime fechaNacimiento = reader.GetDateTime("fecha_nacimiento");

                                // Mostrar formulario nuevo con los datos
                                ConsultarSocio consultaForm = new ConsultarSocio(id, nombre, apellido, dniLeido, direccion, fechaNacimiento);
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

        // Evento para eliminar completamente todo lo referido a un socio de la base de datos
        private void btnEliminarSocio_Click(object sender, EventArgs e)
        {
            // Confirmación antes de eliminar el socio
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este registro?",
                                      "Confirmar eliminación",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);
            try
            {
                // Si el usuario confirma, proceder a eliminar el socio, utilizando el Store Procedure 'EliminarSocioCompleto'
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                    {
                        conexion.Open();

                        using (MySqlCommand cmd = new MySqlCommand("EliminarSocioCompleto", conexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@p_dni", Convert.ToInt32(txtDNI.Text.Trim()));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Socio eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLimpiar.PerformClick();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para mostrar un tooltip al hacer clic en el label de aviso
        private void lblAviso_Click(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.Show("Este botón ELIMINA toda la informacion del Socio",
                          lblAviso,
                          lblAviso.Width, 0, 2500); // ms 
        }

        private void lblAvisoDNI_Click(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.Show("Ingresa el DNI, sin puntos y sin espacios",
                          lblAvisoDNI,
                          lblAvisoDNI.Width, 0, 2500); // ms 
        }
        private void lblAvisoDNI_MouseLeave(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.Show("Ingresa el DNI, sin puntos y sin espacios",
                          lblAvisoDNI,
                          lblAvisoDNI.Width, 0, 2500); // ms 
        }

        private byte[]? fotoBytes;

        // Evento para subir una foto del socio desde el disco duro
        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            // Abrir un diálogo para seleccionar una imagen
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            // Si el usuario selecciona una imagen, cargarla en el PictureBox y guardarla en memoria
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);

                picFoto.Image = img;
                picFoto.SizeMode = PictureBoxSizeMode.Zoom;

                // Guardar la imagen en memoria sin perder calidad (mismo formato que la original)
                using (MemoryStream ms = new MemoryStream())
                {
                    string extension = Path.GetExtension(ofd.FileName).ToLower();
                    ImageFormat formato = ImageFormat.Jpeg;

                    if (extension == ".png")
                        formato = ImageFormat.Png;
                    else if (extension == ".bmp")
                        formato = ImageFormat.Bmp;

                    img.Save(ms, formato);
                    fotoBytes = ms.ToArray();
                }
            }
        }
        // Evento para cargar los datos de los campos utilizados
        private void btnIngresar_Click(object sender, EventArgs e)
        {

        
            int idSocio = Convert.ToInt32(lblSocioID2.Text);

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

            byte[]? fotoBytes = null;
            if (picFoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picFoto.Image.Save(ms, picFoto.Image.RawFormat);
                    fotoBytes = ms.ToArray();
                }
            }

            try
            {
                // Actualizar los datos del socio utilizando el Store Procedure 'ActualizarDatosSocioParcial'
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand("ActualizarDatosSocioParcial", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_socio", idSocio);
                        cmd.Parameters.AddWithValue("@p_nombre", (object?)nombre ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_apellido", (object?)apellido ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_dni", dni != null ? Convert.ToInt32(dni) : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_direccion", (object?)direccion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_fecha_nacimiento", fechaNacimiento.HasValue ? fechaNacimiento.Value : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_foto", (object?)fotoBytes ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos actualizados correctamente.");
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
            lblSocioID2.Text = "";

            txtDNI.Focus();

            btnConsultar.Enabled = false;
            grpbDatos.Enabled = false;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI2.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtDireccion.Text = "";
            picFoto.Image = null;

            btnSubirFoto.Enabled = false;
            btnIngresar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnCarnet.Enabled = false;

        }

        // Evento para abrir el formulario del carnet del socio
        private void btnCarnet_Click(object sender, EventArgs e)
        {
            try
            {
                string dniText = txtDNI.Text;
                int dni = Convert.ToInt32(dniText);
                Carnet carnet = new Carnet(dni);
                carnet.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}


