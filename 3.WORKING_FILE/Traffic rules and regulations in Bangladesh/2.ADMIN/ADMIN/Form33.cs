﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public partial class Form33 : Form
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form21 f21 = new Form21();
            f21.ShowDialog();
            // this.Close();
        }
        private void Form33_Load(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }
    }
}
