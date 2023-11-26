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
    public partial class Form2 : Form
    {
        string loginType, user, admin;
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           // textBox3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //textBox3.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void button3_Click(object sender, EventArgs e)
        {/*
             if(textBox1.Text != "" && textBox2.Text != "")
             {
                 if(loginType == user)
                 {
                     MessageBox.Show("Login Successfull");
                     Form4 f4 = new Form4();
                     f4.Show();
                }
                if(loginType == admin)
                    {
                    MessageBox.Show("Login Successfull");
                    Form5 f5 = new Form5();
                    f5.Show();
                }


            }
            else { Console.WriteLine("wrong"); }
            */
        }
    }
}
