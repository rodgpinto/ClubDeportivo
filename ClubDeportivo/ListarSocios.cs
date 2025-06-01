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
        }
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

        private void picAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            fMainMenu MainMenu = new fMainMenu();
            MainMenu.Show();
            MainMenu.Close();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

                    int socioId = Convert.ToInt32(fila.Cells["id_socio"].Value);
                    string nombre = fila.Cells["nombre"].Value.ToString() ?? string.Empty;
                    string apellido = fila.Cells["apellido"].Value.ToString() ?? string.Empty;
                    string nombreCompleto = nombre + " " + apellido;
                    string dni = fila.Cells["dni"].Value.ToString() ?? string.Empty;
                    string fechaNacimiento = Convert.ToDateTime(fila.Cells["fecha_nacimiento"].Value).ToString("dd/MM/yyyy");
                    string fechaInscripcion = Convert.ToDateTime(fila.Cells["fecha_pago"].Value).ToString("dd/MM/yyyy");

                    Socio socio = new Socio();
                    byte[] fotoBytes = socio.ObtenerFotoPorSocioId(socioId);

                    Carnet carnet = new Carnet(nombreCompleto, dni, fechaNacimiento, fechaInscripcion, socioId, fotoBytes);
                    carnet.ShowDialog();
                }
            }
            catch
            {
            }
        }

    }
}
