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
    public partial class Carnet : Form
    {
        public Carnet(string nombreCompleto, string dni,string fechaNacimiento, string fechaPago)
        {
            InitializeComponent();
            lblNombre2.Text = nombreCompleto;
            lblDNI2.Text = dni;
            lblFechaNacimiento2.Text = fechaNacimiento;
            lblSocioDesde2.Text = fechaPago;
           
        }

        private void Carnet_Load(object sender, EventArgs e)
        {

        }
    }
}
