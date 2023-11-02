using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_Tic_Tac_Toe
{
    public partial class Form1 : Form

    {
        private Button[,] gombok = new Button[3, 3];
        private int lepes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gombok[i, j] = new Button();
                    gombok[i, j].Size = new Size(100, 100);
                    gombok[i, j].Location = new Point(j * 100, i * 100);
                    gombok[i, j].Font = new Font("Arial", 40, FontStyle.Bold);
                    gombok[i, j].Click += new EventHandler(Kattintas);
                    this.Controls.Add(gombok[i, j]);
                }
            }
            this.ClientSize = new Size(300, 300);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Tic-Tac-Toe";
            this.CenterToScreen();
        }
        private void Kattintas(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "")
            {
                lepes++;
                if (lepes % 2 == 1)
                {
                    b.Text = "X";
                    //b.BackColor = Color.Black;
                }
                else
                {
                    b.Text = "O";
                    //b.BackColor = Color.Red;
                }
                Ellenorzes();
            }
        }

        private void Ellenorzes()
        {
            string nyertes = "";
            for (int i=0; i<3; i++)
            {
                if (gombok[i, 0].Text == gombok[i, 1].Text &&
                    gombok[i, 1].Text == gombok[i, 2].Text &&
                    gombok[i, 0].Text != "")
                {
                    nyertes = gombok[i, 0].Text;
                }
            }
            // oszlopok
            for (int i = 0; i < 3; i++)
            {
                if (gombok[0, i].Text == gombok[1, i].Text &&
                    gombok[1, i].Text == gombok[2, i].Text &&
                    gombok[0, i].Text != "")
                {
                    nyertes = gombok[i, 0].Text;
                }
            }
            // atlok
                if (gombok[0, 0].Text == gombok[1, 1].Text &&
                    gombok[1, 1].Text == gombok[2, 2].Text &&
                    gombok[0, 0].Text != "")
                {
                    nyertes = gombok[0, 0].Text;
                }
                if (gombok[0, 2].Text == gombok[1, 1].Text &&
                    gombok[1, 1].Text == gombok[2, 0].Text &&
                    gombok[0, 2].Text != "")
                {
                    nyertes = gombok[0, 2].Text;
                }
                // van-e nyertes?
                if (nyertes != "")
                {
                    MessageBox.Show("Nyertes: " + nyertes, "Eredmeny");
                    Ujrainditas();
                }
                else if (lepes == 9)
                {
                    MessageBox.Show("Dontetlen", "Eredmeny");
                    Ujrainditas();
                }

            }

        private void Ujrainditas()
        {
            lepes = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gombok[i, j].Text = "";
                    //gombok[i, j].BackColor = Color.White;
                }
            }
        }
        }
}
