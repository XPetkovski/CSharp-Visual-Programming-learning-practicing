using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV6
{
    public class Aerodrom
    {
        public String ime { get; set; }
        public String grad { get; set; }
        public String kratenka { get; set; }
        public List<Destinacija> destinacii { get; set; }
        public Aerodrom(string ime = "", string grad = "", string kratenka = "")
        {
            this.ime = ime;
            this.grad = grad;
            this.kratenka = kratenka;
            destinacii = new List<Destinacija>();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}, {2}", kratenka, ime, grad);
        }
    }
}
