using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV6
{
    public class Destinacija
    {
        public string ime { get; set; }
        public int oddalecenost { get; set; }
        public int cena { get; set; }

        public Destinacija(string ime="", int oddalecenost = 0, int cena =0) 
        {
            this.ime = ime;
            this.oddalecenost = oddalecenost;
            this.cena = cena;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} - {2} EUR", ime, oddalecenost, cena);
        }
    }
}
