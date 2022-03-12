using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public abstract class Beverage
    {
        protected string description;

        double milk = 0.2;
        double soy = 0.2;
        double mocha = 2.0;
        double whip = 0.5;

        public string getDescription
        {
            get
            {
                return description;
            }
        }

        public double price { get; set; }
        abstract public double Cost();

        public string SetMilk()
        {
            return $"{description += " доб. молоко"}: { price += milk}";
        }

        public string SetSoy()
        {
            return $"{description += " доб. соя"}: {price += soy}";
        }

        public string SetMocha()
        {
            return $"{description += " доб. мокко"}: {price += mocha}";
        }

        public string SetWhip()
        {
            return $"{description += " доб. сливки"}: {price += whip}";
        }
    }
}
