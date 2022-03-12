using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib.Classes
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
            price = 3.0;
        }

        public override double Cost()
        {
            return price;
        }
    }
}
