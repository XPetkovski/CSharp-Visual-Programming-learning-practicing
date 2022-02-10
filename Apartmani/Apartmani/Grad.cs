using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartmani
{
    public class Grad
    {
        public string Ime { get; set; }
        public int Kod { get; set; }
        public List<Apartman> Apartmani { get; set; }
        public Grad(string i, int k)
        {
            this.Ime = i;
            this.Kod = k;
            this.Apartmani = new List<Apartman>();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Ime, Kod);
        }
    }
}
