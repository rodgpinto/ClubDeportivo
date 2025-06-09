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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        // Evento para mostrar/ocultar la contraseña
        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;

            if(checkBox.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        // Evento para iniciar sesión al hacer clic en el botón "Ingresar", valida las credenciales ingresadas
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Usuario dato = new Datos.Usuario();
            tablaLogin = dato.Login(txtUser.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido/a " + txtUser.Text, "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                this.Hide();
                fMainMenu MainMenu = new fMainMenu();

                MainMenu.user = Convert.ToString(txtUser.Text);
                MainMenu.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                
                MainMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
