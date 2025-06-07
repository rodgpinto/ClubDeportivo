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
    public partial class ListarNoSocios : Form
    {
        public ListarNoSocios()
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


        // Evento que se ejecuta al cargar el formulario y trata de listar los no socios en el DataGridView
        private void ListarNoSocios_Load(object sender, EventArgs e)
        {
            try
            {
        NoSocio datos = new NoSocio();
        DataTable tabla = datos.ListarNoSocios();
        dtgvRegistroNoSocio.DataSource = tabla;
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al cargar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }

    }


}
