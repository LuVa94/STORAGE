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
    public partial class ШП : Form
    {
        public ШП()
        {
            InitializeComponent();
        }
        public string way = @"C:\users\user\documents\visual studio 2013\Projects\WinLinq\Эскизы\";
        public Bitmap bmp1 = new Bitmap(100, 300);
        public Bitmap bmp8 = new Bitmap(100, 300);
        public bool eskiz1 = false;
        public bool eskiz2 = false;
        public bool q1, q2, q3 = false;

        private void ШкафПенал_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet1.Материал". При необходимости она может быть перемещена или удалена.
            this.материалTableAdapter.Fill(this.asdDataSet1.Материал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet.Мебель". При необходимости она может быть перемещена или удалена.
            this.мебельTableAdapter.Fill(this.asdDataSet.Мебель);
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
            Pen w = new Pen(Brushes.SaddleBrown, 5);

            gr2.FillRectangle(Brushes.Chocolate, 0, 0, 60, 130);
            gr3.FillRectangle(Brushes.Chocolate, 0, 0, 60, 130);
            gr4.FillRectangle(Brushes.Chocolate, 0, 0, 60, 130);
            gr5.FillRectangle(Brushes.Chocolate, 0, 0, 60, 130);
            gr6.FillRectangle(Brushes.Chocolate, 0, 0, 60, 130);
            gr7.FillRectangle(Brushes.Chocolate, 0, 0, 60, 130);

            gr2.DrawLine(l, 0, 0, 60, 0);
            gr2.DrawLine(l, 0, 0, 0, 130);
            gr2.DrawLine(l, 60, 0, 60, 130);
            gr2.DrawLine(l, 0, 130, 60, 130);
            gr3.DrawLine(l, 0, 0, 60, 0);
            gr3.DrawLine(l, 0, 0, 0, 130);
            gr3.DrawLine(l, 60, 0, 60, 130);
            gr3.DrawLine(l, 0, 130, 60, 130);
            gr4.DrawLine(l, 0, 0, 60, 0);
            gr4.DrawLine(l, 0, 0, 0, 130);
            gr4.DrawLine(l, 60, 0, 60, 130);
            gr4.DrawLine(l, 0, 130, 60, 130);
            gr5.DrawLine(l, 0, 0, 60, 0);
            gr5.DrawLine(l, 0, 0, 0, 130);
            gr5.DrawLine(l, 60, 0, 60, 130);
            gr5.DrawLine(l, 0, 130, 60, 130);
            gr6.DrawLine(l, 0, 0, 60, 0);
            gr6.DrawLine(l, 0, 0, 0, 130);
            gr6.DrawLine(l, 60, 0, 60, 130);
            gr6.DrawLine(l, 0, 130, 60, 130);
            gr7.DrawLine(l, 0, 0, 60, 0);
            gr7.DrawLine(l, 0, 0, 0, 130);
            gr7.DrawLine(l, 60, 0, 60, 130);
            gr7.DrawLine(l, 0, 130, 60, 130);

            gr2.DrawEllipse(w, 10, 60, 5, 5);
            pictureBox2.Image = bmp2;

            gr3.DrawLine(p, 0, 50, 60, 50);
            gr3.DrawLine(p, 0, 90, 60, 90);
            gr3.DrawEllipse(w, 10, 35, 5, 5);
            gr3.DrawEllipse(w, 10, 100, 5, 5);
            gr3.FillRectangle(Brushes.LightGoldenrodYellow, 3, 52, 55, 37);

            pictureBox3.Image = bmp3;

            gr4.DrawLine(p, 0, 90, 60, 90);
            gr4.DrawEllipse(w, 10, 40, 5, 5);
            gr4.DrawEllipse(w, 10, 100, 5, 5);
            pictureBox4.Image = bmp4;

            gr5.DrawLine(p, 0, 45, 60, 45);
            gr5.DrawEllipse(w, 10, 90, 5, 5);
            gr5.DrawEllipse(w, 10, 30, 5, 5);
            pictureBox5.Image = bmp5;

            gr6.DrawLine(p, 0, 90, 60, 90);
            gr6.DrawLine(p, 0, 110, 60, 110);
            gr6.DrawEllipse(w, 10, 40, 5, 5);
            gr6.DrawLine(w, 20, 95, 40, 95);
            gr6.DrawLine(w, 20, 115, 40, 115);
            pictureBox6.Image = bmp6;

            gr7.DrawLine(p, 0, 50, 60, 50);
            gr7.DrawLine(p, 0, 70, 60, 70);
            gr7.DrawLine(p, 0, 90, 60, 90);
            gr7.DrawLine(w, 20, 75, 40, 75);
            gr7.DrawLine(w, 20, 55, 40, 55);
            gr7.DrawEllipse(w, 10, 40, 5, 5);
            gr7.DrawEllipse(w, 10, 95, 5, 5);
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
            Graphics gr1 = Graphics.FromImage(bmp1);
            Pen p = new Pen(Brushes.Black, 3);
            Pen l = new Pen(Brushes.Black, 5);
            Pen q = new Pen(Brushes.Silver, 3);
            gr1.FillRectangle(Brushes.Bisque, 0, 0, 140, 380);
            gr1.DrawLine(l, 0, 0, 100, 0);
            gr1.DrawLine(l, 0, 0, 0, 300);
            gr1.DrawLine(l, 100, 0, 100, 300);
            gr1.DrawLine(l, 0, 300, 100, 300);
            if (radioButton7.Checked == true)
            {
                gr1.DrawLine(p, 0, 100, 100, 100);
                gr1.DrawLine(p, 0, 200, 100, 200);
            }
            if (radioButton8.Checked == true)
            {
                gr1.DrawLine(p, 0, 75, 100, 75);
                gr1.DrawLine(p, 0, 150, 100, 150);
                gr1.DrawLine(p, 0, 225, 100, 225);
            }
            if (radioButton9.Checked == true)
            {
                gr1.DrawLine(p, 0, 60, 100, 60);
                gr1.DrawLine(p, 0, 120, 100, 120);
                gr1.DrawLine(p, 0, 180, 100, 180);
                gr1.DrawLine(p, 0, 240, 100, 240);
            }
            if (radioButton10.Checked == true)
            {
                gr1.DrawLine(p, 0, 50, 100, 50);
                gr1.DrawLine(p, 0, 100, 100, 100);
                gr1.DrawLine(p, 0, 150, 100, 150);
                gr1.DrawLine(p, 0, 200, 100, 200);
                gr1.DrawLine(p, 0, 250, 100, 250);
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
            Pen w = new Pen(Brushes.SaddleBrown, 5);
            gr8.FillRectangle(Brushes.Chocolate, 0, 0, 140, 380);
            gr8.DrawLine(l, 0, 0, 100, 0);
            gr8.DrawLine(l, 0, 0, 0, 300);
            gr8.DrawLine(l, 100, 0, 100, 300);
            gr8.DrawLine(l, 0, 300, 100, 300);
            if (radioButton1.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawEllipse(w, 20, 140, 10, 10);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.FillRectangle(Brushes.LightGray, 15, 10, 70, 280);
                    gr8.DrawEllipse(w, 10, 140, 8, 8);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.FillRectangle(Brushes.NavajoWhite, 15, 10, 70, 280);
                    gr8.DrawEllipse(w, 10, 140, 8, 8);
                }
               
            }
            if (radioButton2.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.DrawEllipse(w, 10, 80, 10, 10);
                    gr8.DrawEllipse(w, 10, 210, 10, 10);
                    gr8.FillRectangle(Brushes.LightGoldenrodYellow, 4, 103, 93, 95);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.FillRectangle(Brushes.LightGoldenrodYellow, 4, 103, 93, 95);
                    gr8.FillRectangle(Brushes.LightGray, 10, 10, 80, 80);
                    gr8.DrawEllipse(w, 8, 84, 10, 10);
                    gr8.DrawEllipse(w, 10, 210, 10, 10);
                   
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.FillRectangle(Brushes.LightGoldenrodYellow, 4, 103, 93, 95);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 80);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 210, 80, 80);
                    gr8.DrawEllipse(w, 8, 84, 10, 10);
                    gr8.DrawEllipse(w, 10, 210, 10, 10);
                }
               
                if (radioButton15.Checked == true)
                {
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.FillRectangle(Brushes.LightGoldenrodYellow, 4, 103, 93, 95);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 80);
                    gr8.DrawEllipse(w, 8, 84, 10, 10);
                    gr8.DrawEllipse(w, 10, 210, 10, 10);
                }

                gr1.FillRectangle(Brushes.Bisque, 0, 0, 140, 380);
                gr1.DrawLine(l, 0, 0, 100, 0);
                gr1.DrawLine(l, 0, 0, 0, 300);
                gr1.DrawLine(l, 100, 0, 100, 300);
                gr1.DrawLine(l, 0, 300, 100, 300);
                gr1.FillRectangle(Brushes.LightGoldenrodYellow, 4, 103, 93, 95);
                if (radioButton7.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 200, 100, 200);
                }
                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 150, 100, 150);
                    gr1.DrawLine(p, 0, 200, 100, 200);
                }
                if (radioButton9.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 50, 100, 50);
                    gr1.DrawLine(p, 0, 150, 100, 150);
                    gr1.DrawLine(p, 0, 200, 100, 200);
                }
                if (radioButton10.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 50, 100, 50);
                    gr1.DrawLine(p, 0, 150, 100, 150);
                    gr1.DrawLine(p, 0, 200, 100, 200);
                    gr1.DrawLine(p, 0, 250, 100, 250);
                }

               
            }

            if (radioButton3.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.DrawEllipse(w, 10, 80, 10, 10);
                    gr8.DrawEllipse(w, 10, 210, 10, 10);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.FillRectangle(Brushes.LightGray, 15, 10, 70, 180);
                    gr8.DrawEllipse(w, 8, 80, 10, 10);
                    gr8.DrawEllipse(w, 10, 210, 10, 10);
                    
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 15, 10, 70, 180);
                    gr8.FillRectangle(Brushes.NavajoWhite, 15, 210, 70, 80);
                    gr8.DrawEllipse(w, 8, 80, 10, 10);
                    gr8.DrawEllipse(w, 8, 207, 10, 10);
                }
               
                if (radioButton15.Checked == true)
                {
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 15, 10, 70, 180);
                    gr8.DrawEllipse(w, 8, 80, 10, 10);
                    gr8.DrawEllipse(w, 10, 210, 10, 10);
                }
                gr1.FillRectangle(Brushes.Bisque, 0, 0, 140, 380);
                gr1.DrawLine(l, 0, 0, 100, 0);
                gr1.DrawLine(l, 0, 0, 0, 300);
                gr1.DrawLine(l, 100, 0, 100, 300);
                gr1.DrawLine(l, 0, 300, 100, 300);
                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 65, 100, 65);
                    gr1.DrawLine(p, 0, 130, 100, 130);
                    gr1.DrawLine(p, 0, 200, 100, 200);
                }
                if (radioButton9.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 50, 100, 50);
                    gr1.DrawLine(p, 0, 150, 100, 150);
                    gr1.DrawLine(p, 0, 200, 100, 200);
                }
            }
            if (radioButton4.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.DrawEllipse(w, 10, 80, 10, 10);
                    gr8.DrawEllipse(w, 10, 200, 10, 10);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.FillRectangle(Brushes.LightGray, 15, 110, 70, 180);
                    gr8.DrawEllipse(w, 8, 80, 10, 10);
                    gr8.DrawEllipse(w, 8, 200, 10, 10);

                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.FillRectangle(Brushes.NavajoWhite, 15, 10, 70, 80);
                    gr8.FillRectangle(Brushes.NavajoWhite, 15, 110, 70, 180);
                    gr8.DrawEllipse(w, 8, 80, 10, 10);
                    gr8.DrawEllipse(w, 8, 200, 10, 10);
                }

                if (radioButton15.Checked == true)
                {
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.FillRectangle(Brushes.NavajoWhite, 15, 110, 70, 180);
                    gr8.DrawEllipse(w, 8, 80, 10, 10);
                    gr8.DrawEllipse(w, 8, 200, 10, 10);
                }
                gr1.FillRectangle(Brushes.Bisque, 0, 0, 140, 380);
                gr1.DrawLine(l, 0, 0, 100, 0);
                gr1.DrawLine(l, 0, 0, 0, 300);
                gr1.DrawLine(l, 100, 0, 100, 300);
                gr1.DrawLine(l, 0, 300, 100, 300);
                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 165, 100, 165);
                    gr1.DrawLine(p, 0, 230, 100, 230);
                }
                if (radioButton9.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 250, 100, 250);
                    gr1.DrawLine(p, 0, 150, 100, 150);
                    gr1.DrawLine(p, 0, 200, 100, 200);
                }
            }
            if (radioButton5.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.DrawLine(p, 0, 250, 100, 250);
                    gr8.DrawEllipse(w, 10, 80, 10, 10);
                    gr8.DrawLine(w, 35, 260, 65, 260);
                    gr8.DrawLine(w, 35, 210, 65, 210);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.DrawLine(p, 0, 250, 100, 250);
                    gr8.FillRectangle(Brushes.LightGray, 15, 10, 70, 180);
                    gr8.DrawEllipse(w, 8, 80, 10, 10);
                    gr8.DrawLine(w, 35, 260, 65, 260);
                    gr8.DrawLine(w, 35, 210, 65, 210);

                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.DrawLine(p, 0, 250, 100, 250);
                    gr8.FillRectangle(Brushes.NavajoWhite, 15, 10, 70, 180);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 210, 80, 30);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 260, 80, 30);
                    gr8.DrawEllipse(w, 8, 80, 10, 10);
                    gr8.DrawLine(w, 35, 260, 65, 260);
                    gr8.DrawLine(w, 35, 210, 65, 210);
                }

                if (radioButton15.Checked == true)
                {
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.DrawLine(p, 0, 250, 100, 250);
                    gr8.FillRectangle(Brushes.NavajoWhite, 15, 10, 70, 180);
                    gr8.DrawEllipse(w, 8, 80, 10, 10);
                    gr8.DrawLine(w, 35, 260, 65, 260);
                    gr8.DrawLine(w, 35, 210, 65, 210);
                }

                gr1.FillRectangle(Brushes.Bisque, 0, 0, 140, 380);
                gr1.DrawLine(l, 0, 0, 100, 0);
                gr1.DrawLine(l, 0, 0, 0, 300);
                gr1.DrawLine(l, 100, 0, 100, 300);
                gr1.DrawLine(l, 0, 300, 100, 300);
                gr1.FillRectangle(Brushes.Chocolate, 4, 203, 93, 195);
                gr1.DrawLine(p, 0, 200, 100, 200);
                gr1.DrawLine(p, 0, 250, 100, 250);
                gr1.DrawLine(w, 35, 260, 65, 260);
                gr1.DrawLine(w, 35, 210, 65, 210);
                if (radioButton7.Checked == true)
                {
                    gr1.DrawLine(p, 0, 65, 100, 65);
                    gr1.DrawLine(p, 0, 130, 100, 130);
                }
                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 50, 100, 50);
                    gr1.DrawLine(p, 0, 150, 100, 150);
                }
                if (radioButton9.Checked == true)
                {
                    gr1.DrawLine(p, 0, 40, 100, 40);
                    gr1.DrawLine(p, 0, 80, 100, 80);
                    gr1.DrawLine(p, 0, 120, 100, 120);
                    gr1.DrawLine(p, 0, 160, 100, 160);
                }
                if (radioButton10.Checked == true)
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
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.DrawLine(p, 0, 150, 100, 150);
                    gr8.DrawLine(w, 35, 160, 65, 160);
                    gr8.DrawLine(w, 35, 110, 65, 110);
                    gr8.DrawEllipse(w, 10, 80, 10, 10);
                    gr8.DrawEllipse(w, 10, 210, 10, 10);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.DrawLine(p, 0, 150, 100, 150);
                    gr8.DrawLine(w, 35, 160, 65, 160);
                    gr8.DrawLine(w, 35, 110, 65, 110);
                    gr8.FillRectangle(Brushes.LightGray, 10, 10, 80, 80);
                    gr8.DrawEllipse(w, 8, 84, 10, 10);
                    gr8.DrawEllipse(w, 10, 210, 10, 10);

                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.DrawLine(p, 0, 150, 100, 150);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 110, 80, 30);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 160, 80, 30);
                    gr8.DrawLine(w, 35, 160, 65, 160);
                    gr8.DrawLine(w, 35, 110, 65, 110);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 80);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 210, 80, 80);
                    gr8.DrawEllipse(w, 8, 84, 10, 10);
                    gr8.DrawEllipse(w, 10, 210, 10, 10);
                }

                if (radioButton15.Checked == true)
                {
                    gr8.DrawLine(p, 0, 100, 100, 100);
                    gr8.DrawLine(p, 0, 200, 100, 200);
                    gr8.DrawLine(p, 0, 150, 100, 150);
                    gr8.DrawLine(w, 35, 160, 65, 160);
                    gr8.DrawLine(w, 35, 110, 65, 110);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 80);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 210, 80, 80);
                    gr8.DrawEllipse(w, 8, 84, 10, 10);
                    gr8.DrawEllipse(w, 10, 210, 10, 10);
                }
                gr1.FillRectangle(Brushes.Bisque, 0, 0, 140, 380);
                gr1.DrawLine(l, 0, 0, 100, 0);
                gr1.DrawLine(l, 0, 0, 0, 300);
                gr1.DrawLine(l, 100, 0, 100, 300);
                gr1.DrawLine(l, 0, 300, 100, 300);
                gr1.FillRectangle(Brushes.Chocolate, 4, 103, 93, 95);
                gr1.DrawLine(p, 0, 150, 100, 150);
                gr1.DrawLine(w, 35, 160, 65, 160);
                gr1.DrawLine(w, 35, 110, 65, 110);
                if (radioButton7.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 200, 100, 200);
                }
                if (radioButton8.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 200, 100, 200);
                    gr1.DrawLine(p, 0, 50, 100, 50);
                }
                if (radioButton9.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 200, 100, 200);
                    gr1.DrawLine(p, 0, 50, 100, 50);
                    gr1.DrawLine(p, 0, 250, 100, 250);
                }
                if (radioButton10.Checked == true)
                {
                    gr1.DrawLine(p, 0, 100, 100, 100);
                    gr1.DrawLine(p, 0, 200, 100, 200);
                    gr1.DrawLine(p, 0, 50, 100, 50);
                    gr1.DrawLine(p, 0, 250, 100, 250);
                }
            }

            pictureBox9.Image = bmp8; 
            pictureBox1.Image = bmp1;

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
            Program.vibormeb = 4;
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

            iTextSharp.text.Phrase j3 = new Phrase("Тип: Shkaf penal Длина: " + textBox1.Text + " Ширина: " + textBox2.Text + " Глубина: " + textBox3.Text + " Материал: " + comboBox1.Text + " Вставка: " + comboBox2.Text + " Дата выполнения: " + Program.Datetime_vipol + "  Стоимость: " + Program.stoimost,
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

