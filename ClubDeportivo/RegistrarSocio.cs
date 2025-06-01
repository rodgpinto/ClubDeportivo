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


namespace ClubDeportivo
{
    public partial class fRegistrarSocio : Form
    {
        public fRegistrarSocio()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            dtpFechaPago.Format = DateTimePickerFormat.Custom;
            dtpFechaPago.CustomFormat = "dd/MM/yyyy";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";

        }

        private byte[]? fotoBytes;


        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblFichaInscripcion_Click(object sender, EventArgs e)
        {
            chkFicha.Checked = !chkFicha.Checked;
        }

        private void lblApto_Click(object sender, EventArgs e)
        {
            chkApto.Checked = !chkApto.Checked;
        }

        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            txtFechaVencimiento.Text = dtpFechaPago.Value.AddMonths(1).ToString("yyyy-MM-dd");
        }

        private void btnIngresarDato_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDocumento.Text == ""
                || txtDireccion.Text == "" || txtCuota.Text == ""
                || chkFicha.Checked == false || chkApto.Checked == false)
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
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
            {
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

                    dtpFechaPago.Value = DateTime.Now;

                    using (MySqlCommand cmd = new MySqlCommand("RegistrarPagoCuota", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("socioId", socioId);
                        cmd.Parameters.AddWithValue("precio", txtCuota.Text);
                        cmd.Parameters.AddWithValue("formaDePago", cboFormaDePago.Text);
                        cmd.Parameters.AddWithValue("fechaDePago", dtpFechaPago.Value);
                        cmd.Parameters.AddWithValue("fechaVencimiento", txtFechaVencimiento.Text);
                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd = new MySqlCommand("ActualizarCarnetSocio", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("socioId", socioId);
                        cmd.ExecuteNonQuery();
                    }

                    // Insertar imagen en la tabla carnet
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
                    string vencimiento = txtFechaVencimiento.Text;
                    string monto = txtCuota.Text;

                    MessageBox.Show("¡Socio registrado correctamente!");
                    fComprobantePago comprobantePago = new fComprobantePago(nombreCompleto, dni, formaPago, fechaPago, vencimiento, monto);
                    comprobantePago.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
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
            txtNombre.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            fRegistrar Registrar = new fRegistrar();
            Registrar.Show();
            Registrar.Close();
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            if (fotoBytes == null)
            {
                MessageBox.Show("Debe subir una foto antes de generar el carnet.",
                                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string nombreCompleto = txtNombre.Text + " " + txtApellido.Text;
            string dni = txtDocumento.Text;
            string fechaNacimiento = dtpFechaNacimiento.Value.ToString("dd/MM/yyyy");
            string fechaPago = dtpFechaPago.Value.ToString("dd/MM/yyyy");
            Image foto = picFoto.Image;


            Carnet carnet = new Carnet(nombreCompleto, dni, fechaNacimiento, fechaPago,  fotoBytes);
            carnet.ShowDialog();
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

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

    }
}
