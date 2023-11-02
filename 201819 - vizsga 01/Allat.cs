using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201819___vizsga_01
{
    internal class Allat
    {
        protected string nev;

        public Allat(string nev)
        {
            this.nev = nev;
        }

        public override string ToString()
        {
            return this.GetType().Name[0] + " " + nev;
        }
    }
}