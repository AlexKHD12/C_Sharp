using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___13__5.het_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int z = Convert.ToInt32(textBox3.Text);
            Haromszog h = new Haromszog(x, y, z);
            textBox4.Clear();
            textBox4.AppendText("Az a oldal hossza: " + h.GetA() + "\r\n");
            textBox4.AppendText("A b oldal hossza: " + h.GetB() + "\r\n");
            textBox4.AppendText("A c oldal hossza: " + h.GetC() + "\r\n");

            if (h.Egyenloszaru())
            {
                textBox4.AppendText("A háromszög egyenlőszárú." + "\r\n");
            }
            else
            {
                textBox4.AppendText("A háromszög NEM egyenlőszárú." + "\r\n");
            }

            if (h.Szabalyos())
            {
                textBox4.AppendText("A háromszög szabályos." + "\r\n");
            }
            else
            {
                textBox4.AppendText("A háromszög NEM szabályos." + "\r\n");
            }

            textBox4.AppendText("A háromszög kerülete: " + h.Kerulet() + "\r\n");
            textBox4.AppendText("A háromszög területe: " + h.Terulet() + "\r\n");
        }
    }
}