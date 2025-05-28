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

        
    }
}
