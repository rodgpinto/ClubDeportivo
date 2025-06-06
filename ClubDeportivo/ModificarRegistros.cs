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
    public partial class ModificarRegistros : Form
    {
        public ModificarRegistros()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnModificarSocio_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarSocio modificarSocio = new ModificarSocio();
            modificarSocio.ShowDialog();
            this.Show();
        }

        private void btnModificarNoSocio_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarNoSocio modificarNoSocio = new ModificarNoSocio();
            modificarNoSocio.ShowDialog();
            this.Show();
        }
    }
}
