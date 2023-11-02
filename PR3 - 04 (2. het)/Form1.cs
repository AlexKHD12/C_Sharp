using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___04__2.het_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_sorsolas_Click(object sender, EventArgs e)
        {
            int[] t = new int[5];
            Random rnd = new Random();
            int i = 0;

            do
            {
                int x = rnd.Next(1, 91);

                if (!t.Contains(x)) {
                t[i] = x;
                i++;
            } while (i < 5);

            Array.Sort(t);

            lbl01_output.Text = "Számok: ";

            foreach (int item in t) {
                lbl01_output.Text += item + ", ";
                }
            }
        }
    }
}