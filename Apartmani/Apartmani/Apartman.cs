using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartmani
{
    public class Apartman
    {
        public string Adresa { get; set; }
        public int Cena { get; set; }

        public Apartman(string a, int c)
        {
            this.Adresa = a;
            this.Cena = c;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Adresa, Cena);
        }
    }
}
