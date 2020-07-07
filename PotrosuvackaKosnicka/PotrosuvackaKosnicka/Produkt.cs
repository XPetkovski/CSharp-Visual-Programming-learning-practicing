using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosuvackaKosnicka
{
    public class Produkt
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public Produkt(string Name = "", string Category = "", string Price = "")
        {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
        }
        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
