﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "asdDataSet.Мебель". При необходимости она может быть перемещена или удалена.
            this.мебельTableAdapter.Fill(this.asdDataSet.Мебель);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
