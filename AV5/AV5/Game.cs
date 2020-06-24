using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV5
{
    public class Game
    {
        public string Code { get; set; }
        public Team Home { get; set; }
        public Team Away { get; set; }
        public double[] Coef { get; set; }

        public Game() 
        {
            Coef = new double[3];
        }

        public override string ToString()
        {
            return string.Format("{0} : {1} vs {2}", Code, Home, Away);
        }
    }
}
