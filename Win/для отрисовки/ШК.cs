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

namespace отрисовка
{
    public partial class ШкафКупе : Form
    {
        public ШкафКупе()
        {
            InitializeComponent();
        }

        public string way= @"C:\users\user\documents\visual studio 2013\Projects\отрисовка\Эскизы\";
        public Bitmap bmp7 = new Bitmap(300, 200);
        public Bitmap bmp8 = new Bitmap(300, 200);
        public bool eskiz1 = false;
        public bool eskiz2 = false;

        private void Form3_Load(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr1 = Graphics.FromImage(bmp1);
            Bitmap bmp2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics gr2 = Graphics.FromImage(bmp2);
            Bitmap bmp3 = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            Graphics gr3 = Graphics.FromImage(bmp3);
            Bitmap bmp4 = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            Graphics gr4 = Graphics.FromImage(bmp4);
            Bitmap bmp5 = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            Graphics gr5 = Graphics.FromImage(bmp5);
            Bitmap bmp6 = new Bitmap(pictureBox6.Width, pictureBox6.Height);
            Graphics gr6 = Graphics.FromImage(bmp6);
            Pen p = new Pen(Brushes.Black, 3);
            Pen l = new Pen(Brushes.Black, 5);
            Pen q = new Pen(Brushes.Silver, 3);

            gr1.FillRectangle(Brushes.Bisque, 0, 0, 200, 100);
            gr2.FillRectangle(Brushes.Bisque, 0, 0, 200, 100);
            gr3.FillRectangle(Brushes.Bisque, 0, 0, 200, 100);
            gr4.FillRectangle(Brushes.Bisque, 0, 0, 200, 100);
            gr5.FillRectangle(Brushes.Bisque, 0, 0, 200, 100);
            gr6.FillRectangle(Brushes.Bisque, 0, 0, 200, 100);

            gr1.DrawLine(l, 0, 0, 200, 0);
            gr1.DrawLine(l, 0, 0, 0, 100);
            gr1.DrawLine(l, 200, 0, 200, 100);
            gr1.DrawLine(l, 0, 100, 200, 100);
            gr2.DrawLine(l, 0, 0, 200, 0);
            gr2.DrawLine(l, 0, 0, 0, 100);
            gr2.DrawLine(l, 200, 0, 200, 100);
            gr2.DrawLine(l, 0, 100, 200, 100);
            gr3.DrawLine(l, 0, 0, 200, 0);
            gr3.DrawLine(l, 0, 0, 0, 100);
            gr3.DrawLine(l, 200, 0, 200, 100);
            gr3.DrawLine(l, 0, 100, 200, 100);
            gr4.DrawLine(l, 0, 0, 200, 0);
            gr4.DrawLine(l, 0, 0, 0, 100);
            gr4.DrawLine(l, 200, 0, 200, 100);
            gr4.DrawLine(l, 0, 100, 200, 100);
            gr5.DrawLine(l, 0, 0, 200, 0);
            gr5.DrawLine(l, 0, 0, 0, 100);
            gr5.DrawLine(l, 200, 0, 200, 100);
            gr5.DrawLine(l, 0, 100, 200, 100);
            gr6.DrawLine(l, 0, 0, 200, 0);
            gr6.DrawLine(l, 0, 0, 0, 100);
            gr6.DrawLine(l, 200, 0, 200, 100);
            gr6.DrawLine(l, 0, 100, 200, 100);

            gr1.DrawLine(p, 0, 20, 200, 20);
            gr1.DrawLine(p, 0, 80, 200, 80);
            gr1.DrawLine(p, 40, 0, 40, 100);
            gr1.DrawLine(q, 40, 26, 200, 26);
            pictureBox1.Image = bmp1;

            gr2.DrawLine(p, 0, 20, 200, 20);
            gr2.DrawLine(p, 0, 80, 200, 80);
            gr2.DrawLine(p, 160, 0, 160, 100);
            gr2.DrawLine(q, 0, 26, 160, 26);
            pictureBox2.Image = bmp2;

            gr3.DrawLine(p, 0, 20, 200, 20);
            gr3.DrawLine(p, 0, 80, 200, 80);
            gr3.DrawLine(p, 30, 0, 30, 100);
            gr3.DrawLine(p, 170, 0, 170, 100);
            gr3.DrawLine(q, 30, 26, 170, 26);
            pictureBox3.Image = bmp3;

            gr4.DrawLine(p, 0, 20, 200, 20);
            gr4.DrawLine(p, 0, 80, 200, 80);
            gr4.DrawLine(p, 40, 0, 40, 100);
            gr4.DrawLine(p, 80, 0, 80, 100);
            gr4.DrawLine(q, 80, 26, 200, 26);
            pictureBox4.Image = bmp4;

            gr5.DrawLine(p, 0, 20, 200, 20);
            gr5.DrawLine(p, 0, 80, 200, 80);
            gr5.DrawLine(p, 160, 0, 160, 100);
            gr5.DrawLine(p, 120, 0, 120, 100);
            gr5.DrawLine(q, 0, 26, 120, 26);
            pictureBox5.Image = bmp5;

            gr6.DrawLine(p, 0, 20, 200, 20);
            gr6.DrawLine(p, 0, 80, 200, 80);
            gr6.DrawLine(p, 30, 0, 30, 100);
            gr6.DrawLine(p, 170, 0, 170, 100);
            gr6.DrawLine(p, 60, 0, 60, 100);
            gr6.DrawLine(p, 140, 0, 140, 100);
            gr6.DrawLine(q, 60, 26, 140, 26);
            pictureBox6.Image = bmp6;
        }
           
        private void button2_Click(object sender, EventArgs e)
        {
            eskiz1 = true;
           // Bitmap bmp7 = new Bitmap(pictureBox7.Width, pictureBox7.Height);
            Graphics gr7 = Graphics.FromImage(bmp7);
            gr7.FillRectangle(Brushes.SlateGray, 0, 0, 300, 200);
            Pen p = new Pen(Brushes.Black, 3);
            Pen l = new Pen(Brushes.Black, 5);
            Pen q = new Pen(Brushes.Silver, 3);
            gr7.DrawLine(l, 0, 0, 300, 0);
            gr7.DrawLine(l, 0, 0, 0, 200);
            gr7.DrawLine(l, 300, 0, 300, 200);
            gr7.DrawLine(l, 0, 200, 300, 200);
            if (radioButton1.Checked==true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                gr7.DrawLine(p, 80, 0, 80, 200);
                gr7.DrawLine(q, 80, 60, 300, 60);
                pictureBox7.Image = bmp7;
            }
            if (radioButton2.Checked == true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                gr7.DrawLine(p, 220, 0, 220, 200);
                gr7.DrawLine(q, 0, 60, 220, 60);
                pictureBox7.Image = bmp7;
            }
            if (radioButton3.Checked == true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                gr7.DrawLine(p, 240, 0, 240, 200);
                gr7.DrawLine(p, 60, 0, 60, 200);
                gr7.DrawLine(q, 60, 60, 240, 60);
                pictureBox7.Image = bmp7;
            }
            if (radioButton4.Checked == true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                //gr7.DrawLine(p, 240, 0, 240, 200);
                //gr7.DrawLine(p, 180, 0, 180, 200);
                gr7.DrawLine(p, 60, 0, 60, 200);
                gr7.DrawLine(p, 120, 0, 120, 200);
                gr7.DrawLine(q, 120, 60, 300, 60);
                pictureBox7.Image = bmp7;
            }
            if (radioButton5.Checked == true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                gr7.DrawLine(p, 240, 0, 240, 200);
                gr7.DrawLine(p, 180, 0, 180, 200);
                //gr7.DrawLine(p, 60, 0, 60, 200);
                //gr7.DrawLine(p, 120, 0, 120, 200);
                gr7.DrawLine(q, 0, 60, 180, 60);
                pictureBox7.Image = bmp7;
            }
            if (radioButton6.Checked == true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                gr7.DrawLine(p, 260, 0, 260, 200);
                gr7.DrawLine(p, 220, 0, 220, 200);
                gr7.DrawLine(p, 40, 0, 40, 200);
                gr7.DrawLine(p, 80, 0, 80, 200);
                gr7.DrawLine(q, 80, 60, 220, 60);
                pictureBox7.Image = bmp7;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Bitmap bmp7 = new Bitmap(pictureBox7.Width, pictureBox7.Height);
            Graphics gr7 = Graphics.FromImage(bmp7);
            gr7.FillRectangle(Brushes.SlateGray, 0, 0, 300, 200);
            Pen p = new Pen(Brushes.Black, 3);
            Pen l = new Pen(Brushes.Black, 5);
            Pen q = new Pen(Brushes.Silver, 3);
            gr7.DrawLine(l, 0, 0, 300, 0);
            gr7.DrawLine(l, 0, 0, 0, 200);
            gr7.DrawLine(l, 300, 0, 300, 200);
            gr7.DrawLine(l, 0, 200, 300, 200);
            if (radioButton1.Checked == true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                gr7.DrawLine(p, 80, 0, 80, 200);
                gr7.DrawLine(q, 80, 60, 300, 60);
                if (radioButton7.Checked == true)
                {
                    gr7.DrawLine(p, 190, 0, 190, 45);
                    gr7.DrawLine(p, 190, 200, 190, 165);
                } 
                if (radioButton8.Checked == true)
                {
                    gr7.DrawLine(p, 150, 0, 150, 45);
                    gr7.DrawLine(p, 220, 0, 220, 45);
                    gr7.DrawLine(p, 150, 200, 150, 165);
                    gr7.DrawLine(p, 220, 200, 220, 165);
                }
                if (radioButton9.Checked == true)
                {
                    gr7.DrawLine(p, 0, 105, 80, 105);
                }
                if (radioButton10.Checked == true)
                {
                    gr7.DrawLine(p, 0, 80, 80, 80);
                    gr7.DrawLine(p, 0, 120, 80, 120);
                } 

                pictureBox7.Image = bmp7;
            }
            if (radioButton2.Checked == true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                gr7.DrawLine(p, 220, 0, 220, 200);
                gr7.DrawLine(q, 0, 60, 220, 60);
                if (radioButton7.Checked == true)
                {
                    gr7.DrawLine(p, 105, 0, 105, 45);
                    gr7.DrawLine(p, 105, 200, 105, 165);
                }
                if (radioButton8.Checked == true)
                {
                    gr7.DrawLine(p, 80, 0, 80, 45);
                    gr7.DrawLine(p, 150, 0, 150, 45);
                    gr7.DrawLine(p, 80, 200, 80, 165);
                    gr7.DrawLine(p, 150, 200, 150, 165);
                }
                if (radioButton9.Checked == true)
                {
                    gr7.DrawLine(p, 220, 105, 300, 105);
                }
                if (radioButton10.Checked == true)
                {
                    gr7.DrawLine(p, 220, 80, 300, 80);
                    gr7.DrawLine(p, 220, 120, 300, 120);
                } 
                pictureBox7.Image = bmp7;
            }
            if (radioButton3.Checked == true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                gr7.DrawLine(p, 240, 0, 240, 200);
                gr7.DrawLine(p, 60, 0, 60, 200);
                gr7.DrawLine(q, 60, 60, 240, 60);
                if (radioButton7.Checked == true)
                {
                    gr7.DrawLine(p, 150, 0, 150, 45);
                    gr7.DrawLine(p, 150, 200, 150, 165);
                }
                if (radioButton8.Checked == true)
                {
                    gr7.DrawLine(p, 110, 0, 110, 45);
                    gr7.DrawLine(p, 180, 0, 180, 45);
                    gr7.DrawLine(p, 110, 200, 110, 165);
                    gr7.DrawLine(p, 180, 200, 180, 165);
                }
                if (radioButton9.Checked == true)
                {
                    gr7.DrawLine(p, 0, 110, 60, 110);
                    gr7.DrawLine(p, 240, 110, 300, 110);
                }
                if (radioButton10.Checked == true)
                {
                    gr7.DrawLine(p, 0, 80, 60, 80);
                    gr7.DrawLine(p, 0, 120, 60, 120);
                    gr7.DrawLine(p, 240, 80, 300, 80);
                    gr7.DrawLine(p, 240, 120, 300, 120);
                } 
                pictureBox7.Image = bmp7;
            }
            if (radioButton4.Checked == true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                gr7.DrawLine(p, 60, 0, 60, 200);
                gr7.DrawLine(p, 120, 0, 120, 200);
                gr7.DrawLine(q, 120, 60, 300, 60);
                if (radioButton7.Checked == true)
                {
                    gr7.DrawLine(p, 210, 0, 210, 45);
                    gr7.DrawLine(p, 210, 200, 210, 165);
                }
                if (radioButton8.Checked == true)
                {
                    gr7.DrawLine(p, 180, 0, 180, 45);
                    gr7.DrawLine(p, 240, 0, 240, 45);
                    gr7.DrawLine(p, 180, 200, 180, 165);
                    gr7.DrawLine(p, 240, 200, 240, 165);
                }
                if (radioButton9.Checked == true)
                {
                    gr7.DrawLine(p, 0, 105, 120, 105);
                }
                if (radioButton10.Checked == true)
                {
                    gr7.DrawLine(p, 0, 80, 120, 80);
                    gr7.DrawLine(p, 0, 120, 120, 120);
                } 
                pictureBox7.Image = bmp7;
            }
            if (radioButton5.Checked == true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                gr7.DrawLine(p, 240, 0, 240, 200);
                gr7.DrawLine(p, 180, 0, 180, 200);
                gr7.DrawLine(q, 0, 60, 180, 60);
                if (radioButton7.Checked == true)
                {
                    gr7.DrawLine(p, 90, 0, 90, 45);
                    gr7.DrawLine(p, 90, 200, 90, 165);
                }
                if (radioButton8.Checked == true)
                {
                    gr7.DrawLine(p, 60, 0, 60, 45);
                    gr7.DrawLine(p, 120, 0, 120, 45);
                    gr7.DrawLine(p, 60, 200, 60, 165);
                    gr7.DrawLine(p, 120, 200, 120, 165);
                }
                if (radioButton9.Checked == true)
                {
                    gr7.DrawLine(p, 180, 105, 300, 105);
                }
                if (radioButton10.Checked == true)
                {
                    gr7.DrawLine(p, 180, 80, 300, 80);
                    gr7.DrawLine(p, 180, 120, 300, 120);
                } 
                pictureBox7.Image = bmp7;
            }
            if (radioButton6.Checked == true)
            {
                gr7.DrawLine(p, 0, 45, 300, 45);
                gr7.DrawLine(p, 0, 165, 300, 165);
                gr7.DrawLine(p, 260, 0, 260, 200);
                gr7.DrawLine(p, 220, 0, 220, 200);
                gr7.DrawLine(p, 40, 0, 40, 200);
                gr7.DrawLine(p, 80, 0, 80, 200);
                gr7.DrawLine(q, 80, 60, 220, 60);
                if (radioButton7.Checked == true)
                {
                    gr7.DrawLine(p, 150, 0, 150, 45);
                    gr7.DrawLine(p, 150, 200, 150, 165);
                }
                if (radioButton8.Checked == true)
                {
                    gr7.DrawLine(p, 120, 0, 120, 45);
                    gr7.DrawLine(p, 180, 0, 180, 45);
                    gr7.DrawLine(p, 120, 200, 120, 165);
                    gr7.DrawLine(p, 180, 200, 180, 165);
                }
                if (radioButton9.Checked == true)
                {
                    gr7.DrawLine(p, 0, 110, 80, 110);
                    gr7.DrawLine(p, 220, 110, 300, 110);
                }
                if (radioButton10.Checked == true)
                {
                    gr7.DrawLine(p, 0, 80, 80, 80);
                    gr7.DrawLine(p, 0, 120, 80, 120);
                    gr7.DrawLine(p, 220, 80, 300, 80);
                    gr7.DrawLine(p, 220, 120, 300, 120);
                } 
                pictureBox7.Image = bmp7;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eskiz2 = true;
           // Bitmap bmp8 = new Bitmap(pictureBox8.Width, pictureBox8.Height);
            Graphics gr8 = Graphics.FromImage(bmp8);
            Pen p = new Pen(Brushes.Black, 3);
            Pen q = new Pen(Brushes.Silver, 3);
            gr8.FillRectangle(Brushes.SaddleBrown, 0, 0, 300, 200);
            if (radioButton12.Checked == true)
            {
                if (radioButton15.Checked == true)
                {
                    gr8.DrawLine(p, 150, 0, 150, 200);
                    gr8.DrawLine(q, 10, 5, 10, 190);
                    gr8.DrawLine(q, 290, 5, 290, 190);
                }
                if (radioButton14.Checked == true)
                {
                    gr8.FillRectangle(Brushes.LightBlue, 5, 5, 290, 190);
                    gr8.DrawLine(p, 150, 0, 150, 200);
                    gr8.DrawLine(q, 10, 5, 10, 190);
                    gr8.DrawLine(q, 290, 5, 290, 190);
                }
            }
            if (radioButton11.Checked == true)
            {
                if (radioButton15.Checked == true)
                {
                    gr8.FillRectangle(Brushes.Chocolate, 100, 5, 100, 195);
                    gr8.DrawLine(q, 10, 5, 10, 190);
                    gr8.DrawLine(q, 290, 5, 290, 190);
                }
                if (radioButton14.Checked == true)
                {
                    gr8.FillRectangle(Brushes.Blue, 5, 5, 290, 190);
                    gr8.FillRectangle(Brushes.LightBlue, 100, 5, 100, 190);
                    gr8.DrawLine(q, 10, 5, 10, 190);
                    gr8.DrawLine(q, 290, 5, 290, 190);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.FillRectangle(Brushes.LightBlue, 100, 5, 100, 195);
                    gr8.DrawLine(q, 10, 5, 10, 190);
                    gr8.DrawLine(q, 290, 5, 290, 190);
                }
            }
            pictureBox8.Image = bmp8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (comboBox1.Text == ""))
                {
                    MessageBox.Show("Часть полей не заполнено");
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
            try
            {
                if ((eskiz1 == false) || (eskiz2 == false))
                {
                    MessageBox.Show("Ошибка: не нарисован эскиз");
                    return;
                }
            }
            catch { }

            string str = textBox4.Text;
            bmp7.Save(way+str+@"_vnyt.jpg");
            bmp8.Save(way + str + @"_vnesh.jpg");
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(way+str+@".pdf", FileMode.Create));
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont(@"D:\ARIAL.TTF",BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Phrase j1 = new Phrase("Внутреннее устройство",
            new iTextSharp.text.Font(baseFont, 14,
            iTextSharp.text.Font.BOLDITALIC, new BaseColor(Color.Red)));
            Paragraph a1 = new Paragraph(j1);
            a1.Alignment = Element.ALIGN_CENTER;
            a1.SpacingAfter = 10;
            iTextSharp.text.Phrase j2 = new Phrase("Внешний вид",
            new iTextSharp.text.Font(baseFont, 14,
            iTextSharp.text.Font.BOLDITALIC, new BaseColor(Color.Red)));
            Paragraph a2 = new Paragraph(j2);
            a2.Alignment = Element.ALIGN_CENTER;
            a2.SpacingAfter = 10;

            iTextSharp.text.Phrase j3 = new Phrase("Длина: "+textBox1.Text+"   Ширина: "+textBox2.Text+"    Глубина: "+textBox3.Text+"    Материал: "+comboBox1.Text,
           new iTextSharp.text.Font(baseFont, 14,
           iTextSharp.text.Font.BOLDITALIC, new BaseColor(Color.Black)));
            Paragraph a3 = new Paragraph(j3);
            a3.SpacingAfter = 10;

            iTextSharp.text.Image k1 = iTextSharp.text.Image.GetInstance(way + str + @"_vnyt.jpg");
            k1.Alignment = Element.ALIGN_CENTER;
            k1.SpacingAfter = 10;
            iTextSharp.text.Image k2 = iTextSharp.text.Image.GetInstance(way + str + @"_vnesh.jpg");
            k2.Alignment = Element.ALIGN_CENTER;
            k2.SpacingAfter = 10;

            doc.Add(a1);
            doc.Add(k1);
            doc.Add(a2);
            doc.Add(k2);
            doc.Add(a3);
            doc.Close();

            MessageBox.Show("Сохранено в "+way);
        }
    }
}
