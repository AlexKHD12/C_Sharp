using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201819___vizsga_01
{
    internal class Macska : Allat
    {
        public Macska(string nev) : base(nev)
        {

        }
        public string Nyavog()
        {
            return nev + "Nyavog, mnau";
        }
    }
}
