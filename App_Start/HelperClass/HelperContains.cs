using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelperContainsClass
{
    public class Cars : IEquatable<Cars>
    {
        public Int32 ID;
        public String Name;
        public Decimal Price;

        public Cars(Int32 ID, String Name, Decimal Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
        }

        public String ToString()
        {
            return Name;
        }

        public bool Equals(Cars other)
        {
            return this.ID == other.ID &&
                   this.Name == other.Name &&
                   this.Price == other.Price;
        }
    }
}