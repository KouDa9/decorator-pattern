using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib.Classes
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";
            price = 2.0;
        }

        public override double Cost()
        {
            return price;
        }
    }
}
