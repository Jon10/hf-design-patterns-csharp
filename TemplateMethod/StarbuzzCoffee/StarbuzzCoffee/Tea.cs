using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee
{
    class Tea : CaffeineBeverage
    {
        protected override void Brew() => Console.WriteLine("Steeping the tea");

        protected override void AddCondiments() => Console.WriteLine("Adding Lemon");
    }
}
