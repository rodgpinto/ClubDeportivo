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
        }

        internal string? rol;
        internal string? user;

        private void fMainMenu_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + user + " (" + rol + ")";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRegistrar Registrar = new fRegistrar();
            Registrar.ShowDialog();
            this.Show();
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnListarSocios_Click(object sender, EventArgs e)
        {
            this.Hide();
            fListarSocios ListarSocios = new fListarSocios();
            ListarSocios.ShowDialog();
            this.Show();
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarPago registrarPago = new RegistrarPago();
            registrarPago.ShowDialog();
            this.Show();
        }
    }
}
