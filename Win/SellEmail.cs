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
    public partial class SellEmail : Form
    {
        public SellEmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    System.IO.StreamReader sr = new
                       System.IO.StreamReader(openFileDialog1.FileName);
                    System.Diagnostics.Process.Start(openFileDialog1.FileName);
                    Program.namefile = openFileDialog1.FileName;
                    sr.Close();
                }
            }
        }

        private void SellEmail_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet6.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.asdDataSet6.Клиент);
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q = Program.db2.Vivod(0);

            var lin =
                from a in q
                where (a.ФИО.Equals(comboBox1.Text))
                select a.Электронная_почта;

                foreach(var a in lin)
                textBox1.Text = a.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }
    }
}
