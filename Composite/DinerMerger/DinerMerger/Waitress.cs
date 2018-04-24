using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class Waitress
    {
        private MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            Console.WriteLine("\nVEGETARIAN MENU\n----");
            
            foreach(MenuComponent menuComponent in allMenus)
            {
                try
                {
                    if (menuComponent.IsVegetarian)
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotSupportedException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
