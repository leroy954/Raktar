using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktár
{
    public class Termekek
    {
        public int Cikkszam { get; set; }

        public string Termek { get; set; }

        public Termekek(string termek, int cikkszam)
        {
            Cikkszam = cikkszam;
            Termek = termek;
        }
    }
}
