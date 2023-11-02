using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___09__4.het_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void calc()
        {
            double ar = 0;

            if (radioButton1.Checked) { ar = 0.35; }
            if (radioButton2.Checked) { ar = 0.25; }
            if (radioButton3.Checked) { ar = 0.45; }
            if (checkBox1.Checked) { ar = ar + 0.05; }
            if (checkBox2.Checked) { ar = ar + 0.10; }
            if (checkBox3.Checked) { ar = ar + 0.05; }
            if (checkBox4.Checked) { ar = ar + 0.10; }
            label1.Text = "Fizetendő: " + ar.ToString("0.00") + " EUR";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            reset();
            checkBox1.Enabled = false;
            checkBox4.Enabled = true;
            calc();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            reset();
            checkBox1.Enabled = true;
            checkBox4.Enabled = false;
            calc();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            reset();
            checkBox1.Enabled = false;
            checkBox4.Enabled = false;
            calc();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            calc();
        }
    }
}