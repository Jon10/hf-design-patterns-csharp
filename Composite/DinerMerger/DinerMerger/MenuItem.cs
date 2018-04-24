using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description,
                        bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public override void Print()
        {
            Console.Write($"\t{Name}");
            if (IsVegetarian) Console.Write("(v)");
            Console.Write($", {Price}");
            Console.WriteLine($" -- {Description}");
        }

        public override IEnumerator<MenuComponent> GetEnumerator()
        {
            yield break;
        }

        public override void Add(MenuComponent menuComponent) => throw new NotSupportedException();
        public override void Remove(MenuComponent menuComponent) => throw new NotSupportedException();
        public override MenuComponent GetChild(int i) => throw new NotSupportedException();
    }
}
