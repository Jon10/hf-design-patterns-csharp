using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;
using System.Threading;
using System.Windows.Forms;

namespace DJView
{
    class Program
    {
        static void Main(string[] args)
        {
            //OutputDevice outputDevice = OutputDevice.InstalledDevices[0];
            //outputDevice.Open();
            //outputDevice.SendNoteOn(Channel.Channel1, Pitch.C4, 80);  // Middle C, velocity 80
            //outputDevice.SendPitchBend(Channel.Channel1, 7000);  // 8192 is centered, so 7000 is bent down

            //outputDevice.SendPercussion(Percussion.BassDrum1, 100);
            IBeatModel model = new BeatModel();
            IController controller = new BeatController(model);
            //outputDevice.Close();
            Application.Run();
        }
    }
}
