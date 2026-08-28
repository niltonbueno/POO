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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int ta1 = int.Parse(textBox1.Text);
            int ta2 = int.Parse(textBox2.Text);

            int res2 = ta1 + ta2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int ta1 = int.Parse(textBox1.Text);
                int ta2 = int.Parse(textBox2.Text);

                int res = ta1 - ta2;
                Text = res.ToString();
            }
            if (radioButton2.Checked == true)
            {
                int ta1 = int.Parse(textBox1.Text);
                int ta2 = int.Parse(textBox2.Text);

                int res = ta1 + ta2;
                Text = res.ToString();
            }
        }
    }
}
