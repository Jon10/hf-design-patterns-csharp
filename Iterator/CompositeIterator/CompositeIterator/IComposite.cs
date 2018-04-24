using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeIterator
{
    interface IComposite : IComponent
    {
        void AddRange(IEnumerable<IComponent> components);
    }
}
