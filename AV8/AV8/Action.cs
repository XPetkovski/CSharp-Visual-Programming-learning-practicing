using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV8
{
    public class Action
    {
        public Line Line { get; set; }
        public Action(Line Line) //Action
        {
            this.Line = Line;
        }
    }
}
