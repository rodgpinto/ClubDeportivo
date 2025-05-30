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


        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnIngresarDato_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDocumento.Text == ""
                || txtDocumento.Text == "" || txtDireccion.Text == "" || txtCuota.Text == ""
                || chkFicha.Checked == false || chkApto.Checked == false)
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
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
                            MessageBox.Show("Ya existe una persona registrada con ese nombre, apellido o DNI.",
                                            "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string InsertarPersona = "InsertarPersona";



                    int personaId;

                    using (MySqlCommand cmd = new MySqlCommand(InsertarPersona, conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("apellido", txtApellido.Text);
                        cmd.Parameters.AddWithValue("dni", Convert.ToInt32(txtDocumento.Text));
                        cmd.Parameters.AddWithValue("direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("fechaNacimiento", dtpFechaNacimiento.Value);

                        personaId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string InsertarSocio = "InsertarSocio";

                    int socioId;
                    bool ficha = chkFicha.Checked;
                    bool apto = chkApto.Checked;

                    using (MySqlCommand cmd = new MySqlCommand(InsertarSocio, conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@personaId", personaId);
                        cmd.Parameters.AddWithValue("@fichaInscripcion", ficha);
                        cmd.Parameters.AddWithValue("aptoFisico", apto);

                        socioId = Convert.ToInt32(cmd.ExecuteScalar());
                    }


                    string registrarPago = "RegistrarPagoCuota";
                    dtpFechaPago.Value = DateTime.Now;
                    cboFormaDePago.SelectedIndex = 0;


                    using (MySqlCommand cmd = new MySqlCommand(registrarPago, conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("socioId", socioId);
                        cmd.Parameters.AddWithValue("precio", txtCuota.Text);

                        cmd.Parameters.AddWithValue("formaDePago", cboFormaDePago.Text);
                        cmd.Parameters.AddWithValue("fechaDePago", dtpFechaPago.Value);
                        cmd.Parameters.AddWithValue("fechaVencimiento", txtFechaVencimiento.Text);


                        cmd.ExecuteNonQuery();
                    }


                    string actualizarCarnet = "ActualizarCarnetSocio";

                    using (MySqlCommand cmd = new MySqlCommand(actualizarCarnet, conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("socioId", socioId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("¡Socio registrado correctamente!");

                    string nombreCompleto = txtNombre.Text + " " + txtApellido.Text;
                    string dni = txtDocumento.Text;
                    string formaPago = cboFormaDePago.Text;
                    string fechaPago = dtpFechaPago.Value.ToString("dd/MM/yyyy");
                    string vencimiento = txtFechaVencimiento.Text;
                    string monto = txtCuota.Text;
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
            txtNombre.Focus();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            fRegistrar Registrar = new fRegistrar();
            Registrar.Show();
            Registrar.Close();
        }


        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            txtFechaVencimiento.Text = dtpFechaPago.Value.AddMonths(1).ToString("yyyy-MM-dd");
        }

       
    }
}

