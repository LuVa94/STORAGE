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

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка клиентов. то есть: если данного клиента нет в бд, то занести
            string fio = textBox1.Text;
            string tel = textBox2.Text;
            string mail = textBox3.Text;

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
            foreach (Клиент kl in c)
            {
                if ((kl.ФИО!=fio)&&(kl.Контактный_телефон!=tel)&&(kl.Электронная_почта!=mail))
                {
                    Program.db2.ADD(fio, tel, mail);
                }
            }
            

            //после выбора или создания эскиза показать стоимость

            //проверить хватает ли материалов

            //посчитать дату выполнения

            //выбор нужна ли доставка и установка(изменение стоимости)

            //занести новую запись в таблицу бд

            //создание договора (берутся данные с этой формы)

            //вывод сообщения готово
            MessageBox.Show("Заказ создан");
        }

        private void СозЗак_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet.Мебель". При необходимости она может быть перемещена или удалена.
            this.мебельTableAdapter.Fill(this.asdDataSet.Мебель);

            button1.Enabled = false;

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
                   
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
