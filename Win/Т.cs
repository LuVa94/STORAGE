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
    public partial class Т : Form
    {
        public Т()
        {
            InitializeComponent();
        }
        public string way = @"C:\users\user\documents\visual studio 2013\Projects\WinLinq\Эскизы\";
        public Bitmap bmp1 = new Bitmap(300, 300);
        public bool eskiz1 = false;
        public bool eskiz2 = false;

        private void Тумбочка_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet1.Материал". При необходимости она может быть перемещена или удалена.
            this.материалTableAdapter.Fill(this.asdDataSet1.Материал);
            Bitmap bmp2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics gr2 = Graphics.FromImage(bmp2);
            Bitmap bmp3 = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            Graphics gr3 = Graphics.FromImage(bmp3);
            Bitmap bmp4 = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            Graphics gr4 = Graphics.FromImage(bmp4);
            Bitmap bmp5 = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            Graphics gr5 = Graphics.FromImage(bmp5);

            Pen p = new Pen(Brushes.Black, 3);
            Pen l = new Pen(Brushes.Black, 5);
            Pen w = new Pen(Brushes.DimGray, 5);

            gr2.FillRectangle(Brushes.Chocolate, 0, 0, 100, 100);
            gr3.FillRectangle(Brushes.Chocolate, 0, 0, 100, 100);
            gr4.FillRectangle(Brushes.Chocolate, 0, 0, 100, 100);
            gr5.FillRectangle(Brushes.Chocolate, 0, 0, 100, 100);


            gr2.DrawLine(l, 0, 0, 100, 0);
            gr2.DrawLine(l, 0, 0, 0, 100);
            gr2.DrawLine(l, 100, 0, 100, 100);
            gr2.DrawLine(l, 0, 100, 100, 100);
            gr3.DrawLine(l, 0, 0, 100, 0);
            gr3.DrawLine(l, 0, 0, 0, 100);
            gr3.DrawLine(l, 100, 0, 100, 100);
            gr3.DrawLine(l, 0, 100, 100, 100);
            gr4.DrawLine(l, 0, 0, 100, 0);
            gr4.DrawLine(l, 0, 0, 0, 100);
            gr4.DrawLine(l, 100, 0, 100, 100);
            gr4.DrawLine(l, 0, 100, 100, 100);
            gr5.DrawLine(l, 0, 0, 100, 0);
            gr5.DrawLine(l, 0, 0, 0, 100);
            gr5.DrawLine(l, 100, 0, 100, 100);
            gr5.DrawLine(l, 0, 100, 100, 100);

            pictureBox2.Image = bmp2;

            gr3.DrawLine(p, 0, 50, 100, 50);
            gr3.FillRectangle(Brushes.Bisque, 3, 3, 94, 46);
            pictureBox3.Image = bmp3;

            gr4.DrawLine(p, 0, 33, 100, 33);
            gr4.DrawLine(p, 0, 65, 100, 65);
            pictureBox4.Image = bmp4;

            gr5.DrawLine(p, 0, 30, 100, 30);
            gr5.FillRectangle(Brushes.Bisque, 3, 3, 94, 26);
            pictureBox5.Image = bmp5;

            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            eskiz1 = true;
            // Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr1 = Graphics.FromImage(bmp1);
            Pen p = new Pen(Brushes.Black, 3);
            Pen l = new Pen(Brushes.Black, 8);
            Pen w = new Pen(Brushes.DimGray, 5);
            gr1.FillRectangle(Brushes.Chocolate, 0, 0, 300, 300);
            gr1.DrawLine(l, 0, 0, 300, 0);
            gr1.DrawLine(l, 300, 0, 300, 300);
            gr1.DrawLine(l, 0, 300, 300, 300);
            gr1.DrawLine(l, 0, 0, 0, 300);

            if (radioButton1.Checked == true)
            {
                if (radioButton7.Checked == true)
                {
                    gr1.DrawRectangle(w, 100, 20, 100, 20);
                }

                if (radioButton8.Checked == true)
                {
                    gr1.DrawEllipse(w, 20, 140, 20, 20);
                }
            }
            if (radioButton2.Checked == true)
            {
                if (radioButton7.Checked == true)
                {
                    gr1.DrawLine(p, 0, 150, 300, 150);
                    gr1.FillRectangle(Brushes.Bisque, 5, 5, 290, 142);
                    gr1.DrawRectangle(w, 100, 170, 100, 20);
                }

                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 150, 300, 150);
                    gr1.FillRectangle(Brushes.Bisque, 5, 5, 290, 142);
                    gr1.DrawEllipse(w, 20, 215, 20, 20);
                }
            }
            if (radioButton3.Checked == true)
            {
                if (radioButton7.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 300, 100);
                    gr1.DrawLine(p, 0, 200, 300, 200);
                    gr1.DrawRectangle(w, 100, 20, 100, 20);
                    gr1.DrawRectangle(w, 100, 120, 100, 20);
                    gr1.DrawRectangle(w, 100, 220, 100, 20);
                }

                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 300, 100);
                    gr1.DrawLine(p, 0, 200, 300, 200);
                    gr1.DrawEllipse(w, 20, 40, 20, 20);
                    gr1.DrawEllipse(w, 20, 140, 20, 20);
                    gr1.DrawEllipse(w, 20, 240, 20, 20);
                }
            }
            if (radioButton4.Checked == true)
            {
                if (radioButton7.Checked == true)
                {
                    gr1.DrawLine(p, 0, 90, 300, 90);
                    gr1.FillRectangle(Brushes.Bisque, 5, 5, 290, 83);
                    gr1.DrawRectangle(w, 100, 110, 100, 20);
                }

                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 90, 300, 90);
                    gr1.FillRectangle(Brushes.Bisque, 5, 5, 290, 83);
                    gr1.DrawEllipse(w, 20, 170, 20, 20);
                }
            }
            pictureBox1.Image = bmp1;
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (comboBox1.Text == ""))
                {
                    MessageBox.Show("Часть полей не заполнено");
                    return;
                }
                if ((Convert.ToInt32(textBox1.Text) < 200) || (Convert.ToInt32(textBox2.Text) < 200) || (Convert.ToInt32(textBox3.Text) < 200))
                {
                    MessageBox.Show("Введенные размеры малы");
                    return;
                }
            }
            catch { }
            try
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Ошибка: не введено название");
                    return;
                }
            }
            catch { }
           

            Program.dlina = Convert.ToInt32(textBox1.Text);
            Program.shirina = Convert.ToInt32(textBox2.Text);
            Program.glybina = Convert.ToInt32(textBox3.Text);
            Program.material1 = comboBox1.Text;

            string str = textBox4.Text;
            bmp1.Save(way + str + @"_vnesh.jpg");
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(way + str + @".pdf", FileMode.Create));
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont(@"D:\ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
           
            iTextSharp.text.Image z2 = iTextSharp.text.Image.GetInstance(way + @"Заголовок_внеш.jpg");
            z2.Alignment = Element.ALIGN_CENTER;

            iTextSharp.text.Phrase j3 = new Phrase("Тип: Tymbochka Длина: " + textBox1.Text + " Ширина: " + textBox2.Text + " Глубина: " + textBox3.Text + " Материал: " + comboBox1.Text  + " Дата выполнения: " + Program.Datetime_vipol + "  Стоимость: " + Program.stoimost
                + " Доставка: " + Program.vibdos + " Сборка: " + Program.vibsbor,
           new iTextSharp.text.Font(baseFont, 14,
           iTextSharp.text.Font.BOLDITALIC, new BaseColor(Color.Black)));
            Paragraph a3 = new Paragraph(j3);
            a3.SpacingAfter = 10;


            iTextSharp.text.Image k2 = iTextSharp.text.Image.GetInstance(way + str + @"_vnesh.jpg");
            k2.Alignment = Element.ALIGN_CENTER;
            k2.SpacingAfter = 10;

            doc.Add(z2);
            doc.Add(k2);
            doc.Add(a3);
            doc.Close();

            MessageBox.Show("Сохранено в " + way);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (comboBox1.Text == ""))
                {
                    MessageBox.Show("Часть полей не заполнено");
                    return;
                }
                if ((Convert.ToInt32(textBox1.Text) < 200) || (Convert.ToInt32(textBox2.Text) < 200) || (Convert.ToInt32(textBox3.Text) < 200))
                {
                    MessageBox.Show("Введенные размеры малы");
                    return;
                }
            }
            catch { }


            //для запоминания данных (для создания договора)
            Program.dlina = Convert.ToInt32(textBox1.Text);
            Program.shirina = Convert.ToInt32(textBox2.Text);
            Program.glybina = Convert.ToInt32(textBox3.Text);
            Program.material1 = comboBox1.Text;
            //Program.stoimost = 0;
            //Program.Datetime_vipol;

            button1.Enabled = false;
            button2.Enabled = false;
            StimostDatetime f2 = new StimostDatetime();
            f2.ShowDialog();

            button2.Enabled = true;
        }

    }
}
