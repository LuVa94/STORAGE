using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp;
using System.IO;
using iTextSharp.text.pdf;
using System.Drawing;

namespace Win
{
    public class PDFDoc
    {

        public string way = @"C:\users\user\documents\visual studio 2013\Projects\WinLinq\Эскизы\";
        public string way_dog = @"C:\users\user\documents\visual studio 2013\Projects\WinLinq\Договор\";
        public void PDFdoc(string fileName)
        {
            var doc = new Document();
            //PdfWriter.GetInstance(doc, new FileStream(way_dog + Program.nomer.ToString() + @".pdf", FileMode.Create));
            PdfWriter.GetInstance(doc, new FileStream(fileName.ToString() + @".pdf", FileMode.Create));
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont(@"D:\ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            //////////
            iTextSharp.text.Phrase j3 = new Phrase("Тип: " + Program.vibmeb,
           new iTextSharp.text.Font(baseFont, 12,
           iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph a3 = new Paragraph(j3);
            a3.SpacingAfter = 10;

            iTextSharp.text.Phrase z1 = new Phrase("Длина: " + Program.dlina,
          new iTextSharp.text.Font(baseFont, 12,
          iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph b1 = new Paragraph(z1);
            b1.SpacingAfter = 10;

            iTextSharp.text.Phrase z2 = new Phrase("Ширина: " + Program.shirina,
          new iTextSharp.text.Font(baseFont, 12,
          iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph b2 = new Paragraph(z2);
            b2.SpacingAfter = 10;

            iTextSharp.text.Phrase z3 = new Phrase("Глубина: " + Program.glybina,
          new iTextSharp.text.Font(baseFont, 12,
          iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph b3 = new Paragraph(z3);
            b3.SpacingAfter = 10;

            iTextSharp.text.Phrase z4 = new Phrase("Материал: " + Program.material1,
          new iTextSharp.text.Font(baseFont, 12,
          iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph b4 = new Paragraph(z4);
            b4.SpacingAfter = 10;

            iTextSharp.text.Phrase z5 = new Phrase("Вставка: " + Program.material2,
          new iTextSharp.text.Font(baseFont, 12,
          iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph b5 = new Paragraph(z5);
            b5.SpacingAfter = 10;

            iTextSharp.text.Phrase z6 = new Phrase("Дата выполнения: " + Program.Datetime_vipol,
          new iTextSharp.text.Font(baseFont, 12,
          iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph b6 = new Paragraph(z6);
            b6.SpacingAfter = 10;

            iTextSharp.text.Phrase z7 = new Phrase("Стоимость: " + Program.stoimost,
          new iTextSharp.text.Font(baseFont, 12,
          iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph b7 = new Paragraph(z7);
            b7.SpacingAfter = 20;
            //////////////
            iTextSharp.text.Phrase j4 = new Phrase("Доставка: " + Program.vibdos,
          new iTextSharp.text.Font(baseFont, 12,
          iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph a4 = new Paragraph(j4);
            a4.SpacingAfter = 10;

            iTextSharp.text.Phrase j8 = new Phrase("Сборка: " + Program.vibsbor,
         new iTextSharp.text.Font(baseFont, 12,
         iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph a8 = new Paragraph(j8);
            a8.SpacingAfter = 10;

            iTextSharp.text.Phrase j1 = new Phrase("Договор №" + Program.nomer + " (от " + DateTime.Now.ToShortDateString() + ")",
          new iTextSharp.text.Font(baseFont, 18,
          iTextSharp.text.Font.BOLDITALIC, new BaseColor(Color.DarkRed)));
            Paragraph a1 = new Paragraph(j1);
            a1.Alignment = Element.ALIGN_CENTER;
            a1.SpacingAfter = 50;

            iTextSharp.text.Phrase n = new Phrase("Заказ №" + Program.nomer,
         new iTextSharp.text.Font(baseFont, 12,
         iTextSharp.text.Font.ITALIC, new BaseColor(Color.DarkRed)));
            Paragraph g = new Paragraph(n);
            g.SpacingAfter = 10;

            iTextSharp.text.Phrase j2 = new Phrase("Клиент: " + Program.fio_kl,
         new iTextSharp.text.Font(baseFont, 12,
         iTextSharp.text.Font.BOLD, new BaseColor(Color.Chocolate)));
            Paragraph a2 = new Paragraph(j2);
            a2.SpacingAfter = 10;

            iTextSharp.text.Phrase j9 = new Phrase("Контактный телефон: " + Program.tel + " Электронная почта: " + Program.mail,
        new iTextSharp.text.Font(baseFont, 12,
        iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph a9 = new Paragraph(j9);
            a9.SpacingAfter = 10;

            iTextSharp.text.Phrase j5 = new Phrase("Подпись: ",
        new iTextSharp.text.Font(baseFont, 16,
        iTextSharp.text.Font.ITALIC, new BaseColor(Color.Black)));
            Paragraph a5 = new Paragraph(j5);
            a5.SpacingAfter = 30;

            iTextSharp.text.Phrase j6 = new Phrase("Заказчик: ",
        new iTextSharp.text.Font(baseFont, 12,
        iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph a6 = new Paragraph(j6);
            a6.SpacingAfter = 10;

            iTextSharp.text.Phrase j7 = new Phrase("Исполнитель: ",
        new iTextSharp.text.Font(baseFont, 12,
        iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
            Paragraph a7 = new Paragraph(j7);
            a7.SpacingAfter = 10;

            doc.Add(a1);
            doc.Add(g);
            doc.Add(a2);
            doc.Add(a9);
            doc.Add(a3);
            doc.Add(b1);
            doc.Add(b2);
            doc.Add(b3);
            doc.Add(b4);
            doc.Add(b5);
            doc.Add(b6);
            doc.Add(b7);
            doc.Add(a4);
            doc.Add(a8);
            doc.Add(a5);
            doc.Add(a6);
            doc.Add(a7);
            doc.Close();

        }
    }
}
