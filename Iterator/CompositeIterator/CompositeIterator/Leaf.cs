using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeIterator
{
    class Leaf : ILeaf
    {
        public string Name { get; }
        public string Content { get; }
        public string Parent { get; }

        public Leaf(string name, string content, string parent)
        {
            Name = name;
            Content = content;
            Parent = parent;
        }

        public IEnumerator<IComponent> GetEnumerator()
        {
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
