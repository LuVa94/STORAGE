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
    public partial class СозЗак : Form
    {
        public СозЗак()
        {
            InitializeComponent();
        }

        public string way = @"C:\users\user\documents\visual studio 2013\Projects\WinLinq\Эскизы\";
        public string way_dog = @"C:\users\user\documents\visual studio 2013\Projects\WinLinq\Договор\";
        public int num = 0;
        public string filename = "";

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка клиентов. если данного клиента нет в бд, то занести
            string fio = textBox1.Text;
            string tel = textBox2.Text;
            string mail = textBox3.Text;
            bool w1 = false;
            bool w2 = false;
            bool w3 = false;
           

            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                {
                    MessageBox.Show("Часть полей не заполнено");
                    return;
                }
            }
            catch { }

            var c = Program.db2.Vivod(0);
            int yes = 0;
            int asd = 0;
            foreach (Клиент kl in c)
            {
                asd++;
                w1 = fio.Equals(kl.ФИО);
                w2 = tel.Equals(kl.Контактный_телефон);
                w3 = mail.Equals(kl.Электронная_почта);
                if ((w1 == false) && (w2 == false) && (w3 == false))
                {
                    yes++;
                }
            }
            if (yes==asd)
            {
                //Program.db2.ADD(fio, tel, mail);
            }

            var q = Program.db2.Vivod(0);
            var lin =
            from a in q
            where ((w1 == true) && (w2 == true) && (w3 == true))
            select a.клиентID;
            foreach (var a in lin)
                num=a;

            int id_meb = 0;
            var m = Program.db1.Vivod(0);
            bool w4 = false;
            foreach (Мебель meb in m)
            {
                w4 = Program.vibmeb.Equals(meb.Название);
                if (w4==true)
                {
                    id_meb = meb.мебельID;
                }
            }
           

            var zakaz = Program.db7.Vivod(0);
            string stat="Vipolnenie";

            Program.db7.ADD(Program.dlina, Program.shirina, Program.glybina, Program.stoimost, Program.Datetime_vipol, stat, id_meb, num);

            MessageBox.Show("Заказ создан");

           

            Program.fio_kl = fio;
            Program.tel = tel;
            Program.mail = mail;

            var x = Program.db7.Vivod(0);
           
            foreach (Заказ za in x)
            {
                x.Last();
                Program.nomer = za.заказID;
            }

            var dialog = new SaveFileDialog();
            dialog.Filter = "OpenOffice (*.odt)|*.odt";
            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
                Dogovor dog = new Dogovor();
                dog.Wr(dialog.FileName);

                PDFDoc pd = new PDFDoc();
                pd.PDFdoc(dialog.FileName);
            }


            MessageBox.Show("Сохранено");
        }

        private void СозЗак_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet.Мебель". При необходимости она может быть перемещена или удалена.
            this.мебельTableAdapter.Fill(this.asdDataSet.Мебель);

            button1.Enabled = false;
            button5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //вызов форм создания эскизов
            if (radioButton5.Checked == true)
            {
                bool w1 = true;
                bool w2 = true;
                bool w3 = true;
                bool w4 = true;
                bool w5 = true;
                var m = Program.db1.Vivod(0);
                string name1 = "Shkaf-kype";
                string name2 = "Shkaf penal";
                string name3 = "Tymbochka";
                string name4 = "Shkaf";
                string name5 = "Komod";
                w1 = Convert.ToString(comboBox1.Text).Equals(name1);
                w2 = Convert.ToString(comboBox1.Text).Equals(name2);
                w3 = Convert.ToString(comboBox1.Text).Equals(name3);
                w4 = Convert.ToString(comboBox1.Text).Equals(name4);
                w5 = Convert.ToString(comboBox1.Text).Equals(name5);

                if (w1 != false)
                {
                    ШК sh = new ШК();
                    sh.ShowDialog();
                }
                if (w4 != false)
                {
                    Ш s = new Ш();
                    s.ShowDialog();
                }
                if (w5 != false)
                {
                    К k = new К();
                    k.ShowDialog();
                }
                if (w2 != false)
                {
                    ШП q = new ШП();
                    q.ShowDialog();
                }
                if (w3 != false)
                {
                    Т t = new Т();
                    t.ShowDialog();
                }

            }

            //выбор уже существующего эскиза
            if (radioButton6.Checked == true)
            {
                
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                   
                    System.IO.StreamReader sr = new
                       System.IO.StreamReader(openFileDialog1.FileName);
                    System.Diagnostics.Process.Start( openFileDialog1.FileName);
                    sr.Close();
                }

                Metods med = new Metods();
                med.ExtractText(openFileDialog1.FileName);
                filename = openFileDialog1.FileName;
                med.Vibor();
                   
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Klient kkk = new Klient();
            kkk.ShowDialog();
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = Program.id_klient;
            textBox1.Text = Program.fio;
            textBox2.Text = Program.telef;
            textBox3.Text = Program.email;
            button5.Enabled = false;
        }
    }
}
