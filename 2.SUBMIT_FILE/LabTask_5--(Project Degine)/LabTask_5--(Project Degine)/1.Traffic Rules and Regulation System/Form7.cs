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
    public partial class Form7 : Form
    {
        string password = "123", user = "user";
        public Form7()
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
                if (textBox1.Text == user && textBox2.Text == password)
                {
                    MessageBox.Show("Login Successfull");
                    Form4 f4 = new Form4();
                    f4.Show();
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }

        }

    }
}
