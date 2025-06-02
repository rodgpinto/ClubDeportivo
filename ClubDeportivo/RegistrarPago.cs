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
    public partial class RegistrarPago : Form
    {
        public RegistrarPago()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            fRegistrar Registrar = new fRegistrar();
            Registrar.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
