using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmuvanjeApartmani
{
    public class Apartman
    {
        public string Adresa { get; set; }
        public int Cena { get; set; }
        
        public Apartman(string Adresa, int Cena) 
        {
            this.Adresa = Adresa;
            this.Cena = Cena;
            
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Adresa, Cena);
        }
    }
}
