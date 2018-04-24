using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    class Soy : CondimentDecorator
    {

        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return 0.15 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }
    }
}
