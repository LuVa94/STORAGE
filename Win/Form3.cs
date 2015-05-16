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

        //Program.db_meb Program.db1 = new Program.db_meb(@"Data Source=(LocalProgram.db)\v11.0;AttachProgram.dbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        //Program.db_kl Program.db2 = new Program.db_kl(@"Data Source=(LocalProgram.db)\v11.0;AttachProgram.dbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        //Program.db_com Program.db3 = new Program.db_com(@"Data Source=(LocalProgram.db)\v11.0;AttachProgram.dbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        //Program.db_post Program.db4 = new Program.db_post(@"Data Source=(LocalProgram.db)\v11.0;AttachProgram.dbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        //Program.db_sost Program.db5 = new Program.db_sost(@"Data Source=(LocalProgram.db)\v11.0;AttachProgram.dbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        //Program.db_zak Program.db6 = new Program.db_zak(@"Data Source=(LocalProgram.db)\v11.0;AttachProgram.dbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        //Program.db_zakaz Program.db7 = new Program.db_zakaz(@"Data Source=(LocalProgram.db)\v11.0;AttachProgram.dbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        
        
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
                label11.Text = ("материалID" + " | " + "Название");
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
                label11.Text = ("заказID" + " | " + "Длина" + " | " + "Ширина" + " | " + "Глубина" + " | " + "материалID" + " | " + "Стоимость" + " | " + "Дата_выполнения" + " | " + "Статус" + " | " + "мебельID" + " | " + "клиентID");
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
                label3.Text = "Длина";
                label4.Text = "Ширина";
                label5.Text = "Глубина";
                label6.Text = "Стоимость";
                label7.Text = "----------";
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
                label1.Text = "Название";
                label2.Text = "----------";
                label3.Text = "----------";
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
                label4.Text = "Дата доставки(ГГ-ММ-ДД)";
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
                label4.Text = "материалID";
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
                    if ((textBox1.Text == ""))
                    {
                        MessageBox.Show("Часть полей не заполнено");
                        return;
                    }
                }
                catch { }
                listBox1.Items.Clear();
                Program.db5.ADD((textBox1.Text));
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
                Program.db7.ADD(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text), textBox7.Text, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox10.Text));
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
               // int x = listBox1.SelectedIndex+1;
               // textBox9.Text = x.ToString();
                str1 = textBox1.Text;
                str2 = Convert.ToInt32(textBox2.Text);
                str3 = Convert.ToInt32(textBox3.Text);
                str4 = Convert.ToInt32(textBox4.Text);
                r = Convert.ToInt32(textBox9.Text);
                Program.db1.Edit(r, str1, str2, str3, str4);
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
                Program.db2.Edit(r, str1, str2, str3);
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
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == ""))
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
                Program.db3.Edit(r, textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
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
                Program.db4.Edit(r, str1, str2);
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
                    if ((textBox1.Text == ""))
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
                Program.db5.Edit(r, (textBox1.Text));
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
                Program.db6.Edit(r, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToDateTime(textBox4.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
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
                Program.db7.Edit(r, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToDateTime(textBox6.Text), textBox7.Text, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox10.Text));
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
                Program.db1.Delete(r);
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
                Program.db2.Delete(r);
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
                Program.db3.Delete(r);
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
                Program.db4.Delete(r);
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
                Program.db5.Delete(r);
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
                Program.db6.Delete(r);
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
                Program.db7.Delete(r);
                MessageBox.Show("Удаление записи с ID " + textBox9.Text + " завершено");
                textBox9.Text = "";
                Out();
            }
        }

        private void проверкаСтатусаЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void оплатитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void эскизИСтоимостьПолученнойМебелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
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
        }
    }
}
