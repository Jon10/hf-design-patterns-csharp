using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl
{
    class Stereo
    {
        private string _location;

        public Stereo(string location) => _location = location;
        public void On() => Console.WriteLine($"{_location} Stereo is On");
        public void Off() => Console.WriteLine($"{_location} Stereo is Off");
        public void SetCd() => Console.WriteLine($"{_location} Stereo set to CD");
        public void SetDvd() => Console.WriteLine($"{_location} Stereo set to DVD");
        public void SetRadio() => Console.WriteLine($"{_location} Stereo set to Radio");
        public void SetVolume(int volume) => 
            Console.WriteLine($"{_location} Stereo Volume set to {volume}");
    }

    class StereoOnWithCdCommand : ICommand
    {
        Stereo _stereo;

        public StereoOnWithCdCommand(Stereo stereo) => _stereo = stereo;
        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }
        public void Undo() => _stereo.Off();
    }

    class StereoOffCommand : ICommand
    {
        Stereo _stereo;

        public StereoOffCommand(Stereo stereo) => _stereo = stereo;
        public void Execute() => _stereo.Off();
        public void Undo()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }
    }
}
