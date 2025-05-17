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
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    public partial class fRegistrarSocio : Form
    {
        public fRegistrarSocio()
        {
            InitializeComponent();
        }



        private void btnIngresarDato_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDocumento.Text == "" || cboTipo.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                {
                    conexion.Open();


                    string validarPersona = @"SELECT COUNT(*) FROM persona 
                          WHERE LOWER(nombre) = LOWER(@nombre) 
                            AND LOWER(apellido) = LOWER(@apellido) 
                            AND dni = @dni";

                    using (MySqlCommand cmd = new MySqlCommand(validarPersona, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim().ToLower());
                        cmd.Parameters.AddWithValue("@apellido", txtApellido.Text.Trim().ToLower());
                        cmd.Parameters.AddWithValue("@dni", Convert.ToInt32(txtDocumento.Text));

                        int existe = Convert.ToInt32(cmd.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show("Ya existe una persona registrada con ese nombre, apellido o DNI.",
                                            "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;
                        }
                    }


                    string queryPersona = @"INSERT INTO persona(nombre, apellido, dni, direccion, fecha_nacimiento)
                      VALUES (@nombre, @apellido, @dni, @direccion, @fechaNacimiento);
                         SELECT LAST_INSERT_ID();";

                    int personaId;

                    using (MySqlCommand cmd = new MySqlCommand(queryPersona, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@apellido", txtApellido.Text);
                        cmd.Parameters.AddWithValue("@dni", Convert.ToInt32(txtDocumento.Text));
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@fechaNacimiento", dtpFechaNacimiento.Value);

                        personaId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string querySocio = @"INSERT INTO socios 
                (persona_id, carnet, ficha_inscripcion, apto_fisico, socio_activo)
                VALUES (@personaId, 0, false, false, true);
                SELECT LAST_INSERT_ID();";

                    int socioId;

                    using (MySqlCommand cmd = new MySqlCommand(querySocio, conexion))
                    {
                        cmd.Parameters.AddWithValue("@personaId", personaId);
                        socioId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string updateCarnet = "UPDATE socios SET carnet = @id WHERE id_socio = @id";

                    using (MySqlCommand cmd = new MySqlCommand(updateCarnet, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", socioId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("¡Socio registrado correctamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDocumento.Text = "";
                cboTipo.Text = "";
                txtDireccion.Text = "";
                dtpFechaNacimiento.Value = DateTime.Now;
                txtNombre.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            cboTipo.Text = "";
            txtDireccion.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtNombre.Focus();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            fRegistrar Registrar = new fRegistrar();
            Registrar.Show();
            Registrar.Close();


        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }

}

