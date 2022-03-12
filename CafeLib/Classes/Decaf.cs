using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib.Classes
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
            price = 1.5;
        }

        public override double Cost()
        {
            return price;
        }
    }
}
