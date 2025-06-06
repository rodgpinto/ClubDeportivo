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

namespace ClubDeportivo
{
    public partial class fListarSocios : Form
    {
        public fListarSocios()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        // Evento que cierra el formulario actual y abre el menú principal
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            fMainMenu MainMenu = new fMainMenu();
            MainMenu.Show();
            MainMenu.Close();
        }

        // Evento que se ejecuta al cargar el formulario y trata de listar los socios en el DataGridView
        private void fListarSocios_Load(object sender, EventArgs e)
        {
            try
            {
                Socio datos = new Socio();
                DataTable tabla = datos.ListarSocios();
                dtgvRegistros.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los socios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Evento que se ejecuta al hacer clic en una celda del DataGridView y muestra el carnet del socio seleccionado
        private void dtgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow? fila = dtgvRegistros.Rows[e.RowIndex];
                    if (fila == null) return;

                    // Verificar si la fila tiene datos válidos
                    if (fila.Cells["id_socio"].Value == DBNull.Value ||
                        fila.Cells["nombre"].Value == DBNull.Value ||
                        fila.Cells["apellido"].Value == DBNull.Value ||
                        fila.Cells["dni"].Value == DBNull.Value ||
                        fila.Cells["fecha_nacimiento"].Value == DBNull.Value ||
                        fila.Cells["fecha_pago"].Value == DBNull.Value)
                    {
                        return;
                    }
                    // Obtener los datos del socio seleccionado
                    int socioId = Convert.ToInt32(fila.Cells["id_socio"].Value);
                    string nombre = fila.Cells["nombre"].Value.ToString() ?? string.Empty;
                    string apellido = fila.Cells["apellido"].Value.ToString() ?? string.Empty;
                    string nombreCompleto = nombre + " " + apellido;
                    int dni = Convert.ToInt32(fila.Cells["dni"].Value.ToString() ?? string.Empty);
                    string fechaNacimiento = Convert.ToDateTime(fila.Cells["fecha_nacimiento"].Value).ToString("dd/MM/yyyy");
                    string fechaInscripcion = Convert.ToDateTime(fila.Cells["fecha_pago"].Value).ToString("dd/MM/yyyy");


                    // Mostrar el carnet del socio
                    Socio socio = new Socio();
                    byte[] fotoBytes = socio.ObtenerFotoPorSocioId(socioId);


                    // Crear una instancia del formulario Carnet y pasar los datos del socio
                    Carnet carnet = new Carnet(dni);
                    carnet.ShowDialog();
                }
            }
            catch
            {
            }
        }



        
    }
}
