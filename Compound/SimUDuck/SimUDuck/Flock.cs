using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class Flock : IQuackable
    {
        List<IQuackable> quackers = new List<IQuackable>();

        public void Add(IQuackable quacker)
        {
            quackers.Add(quacker);
        }

        public void Quack()
        {
            IEnumerator<IQuackable> enumerator = quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                IQuackable quacker = enumerator.Current;
                quacker.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            IEnumerator<IQuackable> enumerator = quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                IQuackable quacker = enumerator.Current;
                quacker.RegisterObserver(observer);
            }
        }

        public void NotifyObservers()
        {
            IEnumerator<IQuackable> enumerator = quackers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                IQuackable quacker = enumerator.Current;
                quacker.NotifyObservers();
            }
        }
    }
}
