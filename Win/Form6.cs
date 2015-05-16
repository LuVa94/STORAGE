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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

       // Program.db_zakaz Program.db7 = new Program.db_zakaz(@"Data Source=(LocalProgram.db)\v11.0;AttachProgram.dbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
       
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show(" Строка не заполнена! Пожалуйста, введите номер заказа ");
                    return;
                }
            }
            catch { }

            var q = Program.db7.Vivod(0);
            
            var lin =
             from a in q
             where (a.заказID == Convert.ToInt32(textBox1.Text))
             select a.Статус;
            foreach (var a in lin)
                MessageBox.Show(a);

            var lin1 =
            from b in q
            where (Convert.ToInt32(textBox1.Text) > b.заказID+1)
            select 0;

            foreach (var b in lin1)
            {
                MessageBox.Show("Заказа с данным номером не существует");
                return;
            }
           
        }
    }
}
