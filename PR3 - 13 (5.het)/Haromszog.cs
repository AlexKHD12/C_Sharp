using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PR3___13__5.het_
{
    internal class Haromszog
    {
        private int a, b, c;

        public Haromszog(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int GetA()
        {
            return a;
        }

        public int GetB()
        {
            return b;
        }

        public int GetC()
        {
            return c;
        }

        public bool Egyenloszaru()
        {
            return a == b || b == c || a == c;
        }

        public bool Szabalyos()
        {
            return a == b && b == c;
        }

        public int Kerulet()
        {
            return a + b + c;
        }

        public double Terulet()
        {
            double s = Kerulet() / 2.0;
            double t = Math.Sqrt(s * (s - a) * (s - b) * (s - c) );
            return t;
        }
    }
}
