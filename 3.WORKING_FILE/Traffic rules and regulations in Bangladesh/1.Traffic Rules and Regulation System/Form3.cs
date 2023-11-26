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
    public partial class Form3 : Form
    {
        private bool isCollapsed;


        public Form3()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
           if (panel3.Height == 143)
            {
                panel3.Height = 39;
            }
            else
            {
                panel3.Height = 143;
            }
            /*
            Form2 f2 = new Form2();
            f2.Show();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel3.Height = 39;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        

       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }
    }
}
