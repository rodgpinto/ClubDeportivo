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
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;

namespace ClubDeportivo
{
    public partial class ComprobanteActividad : Form
    {

        public ComprobanteActividad(string nombreCompleto, string dni, string formaPago, string fechaPago, string vencimiento, string monto, string actividad)
        {
            InitializeComponent();

            lblNombreCompleto2.Text = nombreCompleto;
            lblDni2.Text = dni;
            lblFormaPago2.Text = formaPago;
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblFechaPago2.Text = fechaPago;
            lblFechaVencimiento2.Text = vencimiento;
            lblMonto2.Text = monto;
            lblActividad2.Text = actividad;
        }

        // Evento que cierra el formulario y regresa al formulario anterior
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            fRegistrar Registrar = new fRegistrar();
            Registrar.Show();
        }

        // Evento que imprime el comprobante de pago en formato PDF y luego lo abre
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del escritorio del usuario actual
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


                // Genera un nombre de archivo único basado en la fecha y hora actual
                string fileName = $"comprobante_pago_actividad{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string filePath = System.IO.Path.Combine(desktopPath, fileName);

                // Crea el documento PDF y configura sus propiedades
                using (var writer = new PdfWriter(filePath))
                using (var pdf = new PdfDocument(writer))
                using (var doc = new Document(pdf, PageSize.A4))
                {
                    doc.SetMargins(40, 40, 40, 40);

                    PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                    PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                    Paragraph titulo = new Paragraph("CLUB DEPORTIVO")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(boldFont)
                        .SetFontSize(18)
                        .SetMarginBottom(10);
                    doc.Add(titulo);

                    Paragraph subtitulo = new Paragraph("Comprobante de Pago de Actividad")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(boldFont)
                        .SetFontSize(14)
                        .SetMarginBottom(20);
                    doc.Add(subtitulo);

                    Paragraph fecha = new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}")
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetFont(normalFont)
                        .SetFontSize(10)
                        .SetMarginBottom(20);
                    doc.Add(fecha);

                    Table table = new Table(2);
                    table.SetWidth(UnitValue.CreatePercentValue(50));
                    table.SetMarginBottom(20);
                    table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                    var cellStyle = new Style()
                        .SetPadding(8)
                        .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                        .SetMarginBottom(5);

                    // Agrega las filas a la tabla con los datos del comprobante
                    AddTableRow(table, "Nombre y Apellido:", lblNombreCompleto2.Text, boldFont, boldFont);
                    AddTableRow(table, "DNI:", lblDni2.Text, boldFont, boldFont);
                    AddTableRow(table, "Forma de pago:", lblFormaPago2.Text, boldFont, boldFont);
                    AddTableRow(table, "Fecha de pago:", lblFechaPago2.Text, boldFont, boldFont);
                    AddTableRow(table, "Vencimiento:", lblFechaVencimiento2.Text, boldFont, boldFont);
                    AddTableRow(table, "Monto abonado:", lblMonto2.Text, boldFont, boldFont);
                    AddTableRow(table, "Actividad:", lblActividad2.Text, boldFont, boldFont);

                    doc.Add(table);

                    doc.Add(new Paragraph("_".PadRight(80, '_'))
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginTop(20)
                        .SetMarginBottom(20));

                    doc.Add(new Paragraph("Gracias por su inscripción")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(normalFont)
                        .SetFontSize(12)
                        .SetMarginTop(20));

                    doc.Add(new Paragraph("Conserve este comprobante")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(normalFont)
                        .SetFontSize(10)
                        .SetMarginTop(10));
                }

                MessageBox.Show($"PDF generado correctamente:\n{filePath}", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre el PDF generado
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al generar el PDF:\n{ex.Message}\n\nDetalles técnicos:\n{ex.GetType().Name}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para agregar una fila a la tabla del comprobante
        private void AddTableRow(Table table, string label, string value, PdfFont boldFont, PdfFont normalFont)
        {
            var labelCell = new Cell()
                .Add(new Paragraph(label).SetFont(boldFont).SetFontSize(11))
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                .SetPadding(5)
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);

            var valueCell = new Cell()
                .Add(new Paragraph(value ?? "N/A").SetFont(normalFont).SetFontSize(11))
                .SetBorder(iText.Layout.Borders.Border.NO_BORDER)
                .SetPadding(5)
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);

            table.AddCell(labelCell);
            table.AddCell(valueCell);
        }
    } }
    

