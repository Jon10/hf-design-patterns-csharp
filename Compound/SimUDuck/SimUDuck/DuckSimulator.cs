using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            AbstractGooseFactory gooseFactory = new GooseFactory();

            simulator.Simulate(duckFactory, gooseFactory);

            Console.ReadKey();
        }

        void Simulate(AbstractDuckFactory duckFactory, AbstractGooseFactory gooseFactory)
        {
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = gooseFactory.CreateGoose();

            Console.WriteLine("Duck Simulator: With Composite - Flocks”");

            Flock flockOfDucks = new Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            Flock flockOfMallards = new Flock();

            IQuackable mallardOne = duckFactory.CreateMallardDuck();
            IQuackable mallardTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardThree = duckFactory.CreateMallardDuck();
            IQuackable mallardFour = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
            Simulate(flockOfDucks);

            Console.WriteLine("\nDuck Simulator: Mallard Flock Simulator");
            Simulate(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: With Observer");
            Quackologist quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);

            Simulate(flockOfDucks);

            Console.WriteLine($"\nThe ducks quacked {QuackCounter.GetQuacks()} times");
        }

        void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
