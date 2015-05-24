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
    public partial class К : Form
    {
        public К()
        {
            InitializeComponent();
        }
        public string way = @"C:\users\user\documents\visual studio 2013\Projects\WinLinq\Эскизы\";
        public Bitmap bmp1 = new Bitmap(200, 200);
        public Bitmap bmp8 = new Bitmap(200, 200);
        public bool eskiz1 = false;
        public bool eskiz2 = false;
        public bool q1, q2, q3 = false;

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet2.Материал". При необходимости она может быть перемещена или удалена.
            this.материалTableAdapter1.Fill(this.asdDataSet2.Материал);
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
            Bitmap bmp6 = new Bitmap(pictureBox6.Width, pictureBox6.Height);
            Graphics gr6 = Graphics.FromImage(bmp6);
            Bitmap bmp7 = new Bitmap(pictureBox7.Width, pictureBox7.Height);
            Graphics gr7 = Graphics.FromImage(bmp7);
            Pen p = new Pen(Brushes.Black, 3);
            Pen l = new Pen(Brushes.Black, 5);
            Pen w = new Pen(Brushes.DimGray, 5);

            gr2.FillRectangle(Brushes.Chocolate, 0, 0, 90, 120);
            gr3.FillRectangle(Brushes.Chocolate, 0, 0, 90, 120);
            gr3.FillRectangle(Brushes.LightGoldenrodYellow, 0, 0, 90, 20);
            gr4.FillRectangle(Brushes.Chocolate, 0, 0, 90, 120);
            gr5.FillRectangle(Brushes.Chocolate, 0, 0, 90, 120);
            gr6.FillRectangle(Brushes.Chocolate, 0, 0, 90, 120);
            gr6.FillRectangle(Brushes.LightGoldenrodYellow, 45, 0, 45, 120);
            gr7.FillRectangle(Brushes.Chocolate, 0, 0, 90, 120);

            gr2.DrawLine(l, 0, 0, 90, 0);
            gr2.DrawLine(l, 0, 0, 0, 90);
            gr2.DrawLine(l, 90, 0, 90, 90);
            gr2.DrawLine(l, 0, 90, 90, 90);
            gr3.DrawLine(l, 0, 0, 90, 0);
            gr3.DrawLine(l, 0, 0, 0, 90);
            gr3.DrawLine(l, 90, 0, 90, 90);
            gr3.DrawLine(l, 0, 90, 90, 90);
            gr4.DrawLine(l, 0, 0, 90, 0);
            gr4.DrawLine(l, 0, 0, 0, 90);
            gr4.DrawLine(l, 90, 0, 90, 90);
            gr4.DrawLine(l, 0, 90, 90, 90);
            gr5.DrawLine(l, 0, 0, 90, 0);
            gr5.DrawLine(l, 0, 0, 0, 90);
            gr5.DrawLine(l, 90, 0, 90, 90);
            gr5.DrawLine(l, 0, 90, 90, 90);
            gr6.DrawLine(l, 0, 0, 90, 0);
            gr6.DrawLine(l, 0, 0, 0, 90);
            gr6.DrawLine(l, 90, 0, 90, 90);
            gr6.DrawLine(l, 0, 90, 90, 90);
            gr7.DrawLine(l, 0, 0, 90, 0);
            gr7.DrawLine(l, 0, 0, 0, 90);
            gr7.DrawLine(l, 90, 0, 90, 90);
            gr7.DrawLine(l, 0, 90, 90, 90);

            gr2.DrawLine(p, 45, 0, 45, 120);
            gr2.DrawEllipse(w, 35, 5, 5, 5);
            gr2.DrawEllipse(w, 50, 5, 5, 5);
            pictureBox2.Image = bmp2;

            gr3.DrawLine(p, 45, 0, 45, 120);
            gr3.DrawLine(p, 0, 20, 90, 20);
            gr3.DrawEllipse(w, 35, 25, 5, 5);
            gr3.DrawEllipse(w, 50, 25, 5, 5);
            pictureBox3.Image = bmp3;

            gr4.DrawLine(p, 45, 0, 45, 120);
            gr4.DrawLine(p, 0, 20, 90, 20);
            gr4.DrawEllipse(w, 35, 25, 5, 5);
            gr4.DrawEllipse(w, 50, 25, 5, 5);
            gr4.DrawLine(w, 15, 12, 28, 12);
            gr4.DrawLine(w, 62, 12, 75, 12);
            pictureBox4.Image = bmp4;

            gr5.DrawLine(p, 0, 30, 90, 30);
            gr5.DrawLine(p, 0, 60, 90, 60);
            gr5.DrawLine(w, 30, 7, 60, 7);
            gr5.DrawLine(w, 30, 35, 60, 35);
            gr5.DrawLine(w, 30, 65, 60, 65);
            pictureBox5.Image = bmp5;

            gr6.DrawLine(p, 45, 0, 45, 90);
            gr6.DrawLine(p, 45, 30, 90, 30);
            gr6.DrawLine(p, 45, 60, 90, 60);
            gr6.DrawEllipse(w, 35, 5, 5, 5);
            pictureBox6.Image = bmp6;

            gr7.DrawLine(p, 45, 0, 45, 90);
            gr7.DrawLine(p, 45, 30, 90, 30);
            gr7.DrawLine(p, 45, 60, 90, 60);
            gr7.DrawEllipse(w, 35, 5, 5, 5);
            gr7.DrawLine(w, 55, 7, 80, 7);
            gr7.DrawLine(w, 55, 35, 80, 35);
            gr7.DrawLine(w, 55, 65, 80, 65);
            pictureBox7.Image = bmp7;

            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eskiz1 = true;
            button2.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            // Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr1 = Graphics.FromImage(bmp1);
            Pen p = new Pen(Brushes.Black, 3);
            Pen l = new Pen(Brushes.Black, 5);
            Pen q = new Pen(Brushes.Silver, 3);
            gr1.FillRectangle(Brushes.Bisque, 0, 0, 200, 300);
            gr1.DrawLine(l, 0, 0, 200, 0);
            gr1.DrawLine(l, 0, 0, 0, 200);
            gr1.DrawLine(l, 200, 0, 200, 200);
            gr1.DrawLine(l, 0, 200, 200, 200);
            if (radioButton7.Checked == true)
            {
                gr1.DrawLine(p, 0, 100, 200, 100);
                q1 = true;
            }
            if (radioButton8.Checked == true)
            {
                gr1.DrawLine(p, 0, 65, 200, 65);
                gr1.DrawLine(p, 0, 130, 200, 130);
                q2 = true;
            }
            if (radioButton9.Checked == true)
            {
                gr1.DrawLine(p, 0, 40, 200, 40);
                gr1.DrawLine(p, 0, 80, 200, 80);
                gr1.DrawLine(p, 0, 120, 200, 120);
                gr1.DrawLine(p, 0, 160, 200, 160);
                q3 = true;
            }
            if (radioButton21.Checked == true)
            {
                gr1.DrawLine(p, 100, 0, 100, 200);
            }
            pictureBox1.Image = bmp1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eskiz2 = true;
            button5.Enabled = true;
            button4.Enabled = false;
            button1.Enabled = false;
            // Bitmap bmp8 = new Bitmap(pictureBox8.Width, pictureBox8.Height);
            Graphics gr8 = Graphics.FromImage(bmp8);
            Graphics gr1 = Graphics.FromImage(bmp1);
            Pen p = new Pen(Brushes.Black, 3);
            Pen l = new Pen(Brushes.Black, 5);
            Pen w = new Pen(Brushes.DimGray, 5);
            gr8.FillRectangle(Brushes.Chocolate, 0, 0, 200, 300);
            gr8.DrawLine(l, 0, 0, 200, 0);
            gr8.DrawLine(l, 0, 0, 0, 200);
            gr8.DrawLine(l, 200, 0, 200, 200);
            gr8.DrawLine(l, 0, 200, 200, 200);
            if (radioButton1.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 200);
                    gr8.DrawEllipse(w, 85, 15, 10, 10);
                    gr8.DrawEllipse(w, 105, 15, 10, 10);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 200);
                    gr8.FillRectangle(Brushes.LightGray, 10, 10, 80, 180);
                    gr8.FillRectangle(Brushes.LightGray, 110, 10, 80, 180);
                    gr8.DrawEllipse(w, 85, 15, 10, 10);
                    gr8.DrawEllipse(w, 105, 15, 10, 10);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 180);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 180);
                    gr8.DrawEllipse(w, 85, 15, 10, 10);
                    gr8.DrawEllipse(w, 105, 15, 10, 10);
                }
            }

            if (radioButton2.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 200);
                    gr8.DrawLine(p, 0, 30, 200, 30);
                    gr8.DrawEllipse(w, 85, 35, 10, 10);
                    gr8.DrawEllipse(w, 105, 35, 10, 10);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 200);
                    gr8.DrawLine(p, 0, 30, 200, 30);
                    gr8.FillRectangle(Brushes.LightGray, 10, 40, 80, 150);
                    gr8.FillRectangle(Brushes.LightGray, 110, 40, 80, 150);
                    gr8.DrawEllipse(w, 85, 35, 10, 10);
                    gr8.DrawEllipse(w, 105, 35, 10, 10);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 200);
                    gr8.DrawLine(p, 0, 30, 200, 30);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 40, 80, 150);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 40, 80, 150);
                    gr8.DrawEllipse(w, 85, 35, 10, 10);
                    gr8.DrawEllipse(w, 105, 35, 10, 10);
                }
                gr1.FillRectangle(Brushes.Bisque, 0, 0, 200, 300);
                gr1.FillRectangle(Brushes.LightGoldenrodYellow, 0, 0, 200, 30);
                gr1.DrawLine(l, 0, 0, 200, 0);
                gr1.DrawLine(l, 0, 0, 0, 200);
                gr1.DrawLine(l, 200, 0, 200, 200);
                gr1.DrawLine(l, 0, 200, 200, 200);
                gr1.DrawLine(p, 0, 30, 200, 30);
                gr1.DrawLine(p, 100, 0, 100, 30);
                if (radioButton7.Checked == true)
                {
                    gr1.DrawLine(p, 0, 115, 200, 115);
                }
                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 83, 200, 83);
                    gr1.DrawLine(p, 0, 136, 200, 136);
                }
                if (radioButton9.Checked == true)
                {
                    gr1.DrawLine(p, 0, 80, 200, 80);
                    gr1.DrawLine(p, 0, 120, 200, 120);
                    gr1.DrawLine(p, 0, 160, 200, 160);
                }
                if (radioButton21.Checked == true)
                {
                    gr1.DrawLine(p, 100, 0, 100, 200);
                }
            }
            if (radioButton3.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 200);
                    gr8.DrawLine(p, 0, 30, 200, 30);
                    gr8.DrawLine(w, 30, 12, 70, 12);
                    gr8.DrawLine(w, 130, 12, 170, 12);
                    gr8.DrawEllipse(w, 85, 35, 8, 8);
                    gr8.DrawEllipse(w, 105, 35, 8, 8);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 200);
                    gr8.DrawLine(p, 0, 30, 200, 30);
                    gr8.FillRectangle(Brushes.LightGray, 10, 40, 80, 150);
                    gr8.FillRectangle(Brushes.LightGray, 110, 40, 80, 150);
                    gr8.DrawLine(w, 30, 12, 70, 12);
                    gr8.DrawLine(w, 130, 12, 170, 12);
                    gr8.DrawEllipse(w, 85, 35, 8, 8);
                    gr8.DrawEllipse(w, 105, 35, 8, 8);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 200);
                    gr8.DrawLine(p, 0, 30, 200, 30);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 40, 80, 150);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 40, 80, 150);
                    gr8.DrawLine(w, 30, 12, 70, 12);
                    gr8.DrawLine(w, 130, 12, 170, 12);
                    gr8.DrawEllipse(w, 85, 35, 8, 8);
                    gr8.DrawEllipse(w, 105, 35, 8, 8);
                }
                if (radioButton16.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 200);
                    gr8.DrawLine(p, 0, 30, 200, 30);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 40, 80, 150);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 40, 80, 150);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 10);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 10);
                    gr8.DrawLine(w, 30, 12, 70, 12);
                    gr8.DrawLine(w, 130, 12, 170, 12);
                    gr8.DrawEllipse(w, 85, 35, 8, 8);
                    gr8.DrawEllipse(w, 105, 35, 8, 8);
                }
                gr1.FillRectangle(Brushes.Bisque, 0, 0, 200, 300);
                gr1.FillRectangle(Brushes.Chocolate, 0, 0, 200, 30);
                gr1.DrawLine(l, 0, 0, 200, 0);
                gr1.DrawLine(l, 0, 0, 0, 200);
                gr1.DrawLine(l, 200, 0, 200, 200);
                gr1.DrawLine(l, 0, 200, 200, 200);
                gr1.DrawLine(p, 0, 30, 200, 30);
                gr1.DrawLine(p, 100, 0, 100, 30);
                gr1.DrawLine(w, 30, 12, 70, 12);
                gr1.DrawLine(w, 130, 12, 170, 12);
                if (radioButton7.Checked == true)
                {
                    gr1.DrawLine(p, 0, 115, 200, 115);
                }
                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 83, 200, 83);
                    gr1.DrawLine(p, 0, 136, 200, 136);
                }
                if (radioButton9.Checked == true)
                {
                    gr1.DrawLine(p, 0, 80, 200, 80);
                    gr1.DrawLine(p, 0, 120, 200, 120);
                    gr1.DrawLine(p, 0, 160, 200, 160);
                }
                if (radioButton21.Checked == true)
                {
                    gr1.DrawLine(p, 100, 0, 100, 200);
                }
            }
            if (radioButton4.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 0, 65, 200, 65);
                    gr8.DrawLine(p, 0, 130, 200, 130);
                    gr8.DrawLine(w, 30, 10, 170, 10);
                    gr8.DrawLine(w, 30, 75, 170, 75);
                    gr8.DrawLine(w, 30, 140, 170, 140);
                    comboBox2.Text = "нет";
                }
                if (radioButton16.Checked == true)
                {
                    gr8.DrawLine(p, 0, 65, 200, 65);
                    gr8.DrawLine(p, 0, 130, 200, 130);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 180, 50);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 70, 180, 55);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 135, 180, 55);
                    gr8.DrawLine(w, 30, 10, 170, 10);
                    gr8.DrawLine(w, 30, 75, 170, 75);
                    gr8.DrawLine(w, 30, 140, 170, 140);
                }
                gr1.FillRectangle(Brushes.Bisque, 0, 0, 200, 300);
                gr1.DrawLine(l, 0, 0, 200, 0);
                gr1.DrawLine(l, 0, 0, 0, 200);
                gr1.DrawLine(l, 200, 0, 200, 200);
                gr1.DrawLine(l, 0, 200, 200, 200);
                gr1.DrawLine(p, 0, 65, 200, 65);
                gr1.DrawLine(p, 0, 130, 200, 130);
                gr1.DrawLine(p, 0, 65, 200, 65);
                gr1.DrawLine(p, 0, 130, 200, 130);
                gr1.DrawLine(w, 30, 10, 170, 10);
                gr1.DrawLine(w, 30, 75, 170, 75);
                gr1.DrawLine(w, 30, 140, 170, 140);
                pictureBox1.Image = bmp1;
            }
            if (radioButton5.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 100, 65, 200, 65);
                    gr8.DrawLine(p, 100, 130, 200, 130);
                    gr8.DrawEllipse(w, 85, 15, 10, 10);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 100, 65, 200, 65);
                    gr8.DrawLine(p, 100, 130, 200, 130);
                    gr8.FillRectangle(Brushes.LightGray, 10, 10, 80, 180);
                    gr8.DrawEllipse(w, 85, 15, 10, 10);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 100, 65, 200, 65);
                    gr8.DrawLine(p, 100, 130, 200, 130);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 180);
                    gr8.DrawEllipse(w, 85, 15, 10, 10);
                }
                gr1.FillRectangle(Brushes.Bisque, 0, 0, 200, 300);
                gr1.FillRectangle(Brushes.LightGoldenrodYellow, 100, 0, 100, 300);
                gr1.DrawLine(l, 0, 0, 200, 0);
                gr1.DrawLine(l, 0, 0, 0, 200);
                gr1.DrawLine(l, 200, 0, 200, 200);
                gr1.DrawLine(l, 0, 200, 200, 200);
                gr1.DrawLine(p, 100, 0, 100, 220);
                gr1.DrawLine(p, 100, 65, 200, 65);
                gr1.DrawLine(p, 100, 130, 200, 130);
                if (radioButton7.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                }
                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 65, 100, 65);
                    gr1.DrawLine(p, 0, 130, 100, 130);
                }
                if (radioButton9.Checked == true)
                {
                    gr1.DrawLine(p, 0, 40, 100, 40);
                    gr1.DrawLine(p, 0, 80, 100, 80);
                    gr1.DrawLine(p, 0, 120, 100, 120);
                    gr1.DrawLine(p, 0, 160, 100, 160);
                }
            }
            if (radioButton6.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 100, 65, 200, 65);
                    gr8.DrawLine(p, 100, 130, 200, 130);
                    gr8.DrawEllipse(w, 85, 15, 10, 10);
                    gr8.DrawLine(w, 130, 5, 170, 5);
                    gr8.DrawLine(w, 130, 70, 170, 70);
                    gr8.DrawLine(w, 130, 135, 170, 135);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 100, 65, 200, 65);
                    gr8.DrawLine(p, 100, 130, 200, 130);
                    gr8.FillRectangle(Brushes.LightGray, 10, 10, 80, 180);
                    gr8.DrawLine(w, 130, 5, 170, 5);
                    gr8.DrawLine(w, 130, 70, 170, 70);
                    gr8.DrawLine(w, 130, 135, 170, 135);
                    gr8.DrawEllipse(w, 85, 15, 10, 10);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 100, 65, 200, 65);
                    gr8.DrawLine(p, 100, 130, 200, 130);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 180);
                    gr8.DrawLine(w, 130, 5, 170, 5);
                    gr8.DrawLine(w, 130, 70, 170, 70);
                    gr8.DrawLine(w, 130, 135, 170, 135);
                    gr8.DrawEllipse(w, 85, 15, 10, 10);
                }
                if (radioButton16.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 100, 65, 200, 65);
                    gr8.DrawLine(p, 100, 130, 200, 130);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 180);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 50);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 70, 80, 55);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 135, 80, 55);
                    gr8.DrawLine(w, 130, 5, 170, 5);
                    gr8.DrawLine(w, 130, 70, 170, 70);
                    gr8.DrawLine(w, 130, 135, 170, 135);
                    gr8.DrawEllipse(w, 85, 15, 10, 10);
                }
                gr1.FillRectangle(Brushes.Bisque, 0, 0, 200, 300);
                gr1.FillRectangle(Brushes.Chocolate, 100, 0, 200, 300);
                gr1.DrawLine(l, 0, 0, 200, 0);
                gr1.DrawLine(l, 0, 0, 0, 200);
                gr1.DrawLine(l, 200, 0, 200, 200);
                gr1.DrawLine(l, 0, 200, 200, 200);
                gr1.DrawLine(p, 100, 0, 100, 220);
                gr1.DrawLine(p, 100, 65, 200, 65);
                gr1.DrawLine(p, 100, 130, 200, 130);
                gr1.DrawLine(w, 130, 5, 170, 5);
                gr1.DrawLine(w, 130, 70, 170, 70);
                gr1.DrawLine(w, 130, 135, 170, 135);
                if (radioButton7.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                }
                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 65, 100, 65);
                    gr1.DrawLine(p, 0, 130, 100, 130);
                }
                if (radioButton9.Checked == true)
                {
                    gr1.DrawLine(p, 0, 40, 100, 40);
                    gr1.DrawLine(p, 0, 80, 100, 80);
                    gr1.DrawLine(p, 0, 120, 100, 120);
                    gr1.DrawLine(p, 0, 160, 100, 160);
                }
            }

            pictureBox1.Image = bmp1;
            pictureBox8.Image = bmp8;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (comboBox1.Text == "") || (comboBox2.Text == ""))
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

            //для запоминания данных (для создания договора)
            Program.vibormeb = 3;
            Program.dlina = Convert.ToInt32(textBox1.Text);
            Program.shirina = Convert.ToInt32(textBox2.Text);
            Program.glybina = Convert.ToInt32(textBox3.Text);
            Program.material1 = comboBox1.Text;
            Program.material2 = comboBox2.Text;
            //Program.stoimost = 0;
            //Program.Datetime_vipol;

            string str = textBox4.Text;
            bmp1.Save(way + str + @"_vnyt.jpg");
            bmp8.Save(way + str + @"_vnesh.jpg");
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(way + str + @".pdf", FileMode.Create));
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont(@"D:\ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Image z1 = iTextSharp.text.Image.GetInstance(way + @"Заголовок_внут.jpg");
            z1.Alignment = Element.ALIGN_CENTER;
            iTextSharp.text.Image z2 = iTextSharp.text.Image.GetInstance(way + @"Заголовок_внеш.jpg");
            z2.Alignment = Element.ALIGN_CENTER;


            iTextSharp.text.Phrase j3 = new Phrase("Тип: Komod Длина: " + textBox1.Text + " Ширина: " + textBox2.Text + " Глубина: " + textBox3.Text + " Материал: " + comboBox1.Text + " Вставка: " + comboBox2.Text + " Дата выполнения: " + Program.Datetime_vipol + "  Стоимость: " + Program.stoimost,
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

            doc.Add(z1);
            doc.Add(k1);
            doc.Add(z2);
            doc.Add(k2);
            doc.Add(a3);
            doc.Close();

            MessageBox.Show("Сохранено в " + way);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (comboBox1.Text == "") || (comboBox2.Text == ""))
                {
                    MessageBox.Show("Часть полей не заполнено");
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

            //для запоминания данных (для создания договора)
            Program.vibormeb = 4;
            Program.dlina = Convert.ToInt32(textBox1.Text);
            Program.shirina = Convert.ToInt32(textBox2.Text);
            Program.glybina = Convert.ToInt32(textBox3.Text);
            Program.material1 = comboBox1.Text;
            Program.material2 = comboBox2.Text;
            //Program.stoimost = 0;
            //Program.Datetime_vipol;

            button4.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            StimostDatetime f2 = new StimostDatetime();
            f2.ShowDialog();
        }
    }
}
