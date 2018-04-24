using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    abstract class Veggies
    {
        public override abstract string ToString();
    }

    class Garlic : Veggies
    {
        public override string ToString()
        {
            return "Garlic";
        }
    }

    class Onion : Veggies
    {
        public override string ToString()
        {
            return "Onion";
        }
    }

    class Mushroom : Veggies
    {
        public override string ToString()
        {
            return "Mushroom";
        }
    }
    
    class RedPepper : Veggies
    {
        public override string ToString()
        {
            return "Red Pepper";
        }
    }

    class BlackOlives : Veggies
    {
        public override string ToString()
        {
            return "Black Olives";
        }
    }

    class Spinach : Veggies
    {
        public override string ToString()
        {
            return "Spinach";
        }
    }

    class Eggplant : Veggies
    {
        public override string ToString()
        {
            return "Eggplant";
        }
    }
}
