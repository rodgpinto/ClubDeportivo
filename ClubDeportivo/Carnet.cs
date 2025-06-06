using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClubDeportivo.Datos;
using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using iText.Layout;
using iText.Layout.Borders;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using PdfImage = iText.Layout.Element.Image;
using DrawingImage = System.Drawing.Image;
using iText.Kernel.Pdf.Canvas;



namespace ClubDeportivo
{
    public partial class Carnet : Form
    {
        // Constructor privado: se usa solo internamente
        private Carnet(DatosCarnet datos)
        {
            InitializeComponent();
            CargarDatosCarnet(
                datos.NombreCompleto,
                datos.Dni,
                datos.FechaNacimiento,
                datos.FechaInscripcion,
                datos.SocioId,
                datos.FotoBytes
            );
        }

        // Constructor público: se usa para cargar el carnet por DNI
        public Carnet(int dni)
        {
            InitializeComponent();
            CargarCarnetPorDni(dni);
        }

        // Método para cargar los datos del carnet según el DNI proporcionado.
        private void CargarCarnetPorDni(int dni)
        {
            try
            {
                var datosCarnet = ObtenerDatosCarnetPorDni(dni);
                if (datosCarnet != null)
                {
                    CargarDatosCarnet(
                        datosCarnet.NombreCompleto,
                        datosCarnet.Dni,
                        datosCarnet.FechaNacimiento,
                        datosCarnet.FechaInscripcion,
                        datosCarnet.SocioId,
                        datosCarnet.FotoBytes
                    );
                }
                else
                {
                    MessageBox.Show("No se encontró un socio activo con el DNI proporcionado.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del carnet: " + ex.Message);
                this.Close();
            }
        }

        // Muestra el carnet de un socio activo según su DNI.
        public static void MostrarCarnetPorDni(int dni)
        {
            try
            {
                var datosCarnet = ObtenerDatosCarnetPorDni(dni);
                if (datosCarnet != null)
                {
                    using (Carnet formCarnet = new Carnet(datosCarnet))
                    {
                        formCarnet.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró un socio activo con el DNI proporcionado.",
                                  "Socio no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el carnet: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carga los datos visuales en el formulario.
        private void CargarDatosCarnet(string nombreCompleto, string dni, string fechaNacimiento, string fechaPago, int socioId, byte[] fotoBytes)
        {
            lblNombre2.Text = nombreCompleto;
            lblDNI2.Text = dni;
            lblFechaNacimiento2.Text = fechaNacimiento;
            lblSocioDesde2.Text = fechaPago;
            lblIdSocio2.Text = socioId.ToString(); // Eliminar si no se muestra al usuario

            if (fotoBytes?.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(fotoBytes))
                    {
                        System.Drawing.Image imagenOriginal = System.Drawing.Image.FromStream(ms);
                        Bitmap imagenEscalada = new Bitmap(imagenOriginal, picFoto.Width, picFoto.Height);
                        picFoto.Image = imagenEscalada;
                        picFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la foto del carnet: " + ex.Message);
                    picFoto.Image = null;
                }
            }
            else
            {
                picFoto.Image = null;
                MessageBox.Show("Este socio no tiene una foto cargada.");
            }
        }

        // Consulta la base de datos para obtener los datos del carnet de un socio.
        private static DatosCarnet ObtenerDatosCarnetPorDni(int dni)
        {
            string query = @"
                SELECT 
                    CONCAT(p.nombre, ' ', p.apellido) as NombreCompleto,
                    p.dni,
                    DATE_FORMAT(p.fecha_nacimiento, '%d/%m/%Y') as FechaNacimiento,
                    DATE_FORMAT(s.fecha_inscripcion, '%d/%m/%Y') as FechaInscripcion,
                    s.id_socio,
                    c.foto
                FROM persona p
                INNER JOIN socios s ON p.codigo = s.persona_id
                LEFT JOIN carnet c ON s.id_socio = c.socioId
                WHERE p.dni = @dni AND s.socio_activo = 1
                LIMIT 1";

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();

                using (MySqlCommand command = new MySqlCommand(query, sqlCon))
                {
                    command.Parameters.AddWithValue("@dni", dni);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DatosCarnet
                            {
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Dni = reader["dni"].ToString(),
                                FechaNacimiento = reader["FechaNacimiento"].ToString(),
                                FechaInscripcion = reader["FechaInscripcion"].ToString(),
                                SocioId = Convert.ToInt32(reader["id_socio"]),
                                FotoBytes = reader["foto"] as byte[]
                            };
                        }
                    }
                }
            }

            return null;
        }

        // Clase interna para transportar los datos del carnet.
        private class DatosCarnet
        {
            public string NombreCompleto { get; set; }
            public string Dni { get; set; }
            public string FechaNacimiento { get; set; }
            public string FechaInscripcion { get; set; }
            public int SocioId { get; set; }
            public byte[]? FotoBytes { get; set; }
        }

        // Evento para el botón de imprimir carnet, que genera un PDF con los datos del carnet.
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // Datos del carnet
                string nombreCompleto = lblNombre2.Text;
                string dni = lblDNI2.Text;
                string fechaNacimiento = lblFechaNacimiento2.Text;
                string fechaPago = lblSocioDesde2.Text;
                string idSocio = lblIdSocio2.Text;

                // Crear PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Archivo PDF|*.pdf",
                    Title = "Guardar Carnet en PDF",
                    FileName = $"Carnet_{dni}.pdf"
                };

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                {
                    PdfWriter writer = new PdfWriter(fs);
                    PdfDocument pdf = new PdfDocument(writer);
                    PageSize pageSize = new PageSize(300, 150); // Horizontal tipo credencial
                    Document doc = new Document(pdf, pageSize);
                    doc.SetMargins(10, 10, 10, 10);

                    // Asegurarse de que haya al menos una página
                    pdf.AddNewPage();

                    // Obtener la página activa
                    PdfPage page = pdf.GetFirstPage();
                    PdfCanvas canvas = new PdfCanvas(page);

                    // Dibujar fondo celeste
                    canvas.SaveState();
                    canvas.SetFillColorRgb(201 / 255f, 241 / 255f, 253 / 255f);
                    canvas.Rectangle(0, 0, pageSize.GetWidth(), pageSize.GetHeight());
                    canvas.Fill();
                    canvas.RestoreState();


                    // Título
                    PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                 
                    Paragraph titulo = new Paragraph("CLUB DEPORTIVO")
                       .SetTextAlignment(TextAlignment.CENTER)
                       .SetFontSize(16)
                       .SetFont(boldFont) // Apply the bold font here  
                       .SetMarginBottom(10);
                    doc.Add(titulo);

                    // Crear tabla 2 columnas (foto - datos)
                    Table tabla = new Table(new float[] { 1, 2 }).UseAllAvailableWidth();

                    // Columna 1: Foto
                    Cell celdaImagen = new Cell().SetBorder(Border.NO_BORDER);
                    if (picFoto.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            ImageData imageData = ImageDataFactory.Create(ms.ToArray());
                            iText.Layout.Element.Image img = new iText.Layout.Element.Image(imageData)
                                .ScaleToFit(80, 80)
                                .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                            celdaImagen.Add(img);
                        }
                    }
                    tabla.AddCell(celdaImagen);

                    // Columna 2: Datos
                    Cell celdaDatos = new Cell().SetBorder(Border.NO_BORDER);
                    celdaDatos.Add(new Paragraph($"Nombre: {nombreCompleto}"));
                    celdaDatos.Add(new Paragraph($"DNI: {dni}"));
                    celdaDatos.Add(new Paragraph($"Fecha de Nac.: {fechaNacimiento}"));
                    celdaDatos.Add(new Paragraph($"Inscripción: {fechaPago}"));
                    celdaDatos.Add(new Paragraph($"ID Socio: {idSocio}"));
                    tabla.AddCell(celdaDatos);

                    // Agregar tabla al documento
                    doc.Add(tabla);

                    // Cerrar documento
                    doc.Close();
                }

                MessageBox.Show("Carnet generado correctamente.", "PDF creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
