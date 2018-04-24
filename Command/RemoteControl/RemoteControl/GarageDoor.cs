using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl
{
    class GarageDoor
    {
        public void Up() => Console.WriteLine("Garage Door is Open");
        public void Down() => Console.WriteLine("Garage Door is Closed");
        public void Stop() => Console.WriteLine("Garage Door is Stopped");
        public void LightOn() => Console.WriteLine("Garage Light is On");
        public void LightOff() => Console.WriteLine("Garage Light is Off");
    }

    class GarageDoorUpCommand : ICommand
    {
        GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor) => _garageDoor = garageDoor;
        public void Execute() => _garageDoor.Up();
        public void Undo() => _garageDoor.Down();
    }

    class GarageDoorDownCommand : ICommand
    {
        GarageDoor _garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor) => _garageDoor = garageDoor;
        public void Execute() => _garageDoor.Down();
        public void Undo() => _garageDoor.Up();
    }
}