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
            try
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Строка не заполнена! Введите, пожалуйста, номер заказа");
            }
            catch { }
            var q = Program.db7.Vivod(0);

            var lin =
            from a in q
            where (a.заказID == Convert.ToInt32(textBox1.Text))
            select a;
            foreach (var a in lin)
            {
                
                    int num = a.заказID;
                    int s1 = a.Длина;
                    int s2 = a.Ширина;
                    int s3 = a.Глубина;
                    int  s4 = a.материалID;
                    int s5 = a.Стоимость;
                    DateTimeOffset s6 = a.Дата_выполнения;
                    string s7= "oplacheno";
                    int s9 = a.клиентID;
                    int s8 = a.мебельID;
                    Program.db7.Edit(num, s1,s2,s3,s4,s5,s6,s7,s8,s9);
                    MessageBox.Show("Заказ оплачен");
                }

            var lin1 =
          from b in q
          where (Convert.ToInt32(textBox1.Text) > b.заказID + 1)
          select 0;

            foreach (var b in lin1)
            {
                MessageBox.Show("Заказа с данным номером не существует");
                return;
            }

     }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}
