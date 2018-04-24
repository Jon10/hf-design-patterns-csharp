using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class QuackCounter : IQuackable
    {
        IQuackable duck;
        static int numberOfQuacks = 0;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            duck.Quack();
            numberOfQuacks += 1;
        }

        public static int GetQuacks()
        {
            return numberOfQuacks;
        }

        public void RegisterObserver(IObserver observer)
        {
            duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            duck.NotifyObservers();
        }
    }
}
