using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class Waitress
    {
        private List<IMenu> menus;

        public Waitress(List<IMenu> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            foreach (IMenu menu in menus)
            {
                IEnumerator<MenuItem> menuItemEnumerator = menu.CreateIterator();
                PrintMenu(menuItemEnumerator);
            }
        }

        private void PrintMenu(IEnumerator<MenuItem> menuItemEnumerator)
        {
            using(menuItemEnumerator)
            {
                while(menuItemEnumerator.MoveNext())
                {
                    MenuItem menuItem = menuItemEnumerator.Current;
                    Console.Write(menuItem.Name + ", ");
                    Console.Write(menuItem.Price + " -- ");
                    Console.WriteLine(menuItem.Description);
                }
            }
        }
    }
}
