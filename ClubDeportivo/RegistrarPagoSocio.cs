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
    public partial class RegistrarPagoSocio : Form
    {
        public RegistrarPagoSocio()
        {
            InitializeComponent();

            grpbPago.Enabled = false;
            btnIngresarPago.Enabled = false;
            btnLimpiar.Enabled = false;
            btnConsultarPagos.Enabled = false;


            this.FormBorderStyle = FormBorderStyle.None;

            dtpFechaPago.Format = DateTimePickerFormat.Custom;
            dtpFechaPago.CustomFormat = "dd/MM/yyyy";
            dtpFechaPago.Value = DateTime.Now;

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrarPago registrarPago = new RegistrarPago();
            registrarPago.Show();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.");
                return;
            }

            Socio socio = new Socio();
            int? socioId = socio.ObtenerIdSocioPorDNI(dni);

            if (socioId == null)
            {
                DialogResult resultado = MessageBox.Show(
                    "El socio no existe. ¿Desea registrarlo ahora?",
                    "Socio no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                grpbPago.Enabled = false;


                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                    fRegistrarSocio formRegistro = new fRegistrarSocio();
                    formRegistro.ShowDialog();
                }
            }
            else
            {
                lblSocioID2.Text = socioId.ToString();
                MessageBox.Show("Socio encontrado. Puede continuar con el pago.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpbPago.Enabled = true;
                btnIngresarPago.Enabled = true;
                btnLimpiar.Enabled = true;
                btnConsultarPagos.Enabled = true;

            }
        }



        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            txtFechaVencimiento.Text = dtpFechaPago.Value.AddMonths(1).ToString("yyyy-MM-dd");

        }
        private void btnIngresarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtCuota.Text, out decimal cuota) || cuota <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un monto de cuota válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboFormaDePago.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una forma de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtFechaVencimiento.Text))
                {
                    MessageBox.Show("Por favor, ingrese una fecha de vencimiento válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand("RegistrarPagoCuota", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@socioId", lblSocioID2.Text);
                        cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtCuota.Text));
                        cmd.Parameters.AddWithValue("@formaDePago", cboFormaDePago.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@fechaVencimiento", txtFechaVencimiento.Text);
                        cmd.Parameters.AddWithValue("@fechaDePago", dtpFechaPago.Value.Date);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Pago registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string nombre = "", apellido = "";

                    using (MySqlCommand cmdNombre = new MySqlCommand("SELECT p.nombre, p.apellido FROM persona p INNER JOIN socios s ON p.codigo = s.persona_id WHERE s.id_Socio = @id", conexion))
                    {
                        cmdNombre.Parameters.AddWithValue("@id", lblSocioID2.Text);

                        using (MySqlDataReader reader = cmdNombre.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombre = reader.GetString("nombre");
                                apellido = reader.GetString("apellido");
                            }
                        }
                    }

                    string nombreCompleto = nombre + " " + apellido;
                    string dni = txtDNI.Text;
                    string formaPago = cboFormaDePago.Text;
                    string fechaPago = dtpFechaPago.Value.ToString("dd/MM/yyyy");
                    string vencimiento = txtFechaVencimiento.Text;
                    string monto = txtCuota.Text;
                    fComprobantePago comprobante = new fComprobantePago(nombreCompleto, dni, formaPago, fechaPago, vencimiento, monto);
                    comprobante.ShowDialog();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            lblSocioID2.Text = "";
            dtpFechaPago.Value = DateTime.Now;
            txtCuota.Text = "";
            cboFormaDePago.SelectedIndex = -1;
            txtDNI.Focus();
            grpbPago.Enabled = false;
            btnIngresarPago.Enabled = false;
            btnLimpiar.Enabled = false;
            btnConsultarPagos.Enabled = false;
        }

        private void btnConsultarPagos_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI.");
                return;
            }

            try
            {
                Socio socio = new Socio();
                int? socioId = socio.ObtenerIdSocioPorDNI(dni);

                if (socioId == null)
                {
                    MessageBox.Show("El socio no existe en el sistema.");
                    return;
                }

                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand("VerPagosPorSocio", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_socioId", socioId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable tablaPagos = new DataTable();
                            adapter.Fill(tablaPagos);

                            // Mostrar en el nuevo formulario
                            HistorialPagosSocios historial = new HistorialPagosSocios(tablaPagos);
                            historial.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar pagos: " + ex.Message);
            }
        }


    }
}
