using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int val = int.Parse(textBox1.Text);

            if (radioButton1.Checked)
            {
                double tol = (val * 1.8) + 32;

                label1.Text = tol.ToString();

            }
            else
            {
                double to = (val - 32) / 1.8;

                label1.Text = to.ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
