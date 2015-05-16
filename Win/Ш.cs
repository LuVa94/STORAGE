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
    public partial class Ш : Form
    {
        public Ш()
        {
            InitializeComponent();
        }
        public string way = @"C:\users\user\documents\visual studio 2013\Projects\WinLinq\Эскизы\";
        public Bitmap bmp1 = new Bitmap(200, 300);
        public Bitmap bmp8 = new Bitmap(200, 300);
        public bool eskiz1 = false;
        public bool eskiz2 = false;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet4.Материал". При необходимости она может быть перемещена или удалена.
            this.материалTableAdapter1.Fill(this.asdDataSet4.Материал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet3.Материал". При необходимости она может быть перемещена или удалена.
            this.материалTableAdapter.Fill(this.asdDataSet3.Материал);
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
            gr4.FillRectangle(Brushes.Chocolate, 0, 0, 90, 120);
            gr5.FillRectangle(Brushes.Chocolate, 0, 0, 90, 120);
            gr6.FillRectangle(Brushes.Chocolate, 0, 0, 90, 120);
            gr7.FillRectangle(Brushes.Chocolate, 0, 0, 90, 120);

            gr2.DrawLine(l, 0, 0, 90, 0);
            gr2.DrawLine(l, 0, 0, 0, 120);
            gr2.DrawLine(l, 90, 0, 90, 120);
            gr2.DrawLine(l, 0, 120, 90, 120);
            gr3.DrawLine(l, 0, 0, 90, 0);
            gr3.DrawLine(l, 0, 0, 0, 120);
            gr3.DrawLine(l, 90, 0, 90, 120);
            gr3.DrawLine(l, 0, 120, 90, 120);
            gr4.DrawLine(l, 0, 0, 90, 0);
            gr4.DrawLine(l, 0, 0, 0, 120);
            gr4.DrawLine(l, 90, 0, 90, 120);
            gr4.DrawLine(l, 0, 120, 90, 120);
            gr5.DrawLine(l, 0, 0, 90, 0);
            gr5.DrawLine(l, 0, 0, 0, 120);
            gr5.DrawLine(l, 90, 0, 90, 120);
            gr5.DrawLine(l, 0, 120, 90, 120);
            gr6.DrawLine(l, 0, 0, 90, 0);
            gr6.DrawLine(l, 0, 0, 0, 120);
            gr6.DrawLine(l, 90, 0, 90, 120);
            gr6.DrawLine(l, 0, 120, 90, 120);
            gr7.DrawLine(l, 0, 0, 90, 0);
            gr7.DrawLine(l, 0, 0, 0, 120);
            gr7.DrawLine(l, 90, 0, 90, 120);
            gr7.DrawLine(l, 0, 120, 90, 120);

            gr2.DrawLine(p, 45, 0, 45, 120);
            gr2.DrawEllipse(w, 35, 55, 5, 5);
            gr2.DrawEllipse(w, 50, 55, 5, 5);
            pictureBox2.Image = bmp2;

            gr3.DrawLine(p, 45, 0, 45, 120);
            gr3.DrawLine(p, 0, 90, 90, 90);
            gr3.DrawEllipse(w, 35, 45, 5, 5);
            gr3.DrawEllipse(w, 50, 45, 5, 5);
            gr3.DrawEllipse(w, 35, 95, 4, 4);
            gr3.DrawEllipse(w, 50, 95, 4, 4);
            pictureBox3.Image = bmp3;

            gr4.DrawLine(p, 45, 0, 45, 120);
            gr4.DrawLine(p, 0, 30, 90, 30);
            gr4.DrawEllipse(w, 35, 65, 5, 5);
            gr4.DrawEllipse(w, 50, 65, 5, 5);
            gr4.DrawEllipse(w, 35, 20, 4, 4);
            gr4.DrawEllipse(w, 50, 20, 4, 4);
            pictureBox4.Image = bmp4;

            gr5.DrawLine(p, 45, 0, 45, 120);
            gr5.DrawLine(p, 0, 90, 90, 90);
            gr5.DrawEllipse(w, 35, 45, 5, 5);
            gr5.DrawEllipse(w, 50, 45, 5, 5);
            gr5.DrawLine(w, 15, 95, 35, 95);
            gr5.DrawLine(w, 60, 95, 80, 95);
            pictureBox5.Image = bmp5;

            gr6.DrawLine(p, 45, 0, 45, 90);
            gr6.DrawLine(p, 0, 90, 90, 90);
            gr6.DrawEllipse(w, 50, 45, 5, 5);
            gr6.DrawEllipse(w, 35, 45, 5, 5);
            gr6.DrawLine(w, 30, 95, 60, 95);
            pictureBox6.Image = bmp6;

            gr7.DrawLine(p, 45, 0, 45, 90);
            gr7.DrawLine(p, 0, 90, 90, 90);
            gr7.DrawLine(p, 0, 105, 90, 105);
            gr7.DrawEllipse(w, 35, 45, 5, 5);
            gr7.DrawEllipse(w, 50, 45, 5, 5);
            gr7.DrawLine(w, 30, 95, 60, 95);
            gr7.DrawLine(w, 30, 110, 60, 110);
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
            gr1.DrawLine(l, 0, 0, 0, 300);
            gr1.DrawLine(l, 200, 0, 200, 300);
            gr1.DrawLine(l, 0, 300, 200, 300);
            if (radioButton7.Checked == true)
            {
                gr1.DrawLine(p, 0, 100, 200, 100);
                gr1.DrawLine(p, 0, 200, 200, 200);

            }
            if (radioButton8.Checked == true)
            {
                gr1.DrawLine(p, 0, 75, 200, 75);
                gr1.DrawLine(p, 0, 150, 200, 150);
                gr1.DrawLine(p, 0, 225, 200, 225);
            }
            if (radioButton9.Checked == true)
            {
                gr1.DrawLine(p, 0, 60, 200, 60);
                gr1.DrawLine(p, 0, 120, 200, 120);
                gr1.DrawLine(p, 0, 180, 200, 180);
                gr1.DrawLine(p, 0, 240, 200, 240);
            }
            if (radioButton10.Checked == true)
            {
                gr1.DrawLine(p, 0, 45, 200, 45);
                gr1.DrawLine(p, 0, 90, 200, 90);
                gr1.DrawLine(p, 0, 135, 200, 135);
                gr1.DrawLine(p, 0, 180, 200, 180);
                gr1.DrawLine(p, 0, 225, 200, 225);
                gr1.DrawLine(p, 0, 270, 200, 270);
            }
            if (radioButton21.Checked == true)
            {
                gr1.DrawLine(p, 100, 0, 100, 300);
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
            Pen p = new Pen(Brushes.Black, 3);
            Pen l = new Pen(Brushes.Black, 5);
            Pen w = new Pen(Brushes.DimGray, 5);
            gr8.FillRectangle(Brushes.Chocolate, 0, 0, 200, 300);
            gr8.DrawLine(l, 0, 0, 200, 0);
            gr8.DrawLine(l, 0, 0, 0, 300);
            gr8.DrawLine(l, 200, 0, 200, 300);
            gr8.DrawLine(l, 0, 300, 200, 300);
            if (radioButton1.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawEllipse(w, 85, 155, 10, 10);
                    gr8.DrawEllipse(w, 105, 155, 10, 10);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.FillRectangle(Brushes.LightGray, 10, 10, 80, 280);
                    gr8.FillRectangle(Brushes.LightGray, 110, 10, 80, 280);
                    gr8.DrawEllipse(w, 85, 155, 10, 10);
                    gr8.DrawEllipse(w, 105, 155, 10, 10);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 280);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 280);
                    gr8.DrawEllipse(w, 85, 155, 10, 10);
                    gr8.DrawEllipse(w, 105, 155, 10, 10);
                }
                //if (radioButton14.Checked == true)
                //{
                //    gr8.FillRectangle(Brushes.Yellow, 0, 0, 200, 300);
                //    gr8.DrawLine(p, 100, 0, 100, 300);
                //    gr8.DrawEllipse(w, 85, 155, 10, 10);
                //    gr8.DrawEllipse(w, 105, 155, 10, 10);
                //}
            }

            if (radioButton2.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawEllipse(w, 85, 230, 8, 8);
                    gr8.DrawEllipse(w, 105, 230, 8, 8);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.FillRectangle(Brushes.LightGray, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.LightGray, 110, 10, 80, 200);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawEllipse(w, 85, 230, 8, 8);
                    gr8.DrawEllipse(w, 105, 230, 8, 8);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 200);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawEllipse(w, 85, 230, 8, 8);
                    gr8.DrawEllipse(w, 105, 230, 8, 8);
                }
                //if (radioButton14.Checked == true)
                //{
                //    gr8.DrawLine(p, 100, 0, 100, 300);
                //    gr8.DrawLine(p, 0, 220, 200, 220);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 10, 80, 200);
                //    gr8.DrawEllipse(w, 85, 120, 10, 10);
                //    gr8.DrawEllipse(w, 105, 120, 10, 10);
                //    gr8.DrawEllipse(w, 85, 230, 8, 8);
                //    gr8.DrawEllipse(w, 105, 230, 8, 8);
                //}
                if (radioButton16.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 230, 80, 60);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 230, 80, 60);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawEllipse(w, 85, 230, 8, 8);
                    gr8.DrawEllipse(w, 105, 230, 8, 8);
                }
                //if (radioButton15.Checked == true)
                //{
                //    gr8.DrawLine(p, 100, 0, 100, 300);
                //    gr8.DrawLine(p, 0, 220, 200, 220);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 230, 80, 60);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 230, 80, 60);
                //    gr8.DrawEllipse(w, 85, 120, 10, 10);
                //    gr8.DrawEllipse(w, 105, 120, 10, 10);
                //    gr8.DrawEllipse(w, 85, 230, 8, 8);
                //    gr8.DrawEllipse(w, 105, 230, 8, 8);
                //}
            }
            if (radioButton3.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 80, 200, 80);
                    gr8.DrawEllipse(w, 85, 160, 10, 10);
                    gr8.DrawEllipse(w, 105, 160, 10, 10);
                    gr8.DrawEllipse(w, 85, 65, 8, 8);
                    gr8.DrawEllipse(w, 105, 65, 8, 8);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 80, 200, 80);
                    gr8.FillRectangle(Brushes.LightGray, 10, 90, 80, 200);
                    gr8.FillRectangle(Brushes.LightGray, 110, 90, 80, 200);
                    gr8.DrawEllipse(w, 85, 160, 10, 10);
                    gr8.DrawEllipse(w, 105, 160, 10, 10);
                    gr8.DrawEllipse(w, 85, 65, 8, 8);
                    gr8.DrawEllipse(w, 105, 65, 8, 8);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 80, 200, 80);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 90, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 90, 80, 200);
                    gr8.DrawEllipse(w, 85, 160, 10, 10);
                    gr8.DrawEllipse(w, 105, 160, 10, 10);
                    gr8.DrawEllipse(w, 85, 65, 8, 8);
                    gr8.DrawEllipse(w, 105, 65, 8, 8);
                }
                //if (radioButton14.Checked == true)
                //{
                //    gr8.DrawLine(p, 100, 0, 100, 300);
                //    gr8.DrawLine(p, 0, 80, 200, 80);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 90, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 90, 80, 200);
                //    gr8.DrawEllipse(w, 85, 160, 10, 10);
                //    gr8.DrawEllipse(w, 105, 160, 10, 10);
                //    gr8.DrawEllipse(w, 85, 65, 8, 8);
                //    gr8.DrawEllipse(w, 105, 65, 8, 8);
                //}
                if (radioButton16.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 80, 200, 80);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 90, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 90, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 60);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 60);
                    gr8.DrawEllipse(w, 85, 160, 10, 10);
                    gr8.DrawEllipse(w, 105, 160, 10, 10);
                    gr8.DrawEllipse(w, 85, 65, 8, 8);
                    gr8.DrawEllipse(w, 105, 65, 8, 8);
                }
                //if (radioButton15.Checked == true)
                //{
                //    gr8.DrawLine(p, 100, 0, 100, 300);
                //    gr8.DrawLine(p, 0, 80, 200, 80);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 90, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 90, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 10, 80, 60);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 10, 80, 60);
                //    gr8.DrawEllipse(w, 85, 160, 10, 10);
                //    gr8.DrawEllipse(w, 105, 160, 10, 10);
                //    gr8.DrawEllipse(w, 85, 65, 8, 8);
                //    gr8.DrawEllipse(w, 105, 65, 8, 8);
                //}
            }
            if (radioButton4.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 30, 230, 70, 230);
                    gr8.DrawLine(w, 130, 230, 170, 230);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.FillRectangle(Brushes.LightGray, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.LightGray, 110, 10, 80, 200);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 30, 230, 70, 230);
                    gr8.DrawLine(w, 130, 230, 170, 230);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 200);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 30, 230, 70, 230);
                    gr8.DrawLine(w, 130, 230, 170, 230);
                }
                //if (radioButton14.Checked == true)
                //{
                //    gr8.DrawLine(p, 100, 0, 100, 300);
                //    gr8.DrawLine(p, 0, 220, 200, 220);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 10, 80, 200);
                //    gr8.DrawEllipse(w, 85, 120, 10, 10);
                //    gr8.DrawEllipse(w, 105, 120, 10, 10);
                //    gr8.DrawLine(w, 30, 230, 70, 230);
                //    gr8.DrawLine(w, 130, 230, 170, 230);
                //}
                if (radioButton16.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 300);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 230, 80, 60);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 230, 80, 60);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 30, 230, 70, 230);
                    gr8.DrawLine(w, 130, 230, 170, 230);
                }
                //if (radioButton15.Checked == true)
                //{
                //    gr8.DrawLine(p, 100, 0, 100, 300);
                //    gr8.DrawLine(p, 0, 220, 200, 220);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 230, 80, 60);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 230, 80, 60);
                //    gr8.DrawEllipse(w, 85, 120, 10, 10);
                //    gr8.DrawEllipse(w, 105, 120, 10, 10);
                //    gr8.DrawLine(w, 30, 230, 70, 230);
                //    gr8.DrawLine(w, 130, 230, 170, 230);
                //}
            }
            if (radioButton5.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 80, 230, 120, 230);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.FillRectangle(Brushes.LightGray, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.LightGray, 110, 10, 80, 200);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 80, 230, 120, 230);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 200);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 80, 230, 120, 230);
                }
                //if (radioButton14.Checked == true)
                //{
                //    gr8.DrawLine(p, 100, 0, 100, 220);
                //    gr8.DrawLine(p, 0, 220, 200, 220);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 10, 80, 200);
                //    gr8.DrawEllipse(w, 85, 120, 10, 10);
                //    gr8.DrawEllipse(w, 105, 120, 10, 10);
                //    gr8.DrawLine(w, 80, 230, 120, 230);
                //}
                if (radioButton16.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 230, 180, 60);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 80, 230, 120, 230);
                }
                //if (radioButton15.Checked == true)
                //{
                //    gr8.DrawLine(p, 100, 0, 100, 220);
                //    gr8.DrawLine(p, 0, 220, 200, 220);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 230, 180, 60);
                //    gr8.DrawEllipse(w, 85, 120, 10, 10);
                //    gr8.DrawEllipse(w, 105, 120, 10, 10);
                //    gr8.DrawLine(w, 80, 230, 120, 230);
                //}
            }
            if (radioButton6.Checked == true)
            {
                if (radioButton11.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.DrawLine(p, 0, 260, 200, 260);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 80, 230, 120, 230);
                    gr8.DrawLine(w, 80, 270, 120, 270);
                    comboBox2.Text = "нет";
                }
                if (radioButton12.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.DrawLine(p, 0, 260, 200, 260);
                    gr8.FillRectangle(Brushes.LightGray, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.LightGray, 110, 10, 80, 200);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 80, 230, 120, 230);
                    gr8.DrawLine(w, 80, 270, 120, 270);
                }
                if (radioButton13.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.DrawLine(p, 0, 260, 200, 260);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 200);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 80, 230, 120, 230);
                    gr8.DrawLine(w, 80, 270, 120, 270);
                }
                //if (radioButton14.Checked == true)
                //{
                //    gr8.DrawLine(p, 100, 0, 100, 220);
                //    gr8.DrawLine(p, 0, 220, 200, 220);
                //    gr8.DrawLine(p, 0, 260, 200, 260);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 10, 80, 200);
                //    gr8.DrawEllipse(w, 85, 120, 10, 10);
                //    gr8.DrawEllipse(w, 105, 120, 10, 10);
                //    gr8.DrawLine(w, 80, 230, 120, 230);
                //    gr8.DrawLine(w, 80, 270, 120, 270);
                //}
                if (radioButton16.Checked == true)
                {
                    gr8.DrawLine(p, 100, 0, 100, 220);
                    gr8.DrawLine(p, 0, 220, 200, 220);
                    gr8.DrawLine(p, 0, 260, 200, 260);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 110, 10, 80, 200);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 230, 180, 20);
                    gr8.FillRectangle(Brushes.NavajoWhite, 10, 270, 180, 20);
                    gr8.DrawEllipse(w, 85, 120, 10, 10);
                    gr8.DrawEllipse(w, 105, 120, 10, 10);
                    gr8.DrawLine(w, 80, 230, 120, 230);
                    gr8.DrawLine(w, 80, 270, 120, 270);
                }
                //if (radioButton15.Checked == true)
                //{
                //    gr8.DrawLine(p, 100, 0, 100, 220);
                //    gr8.DrawLine(p, 0, 220, 200, 220);
                //    gr8.DrawLine(p, 0, 260, 200, 260);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 110, 10, 80, 200);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 230, 180, 20);
                //    gr8.FillRectangle(Brushes.Yellow, 10, 270, 180, 20);
                //    gr8.DrawEllipse(w, 85, 120, 10, 10);
                //    gr8.DrawEllipse(w, 105, 120, 10, 10);
                //    gr8.DrawLine(w, 80, 230, 120, 230);
                //    gr8.DrawLine(w, 80, 270, 120, 270);
                //}
            }
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

            string str = textBox4.Text;
            bmp1.Save(way + str + @"_vnyt.jpg");
            bmp8.Save(way + str + @"_vnesh.jpg");
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(way + str + @".pdf", FileMode.Create));
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont(@"D:\ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
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

            iTextSharp.text.Phrase j3 = new Phrase("Длина: " + textBox1.Text + "   Ширина: " + textBox2.Text + "    Глубина: " + textBox3.Text + "    Материал: " + comboBox1.Text + "     Вставка: " + comboBox2.Text,
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

            MessageBox.Show("Сохранено в " + way);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
