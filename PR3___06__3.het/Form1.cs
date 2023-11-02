using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___06__3.het
{
    public partial class Form1 : Form
    {
        private int szamlalo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            szamlalo++;
            if (szamlalo == 1) {
                button1.Location = new Point(this.ClientSize.Width - button1.Width, 0);
            }
            if (szamlalo == 2) {
                button1.Location = new Point(this.ClientSize.Width - button1.Width, this.ClientSize.Height - button1.Height);
            }
            else if (szamlalo == 3)
            {
                button1.Location = new Point(0, this.ClientSize.Height - button1.Height);
            }
            else {
                button1.Location = new Point(0, 0);
                szamlalo = 0;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (szamlalo == 1)
            {
                button1.Location = new Point(this.ClientSize.Width - button1.Width, 0);
            }
            if (szamlalo == 2)
            {
                button1.Location = new Point(this.ClientSize.Width - button1.Width, this.ClientSize.Height - button1.Height);
            }
            else if (szamlalo == 3)
            {
                button1.Location = new Point(0, this.ClientSize.Height - button1.Height);
            }
        }


    }
}
