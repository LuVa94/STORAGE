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
    public partial class Graphics_income : Form
    {
        public Graphics_income()
        {
            InitializeComponent();
        }
        public string way = @"C:\Users\Татьяна\Desktop\STORAGE-master\График\";

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            float cdx = (w - 90) / maxX;
            float cdy = (h - 50) / maxY;

            int max = h - 25;

            Pen p = new Pen(Brushes.Green, 3);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            gr.DrawLine(p, (int)(0 * cdx)+25, (int)h-25, (int)(0 * cdx)+25, 0);

            gr.DrawLine(p,0, (int)(max-0 * cdy),(int)w-25 , (int)(max - 0 * cdy));
        }
    }
}
