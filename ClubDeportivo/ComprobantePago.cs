using System;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Geom;
using iText.Layout.Properties;
using iText.IO.Font.Constants;
using iText.Kernel.Font;

namespace ClubDeportivo
{
    public partial class fComprobantePago : Form
    {
        public fComprobantePago(string nombreCompleto, string dni, string formaPago, string fechaPago, string vencimiento, string monto)
        {
            InitializeComponent();

            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblNombreCompleto2.Text = nombreCompleto;
            lblDni2.Text = dni;
            lblFormaPago2.Text = formaPago;
            lblFechaPago2.Text = fechaPago;
            lblFechaVencimiento2.Text = vencimiento;
            lblMonto2.Text = monto;
        }

        private void fComprobantePago_Load(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            fRegistrar Registrar = new fRegistrar();
            Registrar.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string fileName = $"comprobante_pago_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string filePath = System.IO.Path.Combine(desktopPath, fileName);


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

                    Paragraph subtitulo = new Paragraph("Comprobante de Pago")
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

                    AddTableRow(table, "Nombre y Apellido:", lblNombreCompleto2.Text, boldFont, boldFont);
                    AddTableRow(table, "DNI:", lblDni2.Text, boldFont, boldFont);
                    AddTableRow(table, "Forma de pago:", lblFormaPago2.Text, boldFont, boldFont);
                    AddTableRow(table, "Fecha de pago:", lblFechaPago2.Text, boldFont, boldFont);
                    AddTableRow(table, "Vencimiento cuota:", lblFechaVencimiento2.Text, boldFont, boldFont);
                    AddTableRow(table, "Monto abonado:", lblMonto2.Text, boldFont, boldFont);

                    doc.Add(table);

                    doc.Add(new Paragraph("_".PadRight(80, '_'))
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginTop(20)
                        .SetMarginBottom(20));

                    doc.Add(new Paragraph("Gracias por elegirnos")
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
    }
}