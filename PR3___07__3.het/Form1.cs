using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___07__3.het
{
    public partial class Form1 : Form
    {

        private Random rnd = new Random();
        private int gondoltszam;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gondoltszam = rnd.Next(1, 51);
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            int tippeltszam = Convert.ToInt32(tb_tipp.Text);

            if (tippeltszam > gondoltszam)
            {
                lbl_kiiratas.Text = "Kisebb számra gondoltam!";
            }
            else if (tippeltszam < gondoltszam)
            {
                lbl_kiiratas.Text = "Nagyobb számra gondoltam!";
            }
            else {
                lbl_kiiratas.Text = "Eltaláltad!";
                gondoltszam = rnd.Next(1, 51);
            }
        }
    }
}
