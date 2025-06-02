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
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            fMainMenu MainMenu = new fMainMenu();
            MainMenu.Show();
            MainMenu.Close();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
      
        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form RegistrarSocio = new fRegistrarSocio();
            RegistrarSocio.ShowDialog();
            this.Show();
        }



        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarNoSocio RegistrarSocio = new RegistrarNoSocio();
            RegistrarSocio.ShowDialog();
            this.Show();
        }

       
    }
}
