using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___08__3.het
{
    public partial class Form1 : Form
    {
        private double ar = 2.5;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ar += 0.8;
            }
            else
            {
                ar -= 0.8;
            }

            pizza_ara.Text = "Pizza ára: " + ar.ToString("0.00") + " EUR";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                ar += 0.7;
            }
            else
            {
                ar -= 0.7;
            }

            pizza_ara.Text = "Pizza ára: " + ar.ToString("0.00") + " EUR";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                ar += 0.75;
            }
            else
            {
                ar -= 0.75;
            }

            pizza_ara.Text = "Pizza ára: " + ar.ToString("0.00") + " EUR";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                ar += 0.6;
            }
            else
            {
                ar -= 0.6;
            }

            pizza_ara.Text = "Pizza ára: " + ar.ToString("0.00") + " EUR";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                ar += 0.45;
            }
            else
            {
                ar -= 0.45;
            }

            pizza_ara.Text = "Pizza ára: " + ar.ToString("0.00") + " EUR";
        }
    }
}
