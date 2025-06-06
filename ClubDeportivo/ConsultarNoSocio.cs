using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static Mysqlx.Crud.Order.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivo
{
    public partial class ConsultarNoSocio : Form
    {
        public ConsultarNoSocio(int id, string nombre, string apellido, string dni, string direccion, DateTime fechaNacimiento)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;


            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";

            txtID.Text = id.ToString();
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtDNI.Text = dni;
            txtDireccion.Text = direccion;
            dtpFechaNacimiento.Value = fechaNacimiento;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
