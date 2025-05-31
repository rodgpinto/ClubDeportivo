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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow? fila = dtgvRegistros.Rows[e.RowIndex];
                if (fila == null) return;

                int socioId = Convert.ToInt32(fila.Cells["id_socio"]?.Value ?? 0);
                string nombre = fila.Cells["nombre"]?.Value?.ToString() ?? string.Empty;
                string apellido = fila.Cells["apellido"]?.Value?.ToString() ?? string.Empty;
                string nombreCompleto = nombre + " " + apellido;
                string dni = fila.Cells["dni"]?.Value?.ToString() ?? string.Empty;
                string fechaNacimiento = fila.Cells["fecha_nacimiento"]?.Value != null
                    ? Convert.ToDateTime(fila.Cells["fecha_nacimiento"].Value).ToString("dd/MM/yyyy")
                    : string.Empty;
                string fechaInscripcion = fila.Cells["fecha_pago"]?.Value != null
                    ? Convert.ToDateTime(fila.Cells["fecha_pago"].Value).ToString("dd/MM/yyyy")
                    : string.Empty;

                Socio socio = new Socio();
                byte[] fotoBytes = socio.ObtenerFotoPorSocioId(socioId);

                Carnet carnet = new Carnet(nombreCompleto, dni, fechaNacimiento, fechaInscripcion, socioId, fotoBytes);
                carnet.ShowDialog();
            }
        }

    }
}
