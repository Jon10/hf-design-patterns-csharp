using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class CompositeEnumerator : IEnumerator<MenuComponent>
    {
        private Stack<IEnumerator<MenuComponent>> stack = new Stack<IEnumerator<MenuComponent>>();
        private bool isReset = true;
        
        public CompositeEnumerator(IEnumerator<MenuComponent> enumerator)
        {
            stack.Push(enumerator);
            isReset = true;
        }

        public MenuComponent Current
        {
            get
            {
                if (isReset == true)
                {
                    throw new InvalidOperationException("Enumeration has not started. Call MoveNext");
                }

                if (stack.Count > 0)
                {
                    IEnumerator<MenuComponent> enumerator = stack.Peek();
                    MenuComponent component = null;
                    if (enumerator.MoveNext())
                    {
                        component = enumerator.Current;
                    }
                    if (component is Menu)
                    {
                    }
                    return component;
                }
                else 
                    return null;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (stack.Count == 0 || stack.Peek() == null)
            {
                return false;
            }
            else
            {
                if (!isReset)
                {
                    stack.Pop();
                    return MoveNext();
                }
                else
                {
                    isReset = false;
                }
                return true;
            }
        }

        public void Reset()
        {
            stack.Clear();
            isReset = true;
        }
    }
}
