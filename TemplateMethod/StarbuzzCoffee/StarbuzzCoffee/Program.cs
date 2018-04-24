using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea myTea = new Tea();
            myTea.PrepareRecipe();

            Coffee myCoffee = new Coffee();
            myCoffee.PrepareRecipe();

            CoffeeWithHook myCoffeeWithHook = new CoffeeWithHook();
            myCoffeeWithHook.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
