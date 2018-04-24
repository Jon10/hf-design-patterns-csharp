using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    [Obsolete]
    class PancakeHouseMenuIterator
    {
        private ArrayList items;
        private int position;

        public PancakeHouseMenuIterator(ArrayList items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (position >= items.Count || items[position] == null)
                return false;
            else
                return true;
        }

        public object Next()
        {
            MenuItem menuItem = (MenuItem)items[position];
            position += 1;
            return menuItem;
        }
    }
}
