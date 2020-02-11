using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Address
    {
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }


        public override string ToString()
        {
            return $"{HouseNumber} {StreetName}";
        }
    }
}
