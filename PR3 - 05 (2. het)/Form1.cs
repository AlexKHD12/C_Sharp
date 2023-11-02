using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___05__2.het_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_szamitas_Click(object sender, EventArgs e)
        {
            double burgonya = 1.20;
            double repa = 0.99;
            double kaposzta = 0.75;

            double vegosszeg = Convert.ToDouble(textBox1.Text) * burgonya + Convert.ToDouble(textBox2.Text) * repa + Convert.ToDouble(textBox3.Text) * kaposzta;

            vegosszeg = Math.Round(vegosszeg, 2);
            label4.Text = "Fizetendő: " + vegosszeg + " EUR";
        }
    }
}