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
    public partial class fRegistrar : Form
    {
        public fRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form RegistrarSocio = new fRegistrarSocio();
            RegistrarSocio.ShowDialog();
            this.Show();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
            fMainMenu MainMenu = new fMainMenu();  // Creás una NUEVA instancia
            MainMenu.Show();
            MainMenu.Close();
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
