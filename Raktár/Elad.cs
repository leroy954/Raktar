using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktár
{
    public class Elad
    {
        public string termeknev { get; set; }

        public DateTime datum { get; set; }

        public int mennyiseg { get; set; }  

        public Elad(string termeknev, DateTime datum, int mennyiseg)
        {
            this.termeknev = termeknev;
            this.datum = datum;
            this.mennyiseg = mennyiseg;
        }


    }
}
