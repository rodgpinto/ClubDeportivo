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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Registrar = new fRegistrar();
            Registrar.ShowDialog();
            this.Show();
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
