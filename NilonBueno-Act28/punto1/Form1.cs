using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto1
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int I = int.Parse(textBox1.Text);

            int E = int.Parse(textBox2.Text);

            int J = int.Parse(textBox3.Text);

            double res = I + E + J;
            double tol = res / 3;
            label1.Text = tol.ToString();



            if (tol > 6)
            {
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.BackColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
