using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
        public class Line
        {
            public string Destination { get; set; }
            public int Hour { get; set; }
            public int Minute { get; set; }
            public int Price { get; set; }

            public Line(string Destination, int Hour, int Minute, int Price)
            {
                this.Destination = Destination;
                this.Hour = Hour;
                this.Minute = Minute;
                this.Price = Price;
            }

            public override string ToString()
            {
                return string.Format("{0}:{1:00} - {2} - {3} Ден.", Hour, Minute, Destination, Price);
            }
        }
}
