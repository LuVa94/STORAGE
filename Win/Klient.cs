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
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text=="")
                {
                    MessageBox.Show("Поле не заполнено");
                }
            }
            catch { }
            
                var q = Program.db2.Vivod(0);
                var lin =
                from a in q
                where (a.ФИО.Equals(textBox1.Text) == true)
                select a;
                foreach (var a in lin)
                    listBox1.Items.Add(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string curItem = listBox1.SelectedItem.ToString();
                MessageBox.Show("Данные найдены для заполнения");

                char razdelitel = '|';
                string[] words = curItem.Split(razdelitel);
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
                    Program.id_klient = Convert.ToInt32(list[0]);
                    Program.fio = list[1];
                    Program.telef = list[2];
                    Program.email = list[3];
                }

                Close();
            }
            catch { MessageBox.Show("Выделите строку"); }
        }
    }
}
