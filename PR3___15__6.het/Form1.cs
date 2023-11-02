using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___15__6.het
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OkosTomb ot1 = new OkosTomb(15);
            OkosTomb ot2 = new OkosTomb(10);
            ot1.Generalas(0, 100);
            ot2.Generalas(200,500);
            ot1.Kiiras(textBox1);
            ot2.Kiiras(textBox1);
            textBox1.AppendText("ot2 minimuma: " + ot2.Min() + "\r\n");
            textBox1.AppendText("ot2 maximuma: " + ot2.Max() + "\r\n");
            textBox1.AppendText("ot2 elemeinek osszege: " + ot2.Osszeg() + "\r\n");
            textBox1.AppendText("ot2 elemeinek atlaga: " + ot2.Atlag() + "\r\n");
        }
    }
}
