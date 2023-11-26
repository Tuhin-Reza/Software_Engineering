using System;
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
    public partial class Form28 : Form
    {
        public Form28()
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

        private void Form28_Load(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }
    }
}
