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

            // Deshabilitar los controles del grupo de pago al inicio
            grpbPago.Enabled = false;
            btnIngresarPago.Enabled = false;
            btnLimpiar.Enabled = false;
            btnConsultarPagos.Enabled = false;


            this.FormBorderStyle = FormBorderStyle.None;

            // Modificamos el formato de los DateTimePicker para que muestren la fecha en el formato "dd/MM/yyyy"
            dtpFechaPago.Format = DateTimePickerFormat.Custom;
            dtpFechaPago.CustomFormat = "dd/MM/yyyy";
            dtpFechaPago.Value = DateTime.Now;
            dtpFechaVencimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaVencimiento.Value = DateTime.Now.AddMonths(1);


        }


        // Evento que cierra el formulario actual y regresa al formulario anterior
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // Evento que busca al socio por su DNI ingresado y habilita los controles de pago si el socio existe
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

            Socio socio = new Socio();
            int? socioId = socio.ObtenerIdPorDNI(dni);

            if (socioId == null)
            {
                // Si el socio no existe, mostramos un mensaje y preguntamos si desea registrarlo
                DialogResult resultado = MessageBox.Show(
                    "El socio no existe. ¿Desea registrarlo ahora?",
                    "Socio no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                grpbPago.Enabled = false;

                // Si el usuario acepta, cerramos el formulario actual y abrimos el formulario de registro de socio
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                    fRegistrarSocio formRegistro = new fRegistrarSocio();
                    formRegistro.ShowDialog();
                }
            }
            else
            {
                // Si el socio existe, habilitamos los controles de pago
                lblSocioID2.Text = socioId.ToString();
                MessageBox.Show("Socio encontrado. Puede continuar con el pago.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpbPago.Enabled = true;
                btnIngresarPago.Enabled = true;
                btnLimpiar.Enabled = true;
                btnConsultarPagos.Enabled = true;

            }
        }



        // Evento que valida los datos ingresados y registra el pago de la cuota del socio
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


                // Registrar el pago en la base de datos usando el Store Procedure 'RegistrarPagoCuota'
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand("RegistrarPagoCuota", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@socioId", lblSocioID2.Text);
                        cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtCuota.Text));
                        cmd.Parameters.AddWithValue("@formaDePago", cboFormaDePago.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@fechaVencimiento", dtpFechaVencimiento.Value);
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
                    // Generar el comprobante de pago
                    string nombreCompleto = nombre + " " + apellido;
                    string dni = txtDNI.Text;
                    string formaPago = cboFormaDePago.Text;
                    string fechaPago = dtpFechaPago.Value.ToString("dd/MM/yyyy");
                    string vencimiento = dtpFechaVencimiento.Value.ToString("dd/MM/yyyy"); ;
                    string monto = txtCuota.Text;
                    // Mostrar el comprobante de pago en un nuevo formulario
                    fComprobantePago comprobante = new fComprobantePago(nombreCompleto, dni, formaPago, fechaPago, vencimiento, monto);
                    comprobante.ShowDialog();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // Evento que limpia los campos del formulario y deshabilita los controles de pago
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

        // Evento que consulta los pagos realizados por el socio ingresado y muestra el historial en un nuevo formulario
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
                int? socioId = socio.ObtenerIdPorDNI(dni);

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

        private void lblAvisoDNI_MouseLeave(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.Show("Ingresa el DNI, sin puntos y sin espacios",
                          lblAvisoDNI,
                          lblAvisoDNI.Width, 0, 2500); // ms 
        }
    }
}
