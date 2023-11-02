using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___12__5.het_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 10) {
                listBox1.Items.Insert(0, textBox1.Text);
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Nem lehet több elemet a listába rakni!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0) {
            textBox1.Text = (string)listBox1.Items[0];
            listBox1.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Nincs elem a listában!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
