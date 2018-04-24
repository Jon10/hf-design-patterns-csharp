using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    abstract class Clams
    {
        public override abstract string ToString();
    }

    class FreshClams : Clams
    {
        public override string ToString()
        {
            return "Fresh Clams";
        }
    }

    class FrozenClams : Clams
    {
        public override string ToString()
        {
            return "Frozen Clams";
        }
    }
}
