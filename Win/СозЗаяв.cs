using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win
{
    public partial class СозЗаяв : Form
    {
        public СозЗаяв()
        {
            InitializeComponent();
        }

        public int num = 0;
        public int num_post = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //пройтись по комплектующим. если меньше порога (?), то вывести в listBox

             var k = Program.db3.Vivod(0);
             var p = Program.db4.Vivod(0);
            
             label2.Text = ("комплектующиеID" + " | " + "Название" + " | " + "Количество" + " | " + "Длина" + " | " + "Ширина" + " | " + "Глубина" + " | " + "Стоимость");
                
                foreach (Комплектующие kom in k)
                {
                    if(kom.Количество<20)
                    {
                        listBox1.Items.Add(kom);
                        num = kom.комплектующиеID;
                        foreach (Поставщик post in p)
                        {
                            if(post.комплектующиеID==num)
                            {
                                num_post = post.поставщикID;
                            }
                            
                        }
                    }
                    
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Metods med = new Metods();
            med.Zakypka();
        }
    }
}
