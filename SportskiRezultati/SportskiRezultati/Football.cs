using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportskiRezultati
{
    public class Football : GameDetails<string, string>
    {
        public string Key { get; set; }
        public string Golovi { get; set; }

        public Football(string Key = "", string Golovi = "")
        {
            this.Key = Key;
            this.Golovi = Golovi;
        }
    }
}
