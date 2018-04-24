using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    abstract class Pepperoni
    {
        public override abstract string ToString();
    }

    class SlicedPepperoni : Pepperoni
    {
        public override string ToString()
        {
            return "Sliced Pepperoni";
        }
    }
}
