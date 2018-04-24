using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    abstract class Dough
    {
        public override abstract string ToString();
    }

    class ThinCrustDough : Dough
    {
        public override string ToString()
        {
            return "Thin Crust Dough";
        }
    }

    class ThickCrustDough : Dough
    {
        public override string ToString()
        {
            return "Thick Crust Dough";
        }
    }
}
