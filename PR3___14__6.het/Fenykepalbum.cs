using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3___14__6.het
{
    internal class Fenykepalbum
    {
        private int lapokSzama;

        public Fenykepalbum() {
            lapokSzama = 16;
        }

        public Fenykepalbum(int lapokSzama) {
            this.lapokSzama = lapokSzama;
        }

            public int GetLapokSzama() {
            return lapokSzama;
        }
    }
}
