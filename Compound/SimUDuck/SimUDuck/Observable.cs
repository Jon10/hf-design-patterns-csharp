using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class Observable : IQuackObservable
    {
        List<IObserver> observers = new List<IObserver>();
        IQuackObservable duck;

        public Observable(IQuackObservable duck)
        {
            this.duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            IEnumerator<IObserver> enumerator = observers.GetEnumerator();
            while(enumerator.MoveNext())
            {
                IObserver observer = enumerator.Current;
                observer.Update(duck);
            }

        }
    }
}
