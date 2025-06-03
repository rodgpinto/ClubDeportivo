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
    public partial class RegistrarNoSocio : Form
    {
        public RegistrarNoSocio()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;


            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaPago.Format = DateTimePickerFormat.Custom;
            dtpFechaPago.CustomFormat = "dd/MM/yyyy";
            dtpFechaPago.Value = DateTime.Now;
            dtpFechaVencimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaVencimiento.Value = DateTime.Now.AddDays(1);
        }
     
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void lblFichaInscripcion_Click(object sender, EventArgs e)
        {
            chkFicha.Checked = !chkFicha.Checked;

        }



        private void btnIngresarDato_Click(object sender, EventArgs e)
        {
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
                        cmd.Parameters.AddWithValue("@p_precio", txtActividad.Text);
                        cmd.Parameters.AddWithValue("@p_formaDePago", cboFormaDePago.Text);
                        cmd.Parameters.AddWithValue("@p_fechaDePago", dtpFechaPago.Value);
                        cmd.Parameters.AddWithValue("@p_actividad", cboActividad.Text);

                        idPagoActividad = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string nombreCompleto = txtNombre.Text + " " + txtApellido.Text;
                    string dni = txtDocumento.Text;
                    string formaPago = cboFormaDePago.Text;
                    string fechaPago = dtpFechaPago.Value.ToString("dd/MM/yyyy");
                    string vencimiento = dtpFechaVencimiento.Value.ToString("dd/MM/yyyy");
                    string monto = txtActividad.Text;
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            fRegistrar Registrar = new fRegistrar();
            Registrar.Show();
            Registrar.Close();
        }

       
    }
}
