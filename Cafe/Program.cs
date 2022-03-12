using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeLib;
using CafeLib.Classes;

namespace Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseBlend hb = new HouseBlend();
            DarkRoast dr = new DarkRoast();
            Decaf dc = new Decaf();
            Espresso esp = new Espresso();

            Console.WriteLine(hb.getDescription + " - " + hb.Cost() +"$");
            Console.WriteLine(hb.SetMocha() + "$");

            Console.WriteLine(dr.getDescription + " - " + dr.Cost() + "$");
            Console.WriteLine(dr.SetWhip() + "$");

            Console.WriteLine(dc.getDescription + " - " + dc.Cost() + "$");
            Console.WriteLine(dc.SetMilk() + "$");

            Console.WriteLine(esp.getDescription + " - " + esp.Cost() + "$");
            Console.WriteLine(esp.SetMocha() + "$");
            Console.WriteLine(esp.SetMilk() + "$");

            Console.ReadLine();
        }
    }
}
