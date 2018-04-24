using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    abstract class Cheese
    {
        public override abstract string ToString();
    }

    class ReggianoCheese : Cheese
    {
        public override string ToString()
        {
            return "Reggiano Cheese";
        }
    }

    class MozzarellaCheese : Cheese
    {
        public override string ToString()
        {
            return "Mozzarella Cheese";
        }
    }
}
