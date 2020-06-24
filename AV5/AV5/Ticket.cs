using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV5
{
    public class Ticket
    {
        public Game game { get; set; }
        public int tip { get; set; } //0,1,2

        public override string ToString()
        {
            return string.Format("{0} Tip: {1}", game.ToString(), tip == 0 ? "1" : tip == 1 ? "X" : "2");
        }
    }
}
