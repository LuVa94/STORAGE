using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Поле не заполнено");
                }
            }
            catch { }

            var q = Program.db2.Vivod(0);
            var lin =
            from a in q
            where (a.ФИО.Equals(comboBox1.Text) == true)
            select a.Электронная_почта;
            foreach (var a in lin)
                textBox1.Text=a;
        }

        private void Mail_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet7.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.asdDataSet7.Клиент);

        }
        public string filenamedog = "";
        public string filenameesk = "";
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                //при выборе договора (нужно сделать специфическое начало названия файлов-договоров)
                filenamedog = openFileDialog1.FileName;
                textBox3.Text = filenamedog;
                //при выборе эскиза 
                filenameesk = openFileDialog1.FileName;
                textBox4.Text = filenameesk;
               // System.Diagnostics.Process.Start(openFileDialog1.FileName);
                sr.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mailTo = textBox1.Text;
            var theme = "Договор на оформление заказа мебели";
            var text = textBox2.Text;
            var file = textBox4.Text;

            string[] files = new string[1];
            files[0] = file;

            Email.SendMessage("smtp.yandex.ru", "kts-94@yandex.ru", "1q2w3e4R%", mailTo, theme, text, file);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
