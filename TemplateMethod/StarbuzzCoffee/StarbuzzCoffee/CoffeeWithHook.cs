using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee
{
    class CoffeeWithHook : CaffeineBeverage
    {
        protected override void Brew() => Console.WriteLine("Dripping Coffee through filter");

        protected override void AddCondiments() => Console.WriteLine("Adding Sugar and Milk");

        protected override bool CustomerWantsCondiments()
        {
            string answer = null;

            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)?");
            answer = Console.ReadLine();

            if (answer == "y")
                return true;
            else
                return false;
        }
    }
}
