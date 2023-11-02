using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201819___vizsga_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (radioButton_kutya.Checked)
            {
                Kutya kutya = new Kutya(textBox_nev.Text);
                listBox1.Items.Add(kutya);
            }
            else
            {
                Macska macska = new Macska(textBox_nev.Text);
                listBox1.Items.Add(macska);
            }
            
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (listBox1.SelectedItem is Kutya)
                {
                    pictureBox1.Image = Properties.Resources.kutya;
                    label_output.Text = ((Kutya)listBox1.SelectedItem).Ugat();
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.macska;
                    label_output.Text = ((Macska)listBox1.SelectedItem).Nyavog();
                }
                button_remove.Enabled = true;
            }
            else
            {
                pictureBox1.Image = null;
                label_output.Text = "";
                button_remove.Enabled = false;
            }
        }

        private void textBox_nev_TextChanged(object sender, EventArgs e)
        {
            button_add.Enabled = textBox_nev.Text != "";
        }
    }
}