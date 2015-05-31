using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AODL.Document.Content.Tables;
using AODL.Document.Content.Text;
using AODL.Document.SpreadsheetDocuments;
using AODL.Document.Styles;
using AODL.Document.TextDocuments;

namespace Win
{
    public class Dogovor
    {
        public string way_dog = @"C:\users\user\documents\visual studio 2013\Projects\WinLinq\Договор\";
        public void Wr(string fileName)
        {
            TextDocument document = new TextDocument();
            document.New();
            Paragraph paragraph = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph1 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph2 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph3 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph4 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph5 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph6 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph7 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph8 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph9 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph10 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph11 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph12 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph13 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph14 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph15 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph16 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph17 = ParagraphBuilder.CreateStandardTextParagraph(document);
            Paragraph paragraph18 = ParagraphBuilder.CreateStandardTextParagraph(document);

            SimpleText s1 = new SimpleText(document, "Договор №" + Program.nomer.ToString() + " (от " + DateTime.Now.ToShortDateString() + ")");
            SimpleText q1 = new SimpleText(document, "    ");
            SimpleText s2 = new SimpleText(document, "Заказ №" + Program.nomer.ToString());
            SimpleText s3 = new SimpleText(document, "Клиент: " + Program.fio_kl.ToString());
            SimpleText s4 = new SimpleText(document, "Контактный телефон: " + Program.tel + " Электронная почта: " + Program.mail);
            SimpleText s5 = new SimpleText(document, "Тип: " + Program.vibmeb);
            SimpleText s6 = new SimpleText(document, "Длина: " + Program.dlina.ToString());
            SimpleText s7 = new SimpleText(document, "Ширина: " + Program.shirina.ToString());
            SimpleText s8 = new SimpleText(document, "Глубина: " + Program.glybina.ToString());
            SimpleText s9 = new SimpleText(document, "Материал: " + Program.material1);
            SimpleText s10 = new SimpleText(document, "Вставка: " + Program.material2);
            SimpleText s11 = new SimpleText(document, "Дата выполнения: " + Program.Datetime_vipol.ToString());
            SimpleText s12 = new SimpleText(document, "Стоимость: " + Program.stoimost.ToString());
            SimpleText s13 = new SimpleText(document, "Доставка: " + Program.vibdos.ToString());
            SimpleText s14 = new SimpleText(document, "Сборка: " + Program.vibsbor.ToString());
            SimpleText q2 = new SimpleText(document, "                     ");
            SimpleText s15 = new SimpleText(document, "Подпись: ");
            SimpleText s16 = new SimpleText(document, "Заказчик: ");
            SimpleText s17 = new SimpleText(document, "Исполнитель: ");
            paragraph.TextContent.Add(s1);
            paragraph.TextContent.Add(q1);
            paragraph1.TextContent.Add(s2);
            paragraph.TextContent.Add(q1);
            paragraph2.TextContent.Add(s3);
            paragraph.TextContent.Add(q1);
            paragraph3.TextContent.Add(s4);
            paragraph.TextContent.Add(q1);
            paragraph4.TextContent.Add(s5);
            paragraph.TextContent.Add(q1);
            paragraph5.TextContent.Add(s6);
            paragraph.TextContent.Add(q1);
            paragraph6.TextContent.Add(s7);
            paragraph.TextContent.Add(q1);
            paragraph7.TextContent.Add(s8);
            paragraph.TextContent.Add(q1);
            paragraph8.TextContent.Add(s9);
            paragraph.TextContent.Add(q1);
            paragraph9.TextContent.Add(s10);
            paragraph.TextContent.Add(q1);
            paragraph10.TextContent.Add(s11);
            paragraph.TextContent.Add(q1);
            paragraph11.TextContent.Add(s12);
            paragraph.TextContent.Add(q1);
            paragraph12.TextContent.Add(s13);
            paragraph.TextContent.Add(q1);
            paragraph13.TextContent.Add(s14);
            paragraph.TextContent.Add(q1);
            paragraph.TextContent.Add( q2);
            paragraph14.TextContent.Add(s15);
            paragraph.TextContent.Add(q1);
            paragraph15.TextContent.Add(s16);
            paragraph.TextContent.Add(q1);
            paragraph16.TextContent.Add(s17);
            paragraph17.TextContent.Add(q1);
            paragraph18.TextContent.Add(q1);

            document.Content.Add(paragraph);
            document.Content.Add(paragraph18);
            document.Content.Add(paragraph1);
            document.Content.Add(paragraph2);
            document.Content.Add(paragraph3);
            document.Content.Add(paragraph4);
            document.Content.Add(paragraph5);
            document.Content.Add(paragraph6);
            document.Content.Add(paragraph7);
            document.Content.Add(paragraph8);
            document.Content.Add(paragraph9);
            document.Content.Add(paragraph10);
            document.Content.Add(paragraph11);
            document.Content.Add(paragraph12);
            document.Content.Add(paragraph13);
            document.Content.Add(paragraph17);
            document.Content.Add(paragraph14);
            document.Content.Add(paragraph15);
            document.Content.Add(paragraph16);
            //document.SaveTo(way_dog + Program.nomer.ToString() + @".odt");
            document.SaveTo(fileName);
        }

    }
}
