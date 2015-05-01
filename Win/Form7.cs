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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Строка не заполнена! Введите, пожалуйста, номер заказа");
            }
            catch
            {
                MessageBox.Show("Заказ оплачен");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
