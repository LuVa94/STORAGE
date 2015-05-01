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

        DB_meb db1 = new DB_meb(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        DB_kl db2 = new DB_kl(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        DB_com db3 = new DB_com(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        DB_post db4 = new DB_post(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        DB_sost db5 = new DB_sost(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        DB_zak db6 = new DB_zak(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        DB_z db7 = new DB_z(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        DB_szak db8 = new DB_szak(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
    
        public void Out()
        {
            if (radioButton1.Checked == true)
            {
                label11.Text=("мебельID" + " | " + "Название" + " | " + "Длина" + " | " + "Ширина" + " | " + "Глубина");
                var m = db1.Vivod(0);
                foreach (Мебель meb in m)
                {
                    listBox1.Items.Add(meb);
                }
            }
            if (radioButton4.Checked == true)
            {
                label11.Text = ("комплектующиеID" + " | " + "Название" + " | " + "Количество" + " | " + "Дата_поступления" + " | " + "Длина" + " | " + "Ширина" + " | " + "Глубина" + " | " + "Стоимость");
                var k = db3.Vivod(0);
                foreach (Комплектующие kom in k)
                {
                    listBox1.Items.Add(kom);
                }
            }
            if (radioButton2.Checked == true)
            {
                label11.Text = ("клиентID" + " | " + "ФИО" + " | " + "Контактный_телефон" + " | " + "Электронная_почта");
                var c = db2.Vivod(0);
                foreach (Клиент kl in c)
                {
                    listBox1.Items.Add(kl);
                }
            }
            if (radioButton3.Checked == true)
            {
                label11.Text = ("поставщикID" + " | " + "Название_организации" + " | " + "комплетующиеID");
                var p = db4.Vivod(0);
                foreach (Поставщик post in p)
                {
                    listBox1.Items.Add(post);
                }
            }
            if (radioButton7.Checked == true)
            {
                label11.Text = ("составляющиеID" + " | " + "мебельID" + " | " + "комплектующиеID" + " | " + "Количество");
                var sos = db5.Vivod(0);
                foreach (Составляющие sost in sos)
                {
                    listBox1.Items.Add(sost);
                }
            }
            if (radioButton6.Checked == true)
            {
                label11.Text = ("закупкаID" + " | " + "поставщикID" + " | " + "комплектующиеID" + " | " + "Количество");
                var z = db6.Vivod(0);
                foreach (Закупка zak in z)
                {
                    listBox1.Items.Add(zak);
                }
            }
            if (radioButton5.Checked == true)
            {
                label11.Text = ("заказID" + " | " + "Длина" + " | " + "Ширина" + " | " + "Глубина" + " | " + "Материал" + " | " + "Стоимость" + " | " + "Дата_выполнения" + " | " + "Статус" + " | " + "мебельID" + " | " + "клиентID");
                var q = db7.Vivod(0);
                foreach (Заказ z in q)
                {
                    listBox1.Items.Add(z);
                }
            }
            if (radioButton8.Checked == true)
            {
                label11.Text = ("ID" + " | " + "заказID" + " | " + "мебельID" + " | " + "Количество");
                var sz = db8.Vivod(0);
                foreach (Список_заказов szak in sz)
                {
                    listBox1.Items.Add(szak);
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
                label12.Text = "----------";
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
                label12.Text = "----------";
            }
            if (radioButton4.Checked == true)
            {
                label1.Text = "Название";
                label2.Text = "Количество";
                label3.Text = "Дата поступления(ГГ-ММ-ДД)";
                label4.Text = "Длина";
                label5.Text = "Ширина";
                label6.Text = "Глубина";
                label7.Text = "Стоимость";
                label8.Text = "----------";
                label12.Text = "----------";
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
                label12.Text = "----------";
            }
            if (radioButton7.Checked == true)
            {
                label1.Text = "мебельID";
                label2.Text = "комплетующиеID";
                label3.Text = "Количество";
                label4.Text = "----------";
                label5.Text = "----------";
                label6.Text = "----------";
                label7.Text = "----------";
                label8.Text = "----------";
                label12.Text = "----------";
            }
            if (radioButton8.Checked == true)
            {
                label1.Text = "заказID";
                label2.Text = "мебельID";
                label3.Text = "Количество";
                label4.Text = "----------";
                label5.Text = "----------";
                label6.Text = "----------";
                label7.Text = "----------";
                label8.Text = "----------";
                label12.Text = "----------";
            }
            if (radioButton6.Checked == true)
            {
                label1.Text = "поставщикID";
                label2.Text = "комплетующиеID";
                label3.Text = "Количество";
                label4.Text = "----------";
                label5.Text = "----------";
                label6.Text = "----------";
                label7.Text = "----------";
                label8.Text = "----------";
                label12.Text = "----------";
            }
            if (radioButton5.Checked == true)
            {
                label1.Text = "Длина";
                label2.Text = "Ширина";
                label3.Text = "Глубина";
                label4.Text = "Материал";
                label5.Text = "Стоимость";
                label6.Text = "Дата выполнения(ГГ-ММ-ДД)";
                label7.Text = "Статус";
                label8.Text = "мебельID";
                label12.Text = "клиентID";
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
                db1.ADD(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
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
                db2.ADD(textBox1.Text, textBox2.Text, textBox3.Text);
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
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (textBox7.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                db3.ADD(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToDateTime(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
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
                db4.ADD(textBox1.Text, Convert.ToInt32(textBox2.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Новая запись добавлена");
                Out();

            }
            if (radioButton7.Checked == true)
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
                db5.ADD(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Новая запись добавлена");
                Out();

            }
            if (radioButton8.Checked == true)
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
                db8.ADD(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
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
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                db6.ADD(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
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
                db7.ADD(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text), textBox7.Text, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox10.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox10.Text = "";
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
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
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
                string str1;
                int str2, str3, str4, r;
                str1 = textBox1.Text;
                str2 = Convert.ToInt32(textBox2.Text);
                str3 = Convert.ToInt32(textBox3.Text);
                str4 = Convert.ToInt32(textBox4.Text);
                r = Convert.ToInt32(textBox9.Text);
                db1.Edit(r, str1, str2, str3, str4);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Редактирование записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
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
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                string str1, str2, str3; 
                int r;
                str1 = textBox1.Text;
                str2 = textBox2.Text;
                str3 = textBox3.Text;
                r = Convert.ToInt32(textBox9.Text);
                db2.Edit(r, str1, str2, str3);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Редактирование записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
            if (radioButton4.Checked == true)
            {
                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (textBox7.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                string str1, str2, str3;
                int r;
                str1 = textBox1.Text;
                str2 = textBox2.Text;
                str3 = textBox3.Text;
                r = Convert.ToInt32(textBox9.Text);
                db3.Edit(r, textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToDateTime(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                MessageBox.Show("Редактирование записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
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
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                string str1;
                int r, str2;
                str1 = textBox1.Text;
                str2 = Convert.ToInt32(textBox2.Text);
                r = Convert.ToInt32(textBox9.Text);
                db4.Edit(r, str1, str2);
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Редактирование записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
            if (radioButton7.Checked == true)
            {
                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                int r;
                r = Convert.ToInt32(textBox9.Text);
                db5.Edit(r, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Редактирование записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
            if (radioButton8.Checked == true)
            {
                try
                {
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                int r;
                r = Convert.ToInt32(textBox9.Text);
                db8.Edit(r, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Редактирование записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
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
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                int r;
                r = Convert.ToInt32(textBox9.Text);
                db6.Edit(r, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Редактирование записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
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
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
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
                int  r;
                r = Convert.ToInt32(textBox9.Text);
                db7.Edit(r, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text), textBox7.Text, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox10.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox10.Text = "";
                MessageBox.Show("Редактирование записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                int r;
                r = Convert.ToInt32(textBox9.Text);
                db1.Delete(r);
                MessageBox.Show("Удаление записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
            if (radioButton2.Checked == true)
            {
                try
                {
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                int r;
                r = Convert.ToInt32(textBox9.Text);
                db2.Delete(r);
                MessageBox.Show("Удаление записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
            if (radioButton4.Checked == true)
            {
                try
                {
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                int r;
                r = Convert.ToInt32(textBox9.Text);
                db3.Delete(r);
                MessageBox.Show("Удаление записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
            if (radioButton3.Checked == true)
            {
                try
                {
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                int r;
                r = Convert.ToInt32(textBox9.Text);
                db4.Delete(r);
                MessageBox.Show("Удаление записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
            if (radioButton7.Checked == true)
            {
                try
                {
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                int r;
                r = Convert.ToInt32(textBox9.Text);
                db5.Delete(r);
                MessageBox.Show("Удаление записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
            if (radioButton8.Checked == true)
            {
                try
                {
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                int r;
                r = Convert.ToInt32(textBox9.Text);
                db8.Delete(r);
                MessageBox.Show("Удаление записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
            if (radioButton6.Checked == true)
            {
                try
                {
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                int r;
                r = Convert.ToInt32(textBox9.Text);
                db6.Delete(r);
                MessageBox.Show("Удаление записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
            if (radioButton5.Checked == true)
            {
                try
                {
                    if (textBox9.Text == "")
                    {
                        MessageBox.Show("Поле ID не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                int r;
                r = Convert.ToInt32(textBox9.Text);
                db7.Delete(r);
                MessageBox.Show("Удаление записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
        }

        private void проверкаСтатусаЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void оплатитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void эскизИСтоимостьПолученнойМебелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
