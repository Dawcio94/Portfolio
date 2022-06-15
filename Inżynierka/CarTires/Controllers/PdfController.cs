using CarTiresService.Models;
using CarTiresService.Models;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace CarTiresService.Controllers
{
    public class PdfController : Controller
    {
        private CarTiresServiceEntities db = new CarTiresServiceEntities();

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public void MakePDF(int raportId)
        {
            using (PdfDocument document = new PdfDocument())
            {
                document.PageSettings.Orientation = PdfPageOrientation.Portrait;
                document.PageSettings.Margins.All = 50;
                //Adds a page to the document
                PdfPage page = document.Pages.Add();
                PdfGraphics graphics = page.Graphics;

                PdfImage image = PdfImage.FromFile(Server.MapPath("~/Images/Serwis.jfif"));
                RectangleF bounds = new RectangleF(50, 0, 400, 130);
                //Draws the image to the PDF page
                page.Graphics.DrawImage(image, bounds);

                PdfFont HeadingFont = new PdfTrueTypeFont(new Font("Times New Roman", 26));
                PdfTextElement elementHead = new PdfTextElement("Serwis wulkanizacyjny\n\t\t\tLux Auto", HeadingFont)
                {
                    Brush = PdfBrushes.Black
                };
                PdfLayoutResult resultHead = elementHead.Draw(page, new PointF(120, bounds.Bottom + 10));
                PdfBrush solidBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
                bounds = new RectangleF(0, bounds.Bottom + 90, graphics.ClientSize.Width, 30);
                //Draws a rectangle to place the heading in that region.
                graphics.DrawRectangle(solidBrush, bounds);
                //Creates a font for adding the heading in the page
                PdfFont subHeadingFont = new PdfTrueTypeFont(new Font("Times New Roman", 14));
                //Creates a text element to add the invoice number
                PdfTextElement element = new PdfTextElement("Raport " + raportId.ToString(), subHeadingFont)
                {
                    Brush = PdfBrushes.White
                };

                //Draws the heading on the page
                PdfLayoutResult result = element.Draw(page, new PointF(10, bounds.Top + 8));
                string currentDate = "Data wystawienia " + DateTime.Now.ToString("dd/MM/yyyy");
                //Measures the width of the text to place it in the correct location
                SizeF textSize = subHeadingFont.MeasureString(currentDate);
                PointF textPosition = new PointF(graphics.ClientSize.Width - textSize.Width - 10, result.Bounds.Y);
                //Draws the date by using DrawString method
                graphics.DrawString(currentDate, subHeadingFont, element.Brush, textPosition);
                Font tempfont = new Font("Times New Roman", 14, FontStyle.Regular);
                PdfFont timesRoman = new PdfTrueTypeFont(tempfont, true);
                //Creates text elements to add the address and draw it to the page.
                var klientId = db.Raport.Where(w => w.RaportId==raportId).Select(s => s.Rezerwacje.KlientId).FirstOrDefault();
                string klient = db.Raport.Where(w => w.RaportId==raportId).Select(s => s.Rezerwacje.Klienci.Imie+" "+s.Rezerwacje.Klienci.Nazwisko+" "+s.Rezerwacje.Klienci.NumerTelefonu).FirstOrDefault();
                var adres = db.Klienci.Where(w => w.KlientId==klientId).Select(s => s.Adresy.KodPocztowy+" "+s.Adresy.Miasto+"\n"+s.Adresy.Ulica+" "+s.Adresy.NumerDomu+"/"+s.Adresy.NumerMieszkania).FirstOrDefault();
                element = new PdfTextElement($"Dane klienta:\n{klient}\n{adres}", timesRoman)
                {
                    Brush = new PdfSolidBrush(new PdfColor(0, 0, 0))
                };
                result = element.Draw(page, new PointF(10, result.Bounds.Bottom + 25));
                PdfPen linePen = new PdfPen(new PdfColor(126, 151, 173), 0.70f);
                PointF startPoint = new PointF(0, result.Bounds.Bottom + 3);
                PointF endPoint = new PointF(graphics.ClientSize.Width, result.Bounds.Bottom + 3);
                //Draws a line at the bottom of the address
                graphics.DrawLine(linePen, startPoint, endPoint);

                //Creates the datasource for the table
                List<RaportUslugPDF> raportUslug = db.RaportUslugi.Where(w => w.RaportId==raportId).Select(s => new RaportUslugPDF
                {
                    NazwaUslugi = s.Uslugi.NazwaUslugi,
                    Ilosc=s.Ilosc,
                    KosztZaSzt=s.Uslugi.Koszt,
                    Koszt=s.Ilosc*s.Uslugi.Koszt
                }).ToList();

                List<RaportCzescPDF> raportCzesc = db.RaportCzesc.Where(w => w.RaportId==raportId).Select(s => new RaportCzescPDF
                {
                    NazwaCzesci=s.CzesciZamienne.NazwaCzesci,
                    KosztZaSzt=s.CzesciZamienne.KosztSztuka,
                    Ilosc=s.IloscUzytejCzesci,
                    Koszt=s.IloscUzytejCzesci*s.CzesciZamienne.KosztSztuka
                }).ToList();
                //Creates a PDF grid
                PdfGrid gridUslugi = new PdfGrid
                {
                    //Adds the data source
                    DataSource=ToDataTable(raportUslug)
                };
                PdfGrid gridCzesci = new PdfGrid
                {
                    //Adds the data source
                    DataSource=ToDataTable(raportCzesc)
                };
                //Creates the grid cell styles
                PdfGridCellStyle cellStyle = new PdfGridCellStyle();
                // cellStyle.Borders.All = PdfPens.White;
                PdfGridRow headerUslugi = gridUslugi.Headers[0];
                PdfGridRow headerCzesc = gridCzesci.Headers[0];
                //Creates the header style
                PdfGridCellStyle headerStyle = new PdfGridCellStyle();
                headerStyle.Borders.All = new PdfPen(new PdfColor(126, 151, 173));
                headerStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
                headerStyle.TextBrush = PdfBrushes.White;
                headerStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 14f, PdfFontStyle.Regular);

                //Adds cell customizations
                for (int i = 0; i < headerUslugi.Cells.Count; i++)
                {
                    headerUslugi.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
                }

                for (int i = 0; i < headerCzesc.Cells.Count; i++)
                {
                    headerCzesc.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
                }

                //Applies the header style
                headerUslugi.ApplyStyle(headerStyle);

                //cellStyle.Borders.Bottom = new PdfPen(new PdfColor(217, 217, 217), 0.70f);
                tempfont = new Font("Times New Roman", 15, FontStyle.Regular);
                cellStyle.Font = new PdfTrueTypeFont(tempfont, true);
                cellStyle.TextBrush = new PdfSolidBrush(new PdfColor(0, 0, 0));

                cellStyle.StringFormat= new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
                //Creates the layout format for grid
                PdfGridLayoutFormat layoutFormat = new PdfGridLayoutFormat
                {
                    // Creates layout format settings to allow the table pagination
                    Layout = PdfLayoutType.Paginate
                };
                //Draws the grid to the PDF page.
                for (int i = 0; i < gridUslugi.Rows.Count; i++)
                {
                    for (int j = 0; j < gridUslugi.Rows[i].Cells.Count; j++)
                    {
                        gridUslugi.Rows[i].Cells[j].Style = cellStyle;
                    }
                }
                for (int i = 0; i < gridCzesci.Rows.Count; i++)
                {
                    for (int j = 0; j < gridCzesci.Rows[i].Cells.Count; j++)
                    {
                        gridCzesci.Rows[i].Cells[j].Style = cellStyle;
                    }
                }

                PdfGridLayoutResult gridResultUslugi = gridUslugi.Draw(page, new RectangleF(new PointF(0, result.Bounds.Bottom + 40), new SizeF(graphics.ClientSize.Width, graphics.ClientSize.Height - 100)), layoutFormat);

                headerCzesc.ApplyStyle(headerStyle);
                PdfGridLayoutResult gridResultCzesci = gridCzesci.Draw(page, new RectangleF(new PointF(0, gridResultUslugi.Bounds.Bottom + 5), new SizeF(graphics.ClientSize.Width, graphics.ClientSize.Height - 100)), layoutFormat);

                var sumaText = db.Raport.Where(w => w.RaportId == raportId).Select(s => s.KosztCalkowity).FirstOrDefault().ToString();

                tempfont = new Font("Times New Roman", 20, FontStyle.Regular);

                PdfFont sumaFont = new PdfTrueTypeFont(tempfont, true);

                PdfTextElement sumaTextelem = new PdfTextElement("Suma " + sumaText, sumaFont)
                {
                    Brush = PdfBrushes.Black
                };

                result = sumaTextelem.Draw(page, new PointF(document.PageSettings.Width-220, gridResultCzesci.Bounds.Bottom + 25));

                // Open the document in browser after saving it
                var rezerwacjaId = db.Raport.Where(w => w.RaportId == raportId).Select(s => s.RezerwacjaId).FirstOrDefault();

                document.Save($"Nr_raportu:{raportId}/Nr_rezer:{rezerwacjaId}.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);

            }

        }

    }
}