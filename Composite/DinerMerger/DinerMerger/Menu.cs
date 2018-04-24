using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class Menu : MenuComponent
    {
        private List<MenuComponent> menuComponents = new List<MenuComponent>();

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void Add(MenuComponent menuComponent) => menuComponents.Add(menuComponent);
        public override void Remove(MenuComponent menuComponent) => menuComponents.Remove(menuComponent);
        public override MenuComponent GetChild(int i) => menuComponents[i];

        public override void Print()
        {
            Console.Write($"\n{Name}");
            Console.WriteLine($", {Description}");
            Console.WriteLine("---------------------");

            foreach(MenuComponent menuComponent in menuComponents)
            {
                menuComponent.Print();
            }
        }

        public override IEnumerator<MenuComponent> GetEnumerator()
        {
            foreach(MenuComponent menuComponent in menuComponents)
            {
                yield return menuComponent;
                if (menuComponent is Menu menu)
                {
                    foreach(MenuComponent subMenuComponent in menu)
                    {
                        yield return subMenuComponent;
                    }
                }
            }
        }
    }
}
