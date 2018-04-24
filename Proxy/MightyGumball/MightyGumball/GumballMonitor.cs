using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class GumballMonitor
    {
        private GumballMachine gumballMachine;

        public GumballMonitor(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine($"Gumball Machine: {gumballMachine.Location}");
            Console.WriteLine($"Current Inventory: {gumballMachine.Count} gumballs");
            Console.WriteLine($"Current State: {gumballMachine.State.GetType().Name}");
        }
    }
}
