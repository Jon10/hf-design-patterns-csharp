using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class HasQuarterState : IState
    {
        Random randomWinner = new Random(DateTime.Now.Millisecond);
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            gumballMachine.State = gumballMachine.GetNoQuarterState();
            Console.WriteLine("Quarter returned");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if (winner == 0 && gumballMachine.Count > 1)
                gumballMachine.State = gumballMachine.GetWinnerState();
            else
                gumballMachine.State = gumballMachine.GetSoldState();
            
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
