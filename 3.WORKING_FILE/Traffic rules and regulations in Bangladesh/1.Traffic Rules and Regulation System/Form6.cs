using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Rules_and_Regulation_System
{
    public partial class Form6 : Form
    {
        string password = "123", Info = "info";
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text == Info && textBox2.Text == password)
                {
                    MessageBox.Show("Login Successfull");
                    Form10 f10 = new Form10();
                    f10.Show();
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
        }
    }
}
