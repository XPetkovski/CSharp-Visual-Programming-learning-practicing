using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    public class Buss
    {
        public string Registration { get; set; }
        public string Name { get; set; }
        public bool isLocal { get; set; }
        public List<Line> Lines;

        public Buss(string Registration, string Name, bool isLocal)
        {
            this.Registration = Registration;
            this.Name = Name;
            this.isLocal = isLocal;
            Lines = new List<Line>();
        }

        public void AddDestination(Line line)
        {
            Lines.Add(line);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Name, Registration, isLocal ? "L" : "M");
        }
    }
}
