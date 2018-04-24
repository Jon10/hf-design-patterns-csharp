using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl
{
    class CeilingFan
    {
        public enum FanSpeed { Off, Low, Medium, High }
        private string _location;
        private FanSpeed _speed;

        public CeilingFan(string location) => _location = location;

        internal FanSpeed Speed { get => _speed; }

        public void Off()
        {
            Console.WriteLine($"{_location} Ceiling Fan is Off");
            _speed = FanSpeed.Off;
        }

        public void High()
        {
            _speed = FanSpeed.High;
            Console.WriteLine($"{_location} Ceiling Fan is on High");
        }
        public void Medium()
        {
            _speed = FanSpeed.Medium;
            Console.WriteLine($"{_location} Ceiling Fan is on Medium");
        }
        public void Low()
        {
            _speed = FanSpeed.Low;
            Console.WriteLine($"{_location} Ceiling Fan is on Low");
        }
    }

    class CeilingFanHighCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private CeilingFan.FanSpeed _previousSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan) => _ceilingFan = ceilingFan;

        public void Execute()
        {
            _previousSpeed = _ceilingFan.Speed;
            _ceilingFan.High();
        }
        public void Undo()
        {
            if (_previousSpeed == CeilingFan.FanSpeed.High) _ceilingFan.High();
            else if (_previousSpeed == CeilingFan.FanSpeed.Medium) _ceilingFan.Medium();
            else if (_previousSpeed == CeilingFan.FanSpeed.Medium) _ceilingFan.Low();
            else if (_previousSpeed == CeilingFan.FanSpeed.Off) _ceilingFan.Off();
        }
    }

    class CeilingFanMediumCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private CeilingFan.FanSpeed _previousSpeed;

        public CeilingFanMediumCommand(CeilingFan ceilingFan) => _ceilingFan = ceilingFan;

        public void Execute()
        {
            _previousSpeed = _ceilingFan.Speed;
            _ceilingFan.Medium();
        }
        public void Undo()
        {
            if (_previousSpeed == CeilingFan.FanSpeed.High) _ceilingFan.High();
            else if (_previousSpeed == CeilingFan.FanSpeed.Medium) _ceilingFan.Medium();
            else if (_previousSpeed == CeilingFan.FanSpeed.Medium) _ceilingFan.Low();
            else if (_previousSpeed == CeilingFan.FanSpeed.Off) _ceilingFan.Off();
        }
    }

    class CeilingFanLowCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private CeilingFan.FanSpeed _previousSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan) => _ceilingFan = ceilingFan;

        public void Execute()
        {
            _previousSpeed = _ceilingFan.Speed;
            _ceilingFan.Low();
        }
        public void Undo()
        {
            if (_previousSpeed == CeilingFan.FanSpeed.High) _ceilingFan.High();
            else if (_previousSpeed == CeilingFan.FanSpeed.Medium) _ceilingFan.Medium();
            else if (_previousSpeed == CeilingFan.FanSpeed.Medium) _ceilingFan.Low();
            else if (_previousSpeed == CeilingFan.FanSpeed.Off) _ceilingFan.Off();
        }
    }

    class CeilingFanOffCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private CeilingFan.FanSpeed _previousSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan) => _ceilingFan = ceilingFan;

        public void Execute()
        {
            _previousSpeed = _ceilingFan.Speed;
            _ceilingFan.Off();
        }
        public void Undo()
        {
            if (_previousSpeed == CeilingFan.FanSpeed.High) _ceilingFan.High();
            else if (_previousSpeed == CeilingFan.FanSpeed.Medium) _ceilingFan.Medium();
            else if (_previousSpeed == CeilingFan.FanSpeed.Medium) _ceilingFan.Low();
            else if (_previousSpeed == CeilingFan.FanSpeed.Off) _ceilingFan.Off();
        }
    }
}