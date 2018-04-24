using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 112;
            string location = "Seattle";

            GumballMachine gumballMachine = new GumballMachine(location, count);

            GumballMonitor gumballMonitor = new GumballMonitor(gumballMachine);

            gumballMonitor.Report();

            Console.ReadKey();
        }

        private void TestGumballMachineStates()
        {
            GumballMachine gumballMachine = new GumballMachine("", 5);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.Write(gumballMachine);
        }
    }
}
