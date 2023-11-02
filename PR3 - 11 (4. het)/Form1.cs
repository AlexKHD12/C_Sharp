using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PR3___11__4.het_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void osszeadas()
        {

            double osszeg = 0;

            osszeg = hScrollBar1.Value + hScrollBar2.Value;

            label3.Text = osszeg.ToString();
        }

        private void kivonas()
        {

            double osszeg = 0;

            osszeg = hScrollBar1.Value - hScrollBar2.Value;

            label3.Text = osszeg.ToString();
        }

        private void szorzas()
        {

            double osszeg = 0;

            osszeg = hScrollBar1.Value * hScrollBar2.Value;

            label3.Text = osszeg.ToString();
        }

        private void osztas()
        {

            double osszeg = 0;

            osszeg = hScrollBar1.Value / hScrollBar2.Value;

            label3.Text = osszeg.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = "Első szám: " + hScrollBar1.Value;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = "Második szám: " + hScrollBar2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            osszeadas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kivonas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            szorzas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            osztas();
        }
    }
}
