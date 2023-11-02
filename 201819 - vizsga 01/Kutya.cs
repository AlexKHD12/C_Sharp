using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201819___vizsga_01
{
    internal class Kutya : Allat
    {
        public Kutya(string nev) : base(nev)
        {

        }
        public string Ugat()
        {
            return nev + "Ugat, hau";
        }
    }
}
