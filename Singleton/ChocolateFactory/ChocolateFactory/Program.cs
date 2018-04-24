using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler cb1 = ChocolateBoiler.Instance;
            cb1.Fill();
            cb1.Boil();
            ChocolateBoiler cb2 = ChocolateBoiler.Instance;
            cb2.Drain();

            Console.ReadKey();
        }
    }
}
