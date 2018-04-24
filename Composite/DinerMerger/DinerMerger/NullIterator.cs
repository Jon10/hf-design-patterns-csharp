using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class NullIterator : IEnumerator<MenuComponent>
    {
        public MenuComponent Current => null;

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset() { }
    }
}
