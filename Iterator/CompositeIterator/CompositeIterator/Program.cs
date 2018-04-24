using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root node");
            Composite composite1 = new Composite("composite 1");
            Leaf leaf1 = new Leaf("leaf 1", "some content", "composite 1");
            Leaf leaf2 = new Leaf("leaf 2", "some content", "composite 1");
            Leaf leaf3 = new Leaf("leaf 3", "some content", "composite 1");
            Composite composite2 = new Composite("composite 2");
            Leaf leaf4 = new Leaf("leaf 4", "some content", "composite 2");
            Leaf leaf5 = new Leaf("leaf 5", "some content", "composite 2");
            Composite composite3 = new Composite("composite 3");
            Leaf leaf6 = new Leaf("leaf 6", "some content", "composite 3");
            Composite composite4 = new Composite("composite 4");
            Leaf leaf7 = new Leaf("leaf 7", "some content", "composite 4");
            Leaf leaf8 = new Leaf("leaf 8", "some content", "composite 4");

            root.AddRange(new IComponent[] { composite1, composite2, composite3 });
            composite1.AddRange(new IComponent[] { leaf1, leaf2, leaf3 });
            composite2.AddRange(new IComponent[] { leaf4, leaf5, composite4 });
            composite3.AddRange(new IComponent[] { leaf6 });
            composite4.AddRange(new IComponent[] { leaf7, leaf8 });

            foreach (IComponent component in root)
            {
                Console.WriteLine(component.Name);
            }

            Console.ReadKey();
        }
    }
}
