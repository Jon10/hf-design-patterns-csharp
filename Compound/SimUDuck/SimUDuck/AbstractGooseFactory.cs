using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    abstract class AbstractGooseFactory
    {
        public abstract IQuackable CreateGoose();
    }
}
