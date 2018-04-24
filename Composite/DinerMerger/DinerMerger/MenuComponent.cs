using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    abstract class MenuComponent : IEnumerable<MenuComponent>
    {
        public abstract void Add(MenuComponent menuComponent);
        public abstract void Remove(MenuComponent menuComponent);
        public abstract MenuComponent GetChild(int i);

        public virtual string Name { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual bool IsVegetarian { get; protected set; }
        public virtual double Price { get; protected set; }

        public abstract void Print();

        public abstract IEnumerator<MenuComponent> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
