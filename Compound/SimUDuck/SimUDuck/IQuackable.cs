using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}
