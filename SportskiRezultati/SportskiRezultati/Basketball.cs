using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportskiRezultati
{
    public class Basketball : GameDetails<int, string> //vrednost, key
    {
        public int poeni { get; set; }
        public string keybasket { get; set; }

        public Basketball(int poeni, string keybasket)
        {
            this.poeni = poeni;
            this.keybasket = keybasket;
        }
    }
}
