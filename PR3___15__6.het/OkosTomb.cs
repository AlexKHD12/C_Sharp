using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3___15__6.het
{
    internal class OkosTomb
    {
        private int[] tomb;
        private static Random rgen = new Random();

        public OkosTomb(int meret) {
            tomb = new int[meret];
        }

        public int[] GetOkosTomb() {
            return tomb;
        }

        public void Kiiras(TextBox tbox) {
            foreach (int e in tomb) {
                tbox.AppendText(e + ", ");
            }
            tbox.AppendText("\r\n");
        }

        public void Generalas(int min, int max) {

            for (int i = 0; i < tomb.Length; i++) {
                tomb[i] = rgen.Next(min, max + 1);
            }
        }

        public int Min() {
            int min = tomb[0];
            for (int i = 1; i < tomb.Length; i++) {
                if (tomb[i] < min) {
                    min = tomb[i];
                }
            }
            return tomb.Min();
        }

        public int Max() {
            return tomb.Max();
        }

        public int Osszeg() {
            return tomb.Sum();
        }

        public double Atlag() {
            return tomb.Average();
        }

    }
}