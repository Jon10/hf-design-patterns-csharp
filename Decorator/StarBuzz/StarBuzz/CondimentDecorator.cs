using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;

        public CondimentDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double Cost()
        {
            return _beverage.Cost();
        }
    }
}
