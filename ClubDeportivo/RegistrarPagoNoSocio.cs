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
    public partial class RegistrarPagoNoSocio : Form
    {
        public RegistrarPagoNoSocio()
        {
            InitializeComponent();
            // Inicializamos el formulario con foco en el campo de texto para el DNI
            txtDNI.Focus();
            // Deshabilitamos el grupo de pago y los botones hasta que se encuentre un No Socio
            grpbPago.Enabled = false;
            btnIngresarPago.Enabled = false;
            btnLimpiar.Enabled = false;
            btnConsultarPagos.Enabled = false;


            this.FormBorderStyle = FormBorderStyle.None;

            // Modificamos el formato de los DateTimePicker para que muestren la fecha en el formato "dd/MM/yyyy"
            dtpFechaPago.Format = DateTimePickerFormat.Custom;
            dtpFechaPago.CustomFormat = "dd/MM/yyyy";
            dtpFechaPago.Value = DateTime.Now;
            // Establecemos la fecha de vencimiento como un día después de la fecha de pago
            txtFechaVencimiento.Text = dtpFechaPago.Value.AddDays(1).ToString("dd/MM/yyyy");
        }

        // Evento que cierra el formulario y regresa al formulario anterior
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // Evento que busca al No Socio por su DNI ingresado en el campo de texto
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
                //  Si no se encuentra el No Socio, mostramos un mensaje y preguntamos si desea registrarlo
                DialogResult resultado = MessageBox.Show(
                    "El No Socio no existe. ¿Desea registrarlo ahora?",
                    "No se encontro al NoSocio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                grpbPago.Enabled = false;

                // Si el usuario acepta, cerramos el formulario actual y abrimos el formulario de registro de No Socio
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                    RegistrarNoSocio formRegistroNoSocio = new RegistrarNoSocio();
                    formRegistroNoSocio.ShowDialog();
                }
            }
            else
            {
                // Si se encuentra el No Socio, habilitamos el grupo de pago y los botones
                lblNoSocioID2.Text = noSocioId.ToString();
                MessageBox.Show("Se encontro al NoSocio. Puede continuar con el pago.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpbPago.Enabled = true;
                btnIngresarPago.Enabled = true;
                btnLimpiar.Enabled = true;
                btnConsultarPagos.Enabled = true;

            }
        }

        // Evento que valida los datos ingresados y registra el pago del No Socio en la base de datos
        private void btnIngresarPago_Click(object sender, EventArgs e)
        {
            // Validación de campos requeridos
            try
            {
                if (!decimal.TryParse(txtCuota.Text, out decimal cuota) || cuota <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un monto válido.");
                    return;
                }

                if (cboFormaDePago.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una forma de pago.");
                    return;
                }

                if (cboActividad.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una actividad.");
                    return;
                }

                int idNoSocio;
                if (!int.TryParse(lblNoSocioID2.Text, out idNoSocio))
                {
                    MessageBox.Show("ID del No Socio inválido.");
                    return;
                }

                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    string insertQuery = @"INSERT INTO pago_actividad 
                (id_NoSocio, pagado, precio, formaDePago, fechaDePago, actividad)
                VALUES (@id_NoSocio, @pagado, @precio, @formaDePago, @fechaDePago, @actividad)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id_NoSocio", idNoSocio);
                        cmd.Parameters.AddWithValue("@pagado", true);
                        if (cboFormaDePago.SelectedIndex == 0)
                        {
                            decimal descuento = Convert.ToDecimal(txtCuota.Text) * 0.9m;
                            cmd.Parameters.AddWithValue("@precio", descuento);

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtCuota.Text));
                        }
                        cmd.Parameters.AddWithValue("@formaDePago", cboFormaDePago.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@fechaDePago", dtpFechaPago.Value.Date);
                        cmd.Parameters.AddWithValue("@actividad", cboActividad.SelectedItem.ToString());

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show("No se insertó ningún registro.");
                            return;
                        }
                    }
                    // Obtenemos el nombre y apellido del No Socio para generar el comprobante
                    string nombre = "", apellido = "";
                    using (MySqlCommand cmdNombre = new MySqlCommand(@"
                SELECT p.nombre, p.apellido 
                FROM persona p
                INNER JOIN nosocios ns ON ns.personaId = p.codigo
                WHERE ns.id_NoSocio = @id", conexion))
                    {
                        cmdNombre.Parameters.AddWithValue("@id", idNoSocio);
                        using (MySqlDataReader reader = cmdNombre.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombre = reader.GetString("nombre");
                                apellido = reader.GetString("apellido");
                            }
                        }
                    }
                    // Generamos el comprobante de pago con los datos del No Socio y el pago realizado
                    string nombreCompleto = nombre + " " + apellido;
                    string dni = txtDNI.Text;
                    string formaPago = cboFormaDePago.Text;
                    string fechaPago = dtpFechaPago.Value.ToString("dd/MM/yyyy");
                    string vencimiento = dtpFechaPago.Value.AddDays(1).ToString("dd/MM/yyyy");
                    string actividad = cboActividad.Text.ToString();
                    string monto = txtCuota.Text;
                    if (cboFormaDePago.SelectedIndex == 0)
                    {

                        decimal descuento = Convert.ToDecimal(txtCuota.Text) * 0.9m;
                        monto = Convert.ToString(descuento);
                    }
                    // Creamos el comprobante de actividad y lo mostramos
                    ComprobanteActividad comprobante = new ComprobanteActividad(nombreCompleto, dni, formaPago, fechaPago, vencimiento, monto, actividad);
                    comprobante.ShowDialog();

                    MessageBox.Show("Pago registrado correctamente.");
                    btnLimpiar.PerformClick();
                }

              

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Evento que consulta los pagos realizados por el No Socio y muestra un historial
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
                NoSocio noSocio = new NoSocio();
                int? noSocioId = noSocio.ObtenerIdPorDNI(dni);

                if (noSocioId == null)
                {
                    MessageBox.Show("El no socio no existe en el sistema.");
                    return;
                }

                // Utilizamos el Store Procedure "VerPagosPorNoSocio" para obtener los pagos del No Socio
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand("VerPagosPorNoSocio", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_noSocioId", noSocioId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable tablaPagos = new DataTable();
                            adapter.Fill(tablaPagos);

                            HistorialPagosNoSocios historial = new HistorialPagosNoSocios(tablaPagos);
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



        // Evento que limpia los campos del formulario al hacer clic en el botón "Limpiar"
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtDNI.Focus();
            lblNoSocioID2.Text = "";
            cboActividad.SelectedIndex = -1;
            dtpFechaPago.Value = DateTime.Now;
            txtCuota.Text = "";
            cboFormaDePago.SelectedIndex = -1;
            txtDNI.Focus();
            grpbPago.Enabled = false;
            btnIngresarPago.Enabled = false;
            btnLimpiar.Enabled = false;
            btnConsultarPagos.Enabled = false;
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
