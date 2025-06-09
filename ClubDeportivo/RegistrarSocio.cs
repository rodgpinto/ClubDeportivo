using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ClubDeportivo
{
    public partial class fRegistrarSocio : Form
    {
        public fRegistrarSocio()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            // Modificamos el formato de los DateTimePicker para que muestren la fecha en el formato "dd/MM/yyyy"
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaPago.Format = DateTimePickerFormat.Custom;
            dtpFechaPago.CustomFormat = "dd/MM/yyyy";
            dtpFechaPago.Value = DateTime.Now;
            dtpFechaVencimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            // Establecemos la fecha de vencimiento como un mes a partir de hoy
            dtpFechaVencimiento.Value = DateTime.Now.AddMonths(1);
            btnCarnet.Visible = false;

        }

        private byte[]? fotoBytes;

        // Evento que cierra el formulario actual y regresa al formulario anterior
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        // Evento que da check a la casilla de verificación al hacer clic en la etiqueta "lblFichaInscripcion"
        private void lblFichaInscripcion_Click(object sender, EventArgs e)
        {
            chkFicha.Checked = !chkFicha.Checked;
        }
        // Evento que da check a la casilla de verificación al hacer clic en la etiqueta "lblApto"
        private void lblApto_Click(object sender, EventArgs e)
        {
            chkApto.Checked = !chkApto.Checked;
        }


        // Evento que valida los datos ingresados y registra al socio en la base de datos
        private void btnIngresarDato_Click(object sender, EventArgs e)
        {
            // Validación de campos requeridos
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDocumento.Text == ""
                || txtDireccion.Text == "" || txtCuota.Text == ""
                || chkFicha.Checked == false || chkApto.Checked == false)
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            else if (txtCuota.Text == "0")
            {
                MessageBox.Show("El monto de la cuota no puede ser 0.",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(txtDocumento.Text, out _))
            {
                MessageBox.Show("El DNI debe ser un número válido.",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            else if (txtDocumento.Text.Contains(" ") || txtDocumento.Text.Contains("."))
            {
                MessageBox.Show("El DNI no debe contener espacios ni puntos.");
                return;
            }
            else if (!int.TryParse(txtDocumento.Text, out _))
            {
                MessageBox.Show("El DNI debe tener 8 dígitos numéricos.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtCuota.Text) || !decimal.TryParse(txtCuota.Text, out _))
            {
                MessageBox.Show("El monto de la cuota debe ser un número válido.",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            else if (cboFormaDePago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una forma de pago.",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (fotoBytes == null)
            {
                MessageBox.Show("Debe subir una foto para el carnet.",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            try
            { // Verificar si ya existe una persona con el mismo DNI
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    string validarPersona = "ValidarPersona";

                    using (MySqlCommand cmd = new MySqlCommand(validarPersona, conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_dni", Convert.ToInt32(txtDocumento.Text));

                        int existe = Convert.ToInt32(cmd.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show("Ya existe una persona registrada con ese DNI.",
                                            "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    // Insertar persona y socio en la base de datos
                    int personaId;
                    using (MySqlCommand cmd = new MySqlCommand("InsertarPersona", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("apellido", txtApellido.Text);
                        cmd.Parameters.AddWithValue("dni", Convert.ToInt32(txtDocumento.Text));
                        cmd.Parameters.AddWithValue("direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("fechaNacimiento", dtpFechaNacimiento.Value);
                        personaId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    int socioId;
                    using (MySqlCommand cmd = new MySqlCommand("InsertarSocio", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@personaId", personaId);
                        cmd.Parameters.AddWithValue("@fichaInscripcion", chkFicha.Checked);
                        cmd.Parameters.AddWithValue("aptoFisico", chkApto.Checked);
                        socioId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    // Registrar el pago de la cuota del socio
                    using (MySqlCommand cmd = new MySqlCommand("RegistrarPagoCuota", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("socioId", socioId);
                        cmd.Parameters.AddWithValue("precio", txtCuota.Text);
                        cmd.Parameters.AddWithValue("formaDePago", cboFormaDePago.Text);
                        cmd.Parameters.AddWithValue("fechaDePago", dtpFechaPago.Value);
                        cmd.Parameters.AddWithValue("fechaVencimiento", dtpFechaVencimiento.Value);
                        cmd.ExecuteNonQuery();
                    }
                    // Actualizar el carnet del socio con la foto subida
                    using (MySqlCommand cmd = new MySqlCommand("ActualizarCarnetSocio", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("socioId", socioId);
                        cmd.ExecuteNonQuery();
                    }
                    // Insertar la foto en la tabla carnet
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO carnet (socioId, foto) VALUES (@socioId, @foto)", conexion))
                    {
                        cmd.Parameters.AddWithValue("@socioId", socioId);
                        cmd.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = fotoBytes;
                        cmd.ExecuteNonQuery();
                    }

                    // Mostrar comprobante
                    string nombreCompleto = txtNombre.Text + " " + txtApellido.Text;
                    string dni = txtDocumento.Text;
                    string formaPago = cboFormaDePago.Text;
                    string fechaPago = dtpFechaPago.Value.ToString("dd/MM/yyyy");
                    string vencimiento = dtpFechaVencimiento.Value.ToString("dd/MM/yyyy");
                    string monto = txtCuota.Text;

                    MessageBox.Show("¡Socio registrado correctamente!");

                    //  Mostrar el comprobante de pago en un nuevo formulario
                    fComprobantePago comprobantePago = new fComprobantePago(nombreCompleto, dni, formaPago, fechaPago, vencimiento, monto);
                    comprobantePago.ShowDialog();
                    btnCarnet.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Evento que limpia los campos del formulario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Focus();
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtDireccion.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            chkApto.Checked = false;
            chkFicha.Checked = false;
            txtCuota.Text = "";
            cboFormaDePago.SelectedIndex = 0;
            picFoto.Image = null;
            fotoBytes = null;
            btnCarnet.Visible = false;

        }
        // Evento que cierra el formulario actual y regresa al formulario anterior
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            fRegistrar Registrar = new fRegistrar();
            Registrar.Show();
            Registrar.Close();
        }
        // Evento que genera el carnet del socio con la foto subida
        private void btnCarnet_Click(object sender, EventArgs e)
        {
            try
            { // Verificar si se ha subido una foto
                if (fotoBytes == null)
                {
                    MessageBox.Show("Debe subir una foto antes de generar el carnet.",
                                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                // Generar el carnet del socio
                string nombreCompleto = txtNombre.Text + " " + txtApellido.Text;
                int dni = Convert.ToInt32(txtDocumento.Text);
                string fechaNacimiento = dtpFechaNacimiento.Value.ToString("dd/MM/yyyy");
                string fechaPago = dtpFechaPago.Value.ToString("dd/MM/yyyy");

                Image foto = picFoto.Image;

                // Crear una instancia del formulario Carnet y le pasa los datos necesarios
                Carnet carnet = new Carnet(dni);
                carnet.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Evento que permite al usuario subir una foto para el carnet del socio
        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            // Abrir un diálogo para seleccionar una imagen
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);

                picFoto.Image = img;
                picFoto.SizeMode = PictureBoxSizeMode.Zoom;

                // Guardar la imagen en memoria sin perder calidad (mismo formato que la original)
                using (MemoryStream ms = new MemoryStream())
                {// Determinar el formato de la imagen y guardarla en un array de bytes
                    string extension = Path.GetExtension(ofd.FileName).ToLower();
                    ImageFormat formato = ImageFormat.Jpeg;
                    // dependiendo de la extensión, establecer el formato correcto
                    if (extension == ".png")
                        formato = ImageFormat.Png;
                    else if (extension == ".bmp")
                        formato = ImageFormat.Bmp;
                    // si es JPEG o JPG, se deja como está
                    else if (extension == ".jpeg" || extension == ".jpg")
                        formato = ImageFormat.Jpeg;
                    // Guardar la imagen en el MemoryStream con el formato adecuado
                    img.Save(ms, formato);
                    fotoBytes = ms.ToArray();
                }
            }
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
