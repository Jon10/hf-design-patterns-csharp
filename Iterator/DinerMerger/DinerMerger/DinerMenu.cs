using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class DinerMenu : IMenu
    {
        static readonly int MaxItems = 6;
        private int numberOfItems = 0;
        private MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MaxItems];

            AddItem("Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat",
                true, 2.99);
            AddItem("BLT",
                "Bacon with lettuce & tomato on whole wheat",
                false, 2.99);
            AddItem("Soup of the day",
                "Soup of the day, with a side of potato salad",
                false, 3.29);
            AddItem("Hotdog",
                "A hotdog, with saurkraut, relish, onions, topped with cheese",
                false, 3.05);
            
            // A couple of other Diner Menu items added here
        }

        public void AddItem(string name, string description,
                            bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MaxItems)
            {
                Console.WriteLine("Sorry, menu is full. Can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems += 1;
            }
        }

        public IEnumerator<MenuItem> CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }

        // Other menu methods here
    }
}
