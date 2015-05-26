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
            int id_mat = 0;
            var mat = Program.db5.Vivod(0);
            bool w5 = false;
            //foreach (Материал s in mat)
            //{
            //    w5 = Program.material1.Equals(s.Название);
            //    if (w5 == true)
            //    {
            //        id_mat = s.материалID;
            //    }
            //}
            var mater = Program.db5.Vivod(0);
            var v =
            from b in mater
            where ((Program.material1.Equals(b.Название) == true))
            select b.материалID;
            foreach (var b in v)
                id_mat = b;

            var zakaz = Program.db7.Vivod(0);
            string stat="Vipolnenie";
            MessageBox.Show(num.ToString());
            MessageBox.Show(id_meb.ToString());
            MessageBox.Show(id_mat.ToString());

        //    Program.db7.ADD(Program.dlina, Program.shirina, Program.glybina, id_mat, Program.stoimost, Program.Datetime_vipol, stat, id_meb, num);

        //    MessageBox.Show("Заказ создан");

        //    int nomer = 0;
        //    var doc = new Document();
        //    foreach (Заказ za in zakaz)
        //    {
        //        zakaz.Last();
        //        nomer = za.заказID;
        //    }
        //    PdfWriter.GetInstance(doc, new FileStream(way_dog + nomer.ToString() + @".pdf", FileMode.Create));
        //    doc.Open();
        //    BaseFont baseFont = BaseFont.CreateFont(@"D:\ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
        //    iTextSharp.text.Image z1 = iTextSharp.text.Image.GetInstance(way + @"Заголовок_внут.jpg");
        //    z1.Alignment = Element.ALIGN_CENTER;
        //    iTextSharp.text.Image z2 = iTextSharp.text.Image.GetInstance(way + @"Заголовок_внеш.jpg");
        //    z2.Alignment = Element.ALIGN_CENTER;


        //    iTextSharp.text.Phrase j3 = new Phrase("Тип: " + Program.vibmeb + " Длина: " + Program.dlina + " Ширина: " + Program.shirina + " Глубина: " + Program.glybina + " Материал: " + Program.material1 + " Вставка: " + Program.material2 + " Дата выполнения: " + Program.Datetime_vipol + " Стоимость: " + Program.stoimost,
        //   new iTextSharp.text.Font(baseFont, 12,
        //   iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
        //    Paragraph a3 = new Paragraph(j3);
        //    a3.SpacingAfter = 10;

        //    iTextSharp.text.Phrase j4 = new Phrase("Доставка: "+Program.vibdos+" Сборка: "+Program.vibsbor,
        //  new iTextSharp.text.Font(baseFont, 12,
        //  iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
        //    Paragraph a4 = new Paragraph(j4);
        //    a4.SpacingAfter = 10;

        //    iTextSharp.text.Phrase j1 = new Phrase("Заказ №" + nomer,
        //  new iTextSharp.text.Font(baseFont, 18,
        //  iTextSharp.text.Font.BOLDITALIC, new BaseColor(Color.DarkRed)));
        //    Paragraph a1 = new Paragraph(j1);
        //    a1.Alignment = Element.ALIGN_CENTER;
        //    a1.SpacingAfter = 30;

        //    iTextSharp.text.Phrase j2 = new Phrase("Клиент: "+ fio+" Контактный телефон: "+tel+" Электронная почта: "+mail,
        // new iTextSharp.text.Font(baseFont, 12,
        // iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
        //    Paragraph a2 = new Paragraph(j2);
        //    a2.SpacingAfter = 10;

        //    iTextSharp.text.Phrase j5 = new Phrase("Подпись: ",
        //new iTextSharp.text.Font(baseFont, 14,
        //iTextSharp.text.Font.ITALIC, new BaseColor(Color.Black)));
        //    Paragraph a5 = new Paragraph(j5);
        //    a5.SpacingAfter = 10;

        //    iTextSharp.text.Phrase j6 = new Phrase("Заказчик: ",
        //new iTextSharp.text.Font(baseFont, 12,
        //iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
        //    Paragraph a6 = new Paragraph(j6);
        //    a6.SpacingAfter = 10;

        //    iTextSharp.text.Phrase j7 = new Phrase("Исполнитель: ",
        //new iTextSharp.text.Font(baseFont, 12,
        //iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));
        //    Paragraph a7 = new Paragraph(j7);
        //    a7.SpacingAfter = 10;


        //    iTextSharp.text.Image k1 = iTextSharp.text.Image.GetInstance(way + openFileDialog1.FileName + @"_vnyt.jpg");
        //    k1.Alignment = Element.ALIGN_CENTER;
        //    k1.SpacingAfter = 10;
        //    iTextSharp.text.Image k2 = iTextSharp.text.Image.GetInstance(way + openFileDialog1.FileName + @"_vnesh.jpg");
        //    k2.Alignment = Element.ALIGN_CENTER;
        //    k2.SpacingAfter = 10;

        //    doc.Add(a1);
        //    doc.Add(a2);
        //    doc.Add(a3);
        //    doc.Add(a4);
        //    doc.Add(z1);
        //    doc.Add(k1);
        //    doc.Add(z2);
        //    doc.Add(k2);
        //    doc.Add(a5);
        //    doc.Add(a6);
        //    doc.Add(a7);
        //    doc.Close();

        //    MessageBox.Show("Сохранено в " + way_dog);
            //после выбора или создания эскиза показать стоимость

            //проверить хватает ли материалов

            //посчитать дату выполнения

            //выбор нужна ли доставка и установка(изменение стоимости)

            //занести новую запись в таблицу бд

            //создание договора (берутся данные с этой формы)

            //вывод сообщения готово
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
               // MessageBox.Show(med.ExtractText(openFileDialog1.FileName));
                med.Vibor();
                   
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Metods med = new Metods();
            ////med.ExtractText(openFileDialog1.FileName);
            //MessageBox.Show(med.ExtractText(openFileDialog1.FileName));
            //med.Vibor();
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
