using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckAdapter
{
    class DuckTestDrive
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine();
            Console.WriteLine("The Duck says...");
            TestDuck(duck);

            Console.WriteLine();
            Console.WriteLine("The TurkeyAdapter says...");
            TestDuck(turkeyAdapter);

            Console.ReadKey();
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
