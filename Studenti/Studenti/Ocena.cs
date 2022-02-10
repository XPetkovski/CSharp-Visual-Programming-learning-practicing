using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    public class Ocena
    {
        public string ImePredmet { get; set; }
        public string BrojOcena { get; set; }


        public Ocena(string ImePredmet = "", string BrojOcena = "")
        {
            this.ImePredmet = ImePredmet;
            this.BrojOcena = BrojOcena;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", ImePredmet, BrojOcena);
        }
    }
}
