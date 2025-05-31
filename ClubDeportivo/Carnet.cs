using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class Carnet : Form
    {
        public Carnet(string nombreCompleto, string dni, string fechaNacimiento, string fechaPago, int socioId, byte[] fotoBytes)
        {
            InitializeComponent();

            lblNombre2.Text = nombreCompleto;
            lblDNI2.Text = dni;
            lblFechaNacimiento2.Text = fechaNacimiento;
            lblSocioDesde2.Text = fechaPago;
            lblIdSocio2.Text = socioId.ToString();

            if (fotoBytes?.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(fotoBytes))
                    {
                        Image imagenOriginal = Image.FromStream(ms);

                        Bitmap imagenEscalada = new Bitmap(imagenOriginal, picFoto.Width, picFoto.Height);
                        picFoto.Image = imagenEscalada;
                        picFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la foto del carnet: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Este socio no tiene una foto cargada.");
            }
        }

        public Carnet(string nombreCompleto, string dni, string fechaNacimiento, string fechaPago,  byte[] fotoBytes)
        {
            InitializeComponent();

            lblNombre2.Text = nombreCompleto;
            lblDNI2.Text = dni;
            lblFechaNacimiento2.Text = fechaNacimiento;
            lblSocioDesde2.Text = fechaPago;

            if (fotoBytes?.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(fotoBytes))
                    {
                        Image imagenOriginal = Image.FromStream(ms);

                        Bitmap imagenEscalada = new Bitmap(imagenOriginal, picFoto.Width, picFoto.Height);
                        picFoto.Image = imagenEscalada;
                        picFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la foto del carnet: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Este socio no tiene una foto cargada.");
            }
        }

     
    }
}
