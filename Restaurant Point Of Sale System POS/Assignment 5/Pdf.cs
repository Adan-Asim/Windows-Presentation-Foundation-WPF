using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Spire.Pdf;
using Spire.Pdf.Graphics;



namespace Assignment_5
{
    class Pdf
    {
        static PdfDocument doc = new PdfDocument();
       
        public static string createPDF(List<Order> OL, double Amount, double Tax)
        {
            PdfPageBase page = doc.Pages.Add(PdfPageSize.Legal);
            PdfPageBase page1 = doc.Pages.Add(PdfPageSize.Legal);

            PdfFont font1 = new PdfFont(PdfFontFamily.TimesRoman, 25f);
            page.Canvas.DrawString("Bill Receipt", font1, PdfBrushes.Blue, new System.Drawing.PointF(205, 60f));

            PdfFont font2 = new PdfFont(PdfFontFamily.TimesRoman, 20f);
            page.Canvas.DrawString("Item", font2, PdfBrushes.Blue, new System.Drawing.PointF(70, 140f));
            page.Canvas.DrawString("Price" , font2, PdfBrushes.Blue, new System.Drawing.PointF(300, 140f));
            page.Canvas.DrawString("Tax", font2, PdfBrushes.Blue, new System.Drawing.PointF(400, 140f));

            int x = 30;
            foreach (Order o in OL)
            {
                PdfFont font3 = new PdfFont(PdfFontFamily.TimesRoman, 10f);
                page.Canvas.DrawString(o.title, font3, PdfBrushes.Blue, new System.Drawing.PointF(70, x+ 140f));
                page.Canvas.DrawString(o.total.ToString(), font3, PdfBrushes.Blue, new System.Drawing.PointF(300, x+ 140f));
                page.Canvas.DrawString(o.tax.ToString(), font3, PdfBrushes.Blue, new System.Drawing.PointF(400, x+ 140f));
                x += 30;
            }

            PdfFont font4 = new PdfFont(PdfFontFamily.TimesRoman, 15f);

            page1.Canvas.DrawString("Total: " + Amount.ToString(), font4, PdfBrushes.Blue, new System.Drawing.PointF(70, 100f));
            page1.Canvas.DrawString("Tax: " + Tax.ToString(), font4, PdfBrushes.Blue, new System.Drawing.PointF(70, 150f));
            page1.Canvas.DrawString("Total Payable: " + (Amount + Tax).ToString(), font4, PdfBrushes.Blue, new System.Drawing.PointF(70, 200f));


            page1.Canvas.DrawString("Dated:" + DateTime.Now.ToString("MM-dd - yyyy hh:mm:ss"), font4, PdfBrushes.Blue, new System.Drawing.PointF(70, 250f));
            page1.Canvas.DrawString("> Developer: Adan Asim <", font4, PdfBrushes.Blue, new System.Drawing.PointF(200, 300f));

            string path = Convert.ToString(System.IO.Directory.GetCurrentDirectory()) + @"..\..\..\..";
            doc.SaveToFile (path + @"\Receipts\Bill;" + DateTime.Now.ToString("MM-dd - yyyy-hh-mm-ss") + ".pdf");
            doc.Close();
            return path;
        }
    }
}
