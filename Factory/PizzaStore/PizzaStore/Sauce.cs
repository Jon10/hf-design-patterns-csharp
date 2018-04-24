using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    abstract class Sauce
    {
        public override abstract string ToString();
    }

    class MarinaraSauce : Sauce
    {
        public override string ToString()
        {
            return "Marinara Sauce";
        }
    }

    class PlumTomatoSauce : Sauce
    {
        public override string ToString()
        {
            return "Plum Tomato Sauce";
        }
    }
}