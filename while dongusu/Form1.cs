﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0, sayi = 0, eleman = 0;
            eleman = listBox1.Items.Count;
            while (sayi < eleman)
            {
                toplam += Convert.ToInt32(listBox1.Items[sayi]);
                sayi++;
            }

            label1.Text = "Sayıların Toplamı " + toplam.ToString();
        }
    }
}
