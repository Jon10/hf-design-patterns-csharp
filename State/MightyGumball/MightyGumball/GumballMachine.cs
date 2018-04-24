using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class GumballMachine
    {
        IState soldOutState;
        IState noQuarterState;
        IState hasQuarterState;
        IState soldState;
        IState winnerState;

        public IState State { get; set; }
        public int Count { get; private set; } = 0;

        public GumballMachine(int count)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            Count = count;

            if (count > 0)
                State = noQuarterState;
            else
                State = soldOutState; 
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
                Count -= 1;
        }

        public IState GetNoQuarterState()
        {
            return noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public IState GetSoldState()
        {
            return soldState;
        }

        public IState GetSoldOutState()
        {
            return soldOutState;
        }

        public IState GetWinnerState()
        {
            return winnerState;
        }

        public void Refill(int count)
        {
            Count += count;
            if (Count > 0 && State == soldOutState)
            {
                State = noQuarterState;
            }
            Console.WriteLine($"Gumball machine was refilled with {Count} gumballs");
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine();
            builder.AppendLine("Mighty Gumball, Inc.");
            builder.AppendLine(".NET-enabled Standing Gumball Model #2004");
            builder.AppendLine($"Inventory: {Count} gumballs");
            if (State == hasQuarterState)
            {
                builder.Append("Machine has a quarter inserted");
            }
            else if (State == noQuarterState)
            {
                builder.Append("Machine is waiting for a quarter");
            }
            else if (State == soldOutState)
            {
                builder.Append("Machine is sold out");
            }
            else if (State == soldState)
            {
                builder.Append("Machine is dispensing a gumball");
            }
            builder.AppendLine();
            return builder.ToString();
        }
    }
}
