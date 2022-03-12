using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib.Classes
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
            price = 3.5;
        }

        public override double Cost()
        {
            return price;
        }
    }
}
