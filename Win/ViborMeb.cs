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
    public partial class ViborMeb : Form
    {
        public ViborMeb()
        {
            InitializeComponent();
        }

       // Program.db_meb Program.db1 = new Program.db_meb(@"Data Source=(LocalProgram.db)\v11.0;AttachProgram.dbFilename=c:\users\user\documents\visual studio 2013\Projects\WinLinq\Win\Asd.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet.Мебель". При необходимости она может быть перемещена или удалена.
            this.мебельTableAdapter.Fill(this.asdDataSet.Мебель);

        }


        private void button1_Click(object sender, EventArgs e) /// подумать как реализовать выбор
        {
             bool w1=true;
             bool w2 = true;
             bool w3 = true;
             bool w4 = true;
             bool w5 = true;
             var m = Program.db1.Vivod(0);
             string name1="Shkaf-kype";
             string name2 = "Shkaf penal";
             string name3 = "Tymbochka";
             string name4 = "Shkaf";
             string name5 = "Komod";
             w1 = Convert.ToString(comboBox1.Text).Equals(name1);
             w2 = Convert.ToString(comboBox1.Text).Equals(name2);
             w3 = Convert.ToString(comboBox1.Text).Equals(name3);
             w4 = Convert.ToString(comboBox1.Text).Equals(name4);
             w5 = Convert.ToString(comboBox1.Text).Equals(name5);
            
            if (w1!=false)
            {
                ШК sh = new ШК();
                sh.ShowDialog();
                Program.vibormeb = 1;
            }
            if (w4 != false)
            {
                Ш s = new Ш();
                s.ShowDialog();
                Program.vibormeb = 4;
            }
            if (w5 != false)
            {
                К k = new К();
                k.ShowDialog();
                Program.vibormeb = 3;
            }
            if (w2 != false)
            {
                ШП a = new ШП();
                a.ShowDialog();
                Program.vibormeb = 2;
            }
        }
    }
}
