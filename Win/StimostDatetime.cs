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
    public partial class StimostDatetime : Form
    {
        public StimostDatetime()
        {
            InitializeComponent();
        }

        private void StimostDatetime_Load(object sender, EventArgs e)
        {
            Metods med = new Metods();
            textBox6.Text = med.Vremya();
            Program.Datetime_vipol =Convert.ToDateTime(med.Vremya());
            textBox5.Text = Program.stoimost.ToString();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = Program.stoimost;
            if (checkBox1.Checked == true)
            {
                sum += 500;
                Program.stoimost = sum;
                textBox5.Text = Program.stoimost.ToString();
                Program.vibdos = "yes";
            }
            if (checkBox2.Checked == true)
            {
                sum =sum+ Program.stoimost/10;
                Program.stoimost = sum;
                textBox5.Text = Program.stoimost.ToString();
                Program.vibsbor = "yes";
            }
            //MessageBox.Show(Program.vibdos);
            //MessageBox.Show(Program.vibsbor);
        }
    }
}
