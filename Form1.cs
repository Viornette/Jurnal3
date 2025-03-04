using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022300145
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hasil, a, b, c;

        private void button2_Click(object sender, EventArgs e)
        {
            a = a * 10 + 2;
            labelOutput.Text = labelOutput.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = a * 10 + 3;
            labelOutput.Text = labelOutput.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = a * 10 + 4;
            labelOutput.Text = labelOutput.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = a * 10 + 5;
            labelOutput.Text = labelOutput.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = a * 10 + 6;
            labelOutput.Text = labelOutput.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = a * 10 + 7;
            labelOutput.Text = labelOutput.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = a * 10 + 8;
            labelOutput.Text = labelOutput.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = a * 10 + 9;
            labelOutput.Text = labelOutput.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            a = a * 10;
            labelOutput.Text = labelOutput.Text + "0";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                c = a;
                b = 0;
                a = 0;
                labelOutput.Text += "+";
            }
            else
            {
                b = a;
                a = 0;
                labelOutput.Text += "+";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = a * 10 + 1;
            labelOutput.Text = labelOutput.Text + "1";
        }

        private void buttonsmdg_Click(object sender, EventArgs e)
        {
            hasil = a + b + c;
            labelOutput.Text = hasil.ToString();
        }
    }
}
