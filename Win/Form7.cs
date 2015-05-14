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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

       // Program.db_zakaz Program.db7 = new Program.db_zakaz(@"Data Source=(LocalProgram.db)\v11.0;AttachProgram.dbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
       
        private void button2_Click(object sender, EventArgs e)
        {
            bool w1=true;
            int n = 0;
            try
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Строка не заполнена! Введите, пожалуйста, номер заказа");
            }
            catch { }
            var q = Program.db7.Vivod(0);
           
            foreach (Заказ z in q)
            {
                 w1 = Convert.ToInt32(textBox1.Text).Equals(z.заказID);
                 n = z.заказID;

            }
                try
                {
                    if (w1 != true)
                    {
                        MessageBox.Show("Заказа с данным номером не существует");
                        return;
                    }

                }
                catch { }
                foreach (Заказ z in q)
                {
                    if (z.заказID == n)
                {
                    int num = z.заказID;
                    int s1 = z.Длина;
                    int s2 = z.Ширина;
                    int s3 = z.Глубина;
                    string  s4 = z.Материал;
                    int s5 = z.Стоимость;
                    DateTimeOffset s6 = z.Дата_выполнения;
                    string s7= "oplacheno";
                    int s9 = z.клиентID;
                    int s8 = z.мебельID;
                    Program.db7.Edit(num, s1,s2,s3,s4,s5,s6,s7,s8,s9);
                    MessageBox.Show("Заказ оплачен");
                }
            }
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
