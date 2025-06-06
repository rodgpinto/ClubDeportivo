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
    public partial class ListarVencimientos : Form
    {
        public ListarVencimientos()
        {
            InitializeComponent();
            dgvCuotasVencidas.AutoGenerateColumns = true;

        }// Inicializa el formulario y ejecuta el método para cargar las cuotas vencidas
        private void ListarVencimientos_Load(object sender, EventArgs e)
        {
            CargarCuotasVencidas();

        }

        // Método para cargar Socios con cuotas vencidas en el DataGridView
        private void CargarCuotasVencidas()
        {
            try
            {
                Socio socio = new Socio();
                DataTable tabla = socio.VerSociosConUltimaCuotaVencida();

                dgvCuotasVencidas.DataSource = null;
                dgvCuotasVencidas.DataSource = tabla;
                dgvCuotasVencidas.AutoGenerateColumns = true;
                dgvCuotasVencidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvCuotasVencidas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvCuotasVencidas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cuotas vencidas: " + ex.Message);
            }

        }


        // Evento del botón "Atras" para cerrar el formulario actual
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
