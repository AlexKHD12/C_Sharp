using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___03__2.het_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_csere_Click(object sender, EventArgs e)
        {
            string c;

            c = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = c;
        }
    }
}