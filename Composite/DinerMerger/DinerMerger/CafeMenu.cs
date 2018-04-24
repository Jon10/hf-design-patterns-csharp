using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class CafeMenu : IMenu
    {
        Hashtable menuItems = new Hashtable();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries",
            "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
            true, 3.99);
            AddItem("Soup of the day",
            "A cup of the soup of the day, with a side salad",
            false, 3.69);
            AddItem("Burrito",
            "A large burrito, with whole pinto beans, salsa, guacamole",
            true, 4.29);
        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem.Name, menuItem);
        }
        
        public IEnumerator<MenuItem> CreateIterator()
        {
            return menuItems.Values.Cast<MenuItem>().GetEnumerator();
        }
    }
}
