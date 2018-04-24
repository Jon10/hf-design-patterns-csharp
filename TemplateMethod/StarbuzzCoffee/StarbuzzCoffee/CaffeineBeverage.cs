using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        private void BoilWater() => Console.WriteLine("Boiling Water");

        private void PourInCup() => Console.WriteLine("Pour into cup");

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
