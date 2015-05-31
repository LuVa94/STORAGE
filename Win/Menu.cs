using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace Win
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void Poisk()
        {
            string str = listBox1.SelectedItem.ToString();
            char razdelitel = '|';
            string[] words = str.Split(razdelitel);
            int N = words.Length;
            List<string> list = new List<string>();
            int M = 0;
            for (int i = 0; i < N; i++)
            {
                if ((words[i] != "") && (words[i] != "\n"))
                {
                    list.Add(words[i]);
                    M++;
                }

            }
            for (int i = 0; i < M; i++)
            {
                Program.r = Convert.ToInt32(list[0]);
            }
        }

        public void Out()
        {
            if (radioButton1.Checked == true)
            {
                label11.Text=("мебельID" + " | " + "Название" + " | " + "Длина" + " | " + "Ширина" + " | " + "Глубина");
                var m = Program.db1.Vivod(0);
                foreach (Мебель meb in m)
                {
                    listBox1.Items.Add(meb);
                }
            }
            if (radioButton4.Checked == true)
            {
                label11.Text = ("комплектующиеID" + " | " + "Название" + " | " + "Количество"  + " | " + "Длина" + " | " + "Ширина" + " | " + "Глубина" + " | " + "Стоимость");
                var k = Program.db3.Vivod(0);
                foreach (Комплектующие kom in k)
                {
                    listBox1.Items.Add(kom);
                }
            }
            if (radioButton2.Checked == true)
            {
                label11.Text = ("клиентID" + " | " + "ФИО" + " | " + "Контактный_телефон" + " | " + "Электронная_почта");
                var c = Program.db2.Vivod(0);
                foreach (Клиент kl in c)
                {
                    listBox1.Items.Add(kl);
                }
            }
            if (radioButton3.Checked == true)
            {
                label11.Text = ("поставщикID" + " | " + "Название_организации" + " | " + "комплетующиеID");
                var p = Program.db4.Vivod(0);
                foreach (Поставщик post in p)
                {
                    listBox1.Items.Add(post);
                }
            }
            if (radioButton7.Checked == true)
            {
                label11.Text = ("материалID" + " | " + "Название" + " | " + "Стоимость_за_1_кв_м");
                var sos = Program.db5.Vivod(0);
                foreach (Материал sost in sos)
                {
                    listBox1.Items.Add(sost);
                }
            }
            if (radioButton6.Checked == true)
            {
                label11.Text = ("закупкаID" + " | " + "поставщикID" + " | " + "комплектующиеID" + " | " + "Количество" + " | " + "Дата доставки");
                var zz = Program.db6.Vivod(0);
                foreach (Закупка zak in zz)
                {
                    listBox1.Items.Add(zak);
                }
            }
            if (radioButton5.Checked == true)
            {
                label11.Text = ("заказID" + " | " + "Длина" + " | " + "Ширина" + " | " + "Глубина" +  " | " + "Стоимость" + " | " + "Дата_выполнения" + " | " + "Статус" + " | " + "мебельID" + " | " + "клиентID");
                var q = Program.db7.Vivod(0);
                foreach (Заказ za in q)
                {
                    listBox1.Items.Add(za);
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                listBox1.Items.Clear();
                Out();
            
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = "Название";
                label2.Text = "Длина";
                label3.Text = "Ширина";
                label4.Text = "Глубина";
                label5.Text = "----------";
                label6.Text = "----------";
                label7.Text = "----------";
                label8.Text = "----------";
            }
            if (radioButton2.Checked == true)
            {
                label1.Text = "ФИО";
                label2.Text = "Контакт.телефон";
                label3.Text = "Электронная почта";
                label4.Text = "----------";
                label5.Text = "----------";
                label6.Text = "----------";
                label7.Text = "----------";
                label8.Text = "----------";
            }
            if (radioButton4.Checked == true)
            {
                label1.Text = "Название";
                label2.Text = "Количество";
                label3.Text = "Длина";
                label4.Text = "Ширина";
                label5.Text = "Глубина";
                label6.Text = "Стоимость";
                label7.Text = "----------";
                label8.Text = "----------";
            }
            if (radioButton3.Checked == true)
            {
                label1.Text = "Название организации";
                label2.Text = "комплетующиеID";
                label3.Text = "----------";
                label4.Text = "----------";
                label5.Text = "----------";
                label6.Text = "----------";
                label7.Text = "----------";
                label8.Text = "----------";
            }
            if (radioButton7.Checked == true)
            {
                label1.Text = "Название";
                label2.Text = "Стоимость_за_1_кв_м";
                label3.Text = "----------";
                label4.Text = "----------";
                label5.Text = "----------";
                label6.Text = "----------";
                label7.Text = "----------";
                label8.Text = "----------";
            }
           
            if (radioButton6.Checked == true)
            {
                label1.Text = "поставщикID";
                label2.Text = "комплетующиеID";
                label3.Text = "Количество";
                label4.Text = "Дата доставки(ГГ-ММ-ДД)";
                label5.Text = "----------";
                label6.Text = "----------";
                label7.Text = "----------";
                label8.Text = "----------";
            }
            if (radioButton5.Checked == true)
            {
                label1.Text = "Длина";
                label2.Text = "Ширина";
                label3.Text = "Глубина";
                label4.Text = "Стоимость";
                label5.Text = "Дата выполнения(ГГ-ММ-ДД)";
                label6.Text = "Статус";
                label7.Text = "мебельID";
                label8.Text = "клиентID";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                
                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                    if ((Convert.ToInt32(textBox2.Text) < 200) || (Convert.ToInt32(textBox3.Text) < 200) || (Convert.ToInt32(textBox4.Text) < 200))
                    {
                        MessageBox.Show("Введенные размеры малы");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                Program.db1.ADD(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Новая запись добавлена");
                Out();
                
            }
            if (radioButton2.Checked == true)
            {

                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                Program.db2.ADD(textBox1.Text, textBox2.Text, textBox3.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Новая запись добавлена");
                Out();

            }
            if (radioButton4.Checked == true)
            {

                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                Program.db3.ADD(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                MessageBox.Show("Новая запись добавлена");
                Out();

            }
            if (radioButton3.Checked == true)
            {

                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                Program.db4.ADD(textBox1.Text, Convert.ToInt32(textBox2.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Новая запись добавлена");
                Out();

            }
            if (radioButton7.Checked == true)
            {

                try
                {
                    if ((textBox1.Text == "")||(textBox2.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                Program.db5.ADD((textBox1.Text), Convert.ToInt32(textBox2.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Новая запись добавлена");
                Out();

            }
           
            if (radioButton6.Checked == true)
            {

                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                Program.db6.ADD(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToDateTime(textBox4.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Новая запись добавлена");
                Out();

            }
            if (radioButton5.Checked == true)
            {

                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (textBox7.Text == "") || (textBox8.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                    if ((Convert.ToInt32(textBox1.Text) < 200) || (Convert.ToInt32(textBox2.Text) < 200) || (Convert.ToInt32(textBox3.Text) < 200))
                    {
                        MessageBox.Show("Введенные размеры малы");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                Program.db7.ADD(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToDateTime(textBox5.Text), textBox6.Text, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                MessageBox.Show("Новая запись добавлена");
                Out();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                    if ((Convert.ToInt32(textBox2.Text) < 200) || (Convert.ToInt32(textBox3.Text) < 200) || (Convert.ToInt32(textBox4.Text) < 200))
                    {
                        MessageBox.Show("Введенные размеры малы");
                        return;
                    }
                }
                catch { }
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    string str1;
                    int str2, str3, str4;

                    str1 = textBox1.Text;
                    str2 = Convert.ToInt32(textBox2.Text);
                    str3 = Convert.ToInt32(textBox3.Text);
                    str4 = Convert.ToInt32(textBox4.Text);
                    Program.db1.Edit(Program.r, str1, str2, str3, str4);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    MessageBox.Show("Редактирование записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            if (radioButton2.Checked == true)
            {
                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                   
                }
                catch { }
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    string str1, str2, str3;
                    str1 = textBox1.Text;
                    str2 = textBox2.Text;
                    str3 = textBox3.Text;
                    Program.db2.Edit(Program.r, str1, str2, str3);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    MessageBox.Show("Редактирование записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            if (radioButton4.Checked == true)
            {
                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    string str1, str2, str3;
                    str1 = textBox1.Text;
                    str2 = textBox2.Text;
                    str3 = textBox3.Text;
                    Program.db3.Edit(Program.r, textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    MessageBox.Show("Редактирование записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            if (radioButton3.Checked == true)
            {
                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    string str1;
                    int str2;
                    str1 = textBox1.Text;
                    str2 = Convert.ToInt32(textBox2.Text);
                    Program.db4.Edit(Program.r, str1, str2);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Редактирование записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            if (radioButton7.Checked == true)
            {
                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    Program.db5.Edit(Program.r, textBox1.Text, Convert.ToInt32(textBox2.Text));
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    MessageBox.Show("Редактирование записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            
            if (radioButton6.Checked == true)
            {
                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    Program.db6.Edit(Program.r, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToDateTime(textBox4.Text));
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    MessageBox.Show("Редактирование записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            if (radioButton5.Checked == true)
            {
                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (textBox7.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                    if ((Convert.ToInt32(textBox1.Text) < 200) || (Convert.ToInt32(textBox2.Text) < 200) || (Convert.ToInt32(textBox3.Text) < 200))
                    {
                        MessageBox.Show("Введенные размеры малы");
                        return;
                    }
                }
                catch { }
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    Program.db7.Edit(Program.r, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToDateTime(textBox5.Text), textBox6.Text, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    MessageBox.Show("Редактирование записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    var d = Program.db7.Заказ.Where(p => p.мебельID == Program.r);
                    Program.db7.Заказ.DeleteAllOnSubmit(d);
                    Program.db7.SubmitChanges();
                    Program.db1.Delete(Program.r);
                    MessageBox.Show("Удаление записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            if (radioButton2.Checked == true)
            {
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    var d = Program.db7.Заказ.Where(p => p.клиентID == Program.r);
                    Program.db7.Заказ.DeleteAllOnSubmit(d);
                    Program.db7.SubmitChanges();
                    Program.db2.Delete(Program.r);
                    MessageBox.Show("Удаление записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            if (radioButton4.Checked == true)
            {
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    var d = Program.db6.Закупка.Where(p => p.комплектующиеID == Program.r);
                    Program.db6.Закупка.DeleteAllOnSubmit(d);
                    Program.db6.SubmitChanges();
                    Program.db3.Delete(Program.r);
                    MessageBox.Show("Удаление записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            if (radioButton3.Checked == true)
            {
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    var d = Program.db6.Закупка.Where(p => p.поставщикID == Program.r);
                    Program.db6.Закупка.DeleteAllOnSubmit(d);
                    Program.db6.SubmitChanges();
                    Program.db4.Delete(Program.r);
                    MessageBox.Show("Удаление записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            if (radioButton7.Checked == true)
            {
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    Program.db5.Delete(Program.r);
                    MessageBox.Show("Удаление записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            
            if (radioButton6.Checked == true)
            {
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    Program.db6.Delete(Program.r);
                    MessageBox.Show("Удаление записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
            if (radioButton5.Checked == true)
            {
                try
                {
                    Poisk();
                    listBox1.Items.Clear();
                    Program.db7.Delete(Program.r);
                    MessageBox.Show("Удаление записи с ID " + Program.r + " завершено");
                    Out();
                }
                catch { MessageBox.Show("Выделите строку"); }
            }
        }

        private void проверкаСтатусаЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statys f6 = new Statys();
            f6.ShowDialog();
        }

        private void оплатитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oplata f7 = new Oplata();
            f7.ShowDialog();
        }

        private void эскизИСтоимостьПолученнойМебелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViborMeb f1 = new ViborMeb();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Height=0;
            pictureBox1.Width = 0;
            button1.Enabled = false;
            button7.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = 272;
            pictureBox1.Width = 465;
            button7.Enabled = false;
            button1.Enabled = true;
        }

        private void создатьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СозЗак сз = new СозЗак();
            сз.ShowDialog();
        }

        private void заявкаНаЗакупкуКомплектующихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СозЗаяв qwe = new СозЗаяв();
            qwe.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            button7.Enabled = false;
            Metods med = new Metods();
            med.Dvizhenie();
        }
    }
}
