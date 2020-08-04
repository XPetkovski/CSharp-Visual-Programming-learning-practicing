using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmuvanjeApartmani
{
    public class Grad
    {
        public string cityName { get; set; }
        public string postalCode { get; set; }

        public Grad(string cityName = " ", string postalCode = " ")
        {
            this.cityName = cityName;
            this.postalCode = postalCode;
        } 

        public override string ToString()
        {
            return string.Format("{0} - {1}", cityName, postalCode);
        }
    }
}
