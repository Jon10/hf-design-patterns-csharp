using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee
{
    class Coffee : CaffeineBeverage
    {
        protected override void Brew() => Console.WriteLine("Dripping Coffee through filter");

        protected override void AddCondiments() => Console.WriteLine("Adding Sugar and Milk");
    }
}
