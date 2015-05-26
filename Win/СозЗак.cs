using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp;
using System.IO;
using iTextSharp.text.pdf;

namespace Win
{
    public partial class СозЗак : Form
    {
        public СозЗак()
        {
            InitializeComponent();
        }

        public string way = @"C:\users\user\documents\visual studio 2013\Projects\WinLinq\Эскизы\";
        public string way_dog = @"C:\users\user\documents\visual studio 2013\Projects\WinLinq\Договор\";
        public int num = 0;
        public string filename = "";

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка клиентов. то есть: если данного клиента нет в бд, то занести
            string fio = textBox1.Text;
            string tel = textBox2.Text;
            string mail = textBox3.Text;
            bool w1 = false;
            bool w2 = false;
            bool w3 = false;
           

            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                {
                    MessageBox.Show("Часть полей не заполнено");
                    return;
                }
            }
            catch { }

            var c = Program.db2.Vivod(0);
            int yes = 0;
            int asd = 0;
            foreach (Клиент kl in c)
            {
                asd++;
                w1 = fio.Equals(kl.ФИО);
                w2 = tel.Equals(kl.Контактный_телефон);
                w3 = mail.Equals(kl.Электронная_почта);
                if ((w1 == false) && (w2 == false) && (w3 == false))
                {
                    yes++;
                }
            }
            if (yes==asd)
            {
                Program.db2.ADD(fio, tel, mail);
            }

            var q = Program.db2.Vivod(0);
            var lin =
            from a in q
            where ((w1 == true) && (w2 == true) && (w3 == true))
            select a.клиентID;
            foreach (var a in lin)
                num=a;

            int id_meb = 0;
            var m = Program.db1.Vivod(0);
            bool w4 = false;
            foreach (Мебель meb in m)
            {
                w4 = Program.vibmeb.Equals(meb.Название);
                if (w4==true)
                {
                    id_meb = meb.мебельID;
                }
            }
           

            var zakaz = Program.db7.Vivod(0);
            string stat="Vipolnenie";

            Program.db7.ADD(Program.dlina, Program.shirina, Program.glybina, Program.stoimost, Program.Datetime_vipol, stat, id_meb, num);

            MessageBox.Show("Заказ создан");

            var x = Program.db7.Vivod(0);
            int nomer = 0;
            var doc = new Document();
            foreach (Заказ za in x)
            {
                x.Last();
                nomer = za.заказID;
            }
            PdfWriter.GetInstance(doc, new FileStream(way_dog + nomer.ToString() + @".pdf", FileMode.Create));
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

            iTextSharp.text.Phrase z5 = new Phrase( "Вставка: " + Program.material2,
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

            iTextSharp.text.Phrase j1 = new Phrase("Договор №" + nomer+" (от "+DateTime.Now.ToShortDateString()+")",
          new iTextSharp.text.Font(baseFont, 18,
          iTextSharp.text.Font.BOLDITALIC, new BaseColor(Color.DarkRed)));
            Paragraph a1 = new Paragraph(j1);
            a1.Alignment = Element.ALIGN_CENTER;
            a1.SpacingAfter = 50;

            iTextSharp.text.Phrase n = new Phrase("Заказ №" + nomer,
         new iTextSharp.text.Font(baseFont, 12,
         iTextSharp.text.Font.ITALIC, new BaseColor(Color.DarkRed)));
            Paragraph g = new Paragraph(n);
            g.SpacingAfter = 10;

            iTextSharp.text.Phrase j2 = new Phrase("Клиент: " + fio,
         new iTextSharp.text.Font(baseFont, 12,
         iTextSharp.text.Font.BOLD, new BaseColor(Color.Chocolate)));
            Paragraph a2 = new Paragraph(j2);
            a2.SpacingAfter = 10;

            iTextSharp.text.Phrase j9 = new Phrase("Контактный телефон: " + tel + " Электронная почта: " + mail,
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

            MessageBox.Show("Сохранено в " + way_dog);
        }

        private void СозЗак_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet.Мебель". При необходимости она может быть перемещена или удалена.
            this.мебельTableAdapter.Fill(this.asdDataSet.Мебель);

            button1.Enabled = false;
            button5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //вызов форм создания эскизов
            if (radioButton5.Checked == true)
            {
                bool w1 = true;
                bool w2 = true;
                bool w3 = true;
                bool w4 = true;
                bool w5 = true;
                var m = Program.db1.Vivod(0);
                string name1 = "Shkaf-kype";
                string name2 = "Shkaf penal";
                string name3 = "Tymbochka";
                string name4 = "Shkaf";
                string name5 = "Komod";
                w1 = Convert.ToString(comboBox1.Text).Equals(name1);
                w2 = Convert.ToString(comboBox1.Text).Equals(name2);
                w3 = Convert.ToString(comboBox1.Text).Equals(name3);
                w4 = Convert.ToString(comboBox1.Text).Equals(name4);
                w5 = Convert.ToString(comboBox1.Text).Equals(name5);

                if (w1 != false)
                {
                    ШК sh = new ШК();
                    sh.ShowDialog();
                }
                if (w4 != false)
                {
                    Ш s = new Ш();
                    s.ShowDialog();
                }
                if (w5 != false)
                {
                    К k = new К();
                    k.ShowDialog();
                }
                if (w2 != false)
                {
                    ШП q = new ШП();
                    q.ShowDialog();
                }
                if (w3 != false)
                {
                    Т t = new Т();
                    t.ShowDialog();
                }

            }

            //выбор уже существующего эскиза
            if (radioButton6.Checked == true)
            {
                
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                   
                    System.IO.StreamReader sr = new
                       System.IO.StreamReader(openFileDialog1.FileName);
                    System.Diagnostics.Process.Start( openFileDialog1.FileName);
                    sr.Close();
                }

                Metods med = new Metods();
                med.ExtractText(openFileDialog1.FileName);
                filename = openFileDialog1.FileName;
                med.Vibor();
                   
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Klient kkk = new Klient();
            kkk.ShowDialog();
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = Program.id_klient;
            textBox1.Text = Program.fio;
            textBox2.Text = Program.telef;
            textBox3.Text = Program.email;
            button5.Enabled = false;
        }
    }
}
