using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class fMainMenu : Form
    {

        public fMainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        internal string? rol;
        internal string? user;

        private void fMainMenu_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + user + " (" + rol + ")";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRegistrar Registrar = new fRegistrar();
            Registrar.ShowDialog();
            this.Show();
        }


        private void btnListarSocios_Click(object sender, EventArgs e)
        {
            this.Hide();
            fListarSocios ListarSocios = new fListarSocios();
            ListarSocios.ShowDialog();
            this.Show();
        }
        private void btnListarNoSocios_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarNoSocios listarNoSocio = new ListarNoSocios();
            listarNoSocio.ShowDialog();
            this.Show();
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarPago registrarPago = new RegistrarPago();
            registrarPago.ShowDialog();
            this.Show();
        }

        private void btnListarVencimientos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarVencimientos listarVencimientos = new ListarVencimientos();
            listarVencimientos.ShowDialog();
            this.Show();
        }

        private void btnModificarRegistros_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarRegistros modificarRegistros = new ModificarRegistros();
            modificarRegistros.ShowDialog();
            this.Show();
        }

      
    }
}
