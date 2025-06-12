using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    public partial class RegistrarNoSocio : Form
    {
        public RegistrarNoSocio()
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
            dtpFechaVencimiento.Value = DateTime.Now.AddDays(1);
        }

        // Evento que da check a la casilla de verificación al hacer clic en la etiqueta "lblFichaInscripcion"
        private void lblFichaInscripcion_Click(object sender, EventArgs e)
        {
            chkFicha.Checked = !chkFicha.Checked;

        }


        // Evento que valida los datos ingresados y registra al no socio en la base de datos
        private void btnIngresarDato_Click(object sender, EventArgs e)
        {
            // Validación de campos requeridos
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDocumento.Text == ""
                || txtDireccion.Text == "" || txtActividad.Text == ""
                || chkFicha.Checked == false || cboActividad.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            else if (txtActividad.Text == "0")
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
            else if (string.IsNullOrWhiteSpace(txtActividad.Text) || !decimal.TryParse(txtActividad.Text, out _))
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
            try
            {
                // Conexión a la base de datos y ejecución de procedimientos almacenados
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();
                    // Validación de existencia de persona con el mismo DNI
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
                    // Inserción de datos en las tablas Persona, NoSocio y PagoActividad
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
                    int noSocioId;
                    using (MySqlCommand cmd = new MySqlCommand("InsertarNoSocio", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@personaId", personaId);
                        cmd.Parameters.AddWithValue("@fichaInscripcion", chkFicha.Checked);

                        noSocioId = Convert.ToInt32(cmd.ExecuteScalar());
                    }


                    int idPagoActividad;
                    using (MySqlCommand cmd = new MySqlCommand("InsertarPagoActividad", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_NoSocio", noSocioId);
                        cmd.Parameters.AddWithValue("@p_pagado", true);
                        if (cboFormaDePago.SelectedIndex == 0)
                        {
                            decimal descuento = Convert.ToDecimal(txtActividad.Text) * 0.9m;
                            cmd.Parameters.AddWithValue("@p_precio", descuento);

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@p_precio", Convert.ToDecimal(txtActividad.Text));
                        }
                        cmd.Parameters.AddWithValue("@p_formaDePago", cboFormaDePago.Text);
                        cmd.Parameters.AddWithValue("@p_fechaDePago", dtpFechaPago.Value);
                        cmd.Parameters.AddWithValue("@p_actividad", cboActividad.Text);

                        idPagoActividad = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    // Si todo sale bien, mostramos un mensaje de éxito y el comprobante de pago
                    string nombreCompleto = txtNombre.Text + " " + txtApellido.Text;
                    string dni = txtDocumento.Text;
                    string formaPago = cboFormaDePago.Text;
                    string fechaPago = dtpFechaPago.Value.ToString("dd/MM/yyyy");
                    string vencimiento = dtpFechaVencimiento.Value.ToString("dd/MM/yyyy");
                    string monto = txtActividad.Text;
                    {

                        decimal descuento = Convert.ToDecimal(txtActividad.Text) * 0.9m;
                        monto = Convert.ToString(descuento);
                    }
                    string actividad = cboActividad.Text;

                    MessageBox.Show("¡Registro Exitoso!");
                    ComprobanteActividad comprobanteActividad = new ComprobanteActividad(nombreCompleto, dni, formaPago, fechaPago, vencimiento, monto, actividad);
                    comprobanteActividad.ShowDialog();
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Error de base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        // Evento que limpia los campos del formulario al hacer clic en el botón "Limpiar"
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtDireccion.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            chkFicha.Checked = false;
            txtActividad.Text = "";
            cboFormaDePago.SelectedIndex = -1;
            cboActividad.SelectedIndex = -1;
            txtNombre.Focus();
        }
        // Evento que cierra el formulario y regresa al formulario anterior al hacer clic en el botón "Volver"
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            fRegistrar Registrar = new fRegistrar();
            Registrar.Show();
            Registrar.Close();
        }

        private void lblAvisoDNI_MouseLeave(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.Show("Ingresa el DNI, sin puntos y sin espacios",
                          lblAvisoDNI,
                          lblAvisoDNI.Width, 0, 2500); // ms 
        }

        private void cboFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormaDePago.SelectedIndex == 0)
            {
                ToolTip toolTip2 = new ToolTip();
                toolTip2.Show("Se aplica un 10% de descuento",
                              lblDescuento,
                              lblDescuento.Width, 0, 2500);
            }
        }
    }
}
