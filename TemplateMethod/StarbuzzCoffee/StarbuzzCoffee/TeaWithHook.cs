using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee
{
    class TeaWithHook : CaffeineBeverage
    {
        protected override void Brew() => Console.WriteLine("Steeping the tea");

        protected override void AddCondiments() => Console.WriteLine("Adding Lemon");

        protected override bool CustomerWantsCondiments()
        {
            string answer = null;

            Console.WriteLine("Would you like lemon with your tea (y/n)?");
            answer = Console.ReadLine();

            if (answer == "y")
                return true;
            else
                return false;
        }
    }
}
