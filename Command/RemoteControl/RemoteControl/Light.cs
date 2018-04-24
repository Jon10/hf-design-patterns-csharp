using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl
{
    class Light
    {
        private string _location;

        public Light(string location) => _location = location;
        public void On() => Console.WriteLine($"{_location} Light is On");
        public void Off() => Console.WriteLine($"{_location} Light is Off");
    }

    class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light) => _light = light;
        public void Execute() => _light.On();
        public void Undo() => _light.Off();
    }

    class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light light) => _light = light;
        public void Execute() => _light.Off();
        public void Undo() => _light.On();
    }
}
