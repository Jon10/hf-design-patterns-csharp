using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeIterator
{
    class Composite : IComposite
    {
        // return an iterator?
        private readonly List<IComponent> _children = new List<IComponent>();
        public string Name { get; }

        public Composite(string name)
        {
            Name = name;
        }

        public void AddRange(IEnumerable<IComponent> components)
        {
            _children.AddRange(components);
        }

        public IEnumerator<IComponent> GetEnumerator()
        {
            foreach (var child in _children)
            {
                yield return child;
                if (child is IComposite composite)
                {
                    foreach (var sub in composite)
                    {
                        yield return sub;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
