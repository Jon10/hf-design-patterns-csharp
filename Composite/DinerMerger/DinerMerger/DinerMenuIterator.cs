using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class DinerMenuIterator : IEnumerator<MenuItem>
    {
        private MenuItem[] items;
        private int position = -1;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public MenuItem Current
        {
            get
            {
                if (position >= items.Length || position == -1 || items[position] == null)
                    return null;
                else
                    return items[position];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose() { } // Nothing to dispose

        public bool MoveNext()
        {
            position += 1;
            if (position >= items.Length || items[position] == null)
                return false;
            else
                return true;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
