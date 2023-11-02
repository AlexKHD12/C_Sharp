using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___14__6.het
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fenykepalbum f1 = new Fenykepalbum();
            Fenykepalbum f2 = new Fenykepalbum(24);
            Fenykepalbum f3 = new NagyFenykepalbum();
            textBox1.AppendText("f1 lapjainak szama: " + f1.GetLapokSzama() + "\r\n");
            textBox1.AppendText("f2 lapjainak szama: " + f2.GetLapokSzama() + "\r\n");
            textBox1.AppendText("f3 lapjainak szama: " + f3.GetLapokSzama() + "\r\n");
        }
    }
}
