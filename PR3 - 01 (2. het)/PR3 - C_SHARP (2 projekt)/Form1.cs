using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___C_SHARP__2_projekt_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_paros_Click(object sender, EventArgs e)
        {
            lbl01_output.Text = "";

            for (int i = 2; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    lbl01_output.Text += i +", ";
                }
            }
        }

        private void button2_paratlan_Click(object sender, EventArgs e)
        {
            lbl01_output.Text = "";

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    lbl01_output.Text += i + ", ";
                }
            }
        }

        private void button3_fibonacci_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 1;

            lbl01_output.Text = "0, 1, ";

            for (int i = 0; i < 8; i++) {
                int c = a + b;

                    lbl01_output.Text += c + ", ";

                a = b;
                a = c;
            }
        }
    }
}