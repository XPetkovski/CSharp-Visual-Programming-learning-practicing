﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV5
{
    public class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Country);
        }


    }
}
