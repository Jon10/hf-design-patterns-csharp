using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            Tuner tuner = new Tuner();
            DvdPlayer dvdPlayer = new DvdPlayer();
            CdPlayer cdPlayer = new CdPlayer();
            Projector projector = new Projector();
            TheaterLights lights = new TheaterLights();
            Screen screen = new Screen();
            PopcornPopper popper = new PopcornPopper();


            HomeTheaterFacade homeTheater =
                new HomeTheaterFacade(amp, tuner, dvdPlayer, cdPlayer,
                    projector, screen, lights, popper);
            homeTheater.WatchMovie("Inception");
            Console.WriteLine();
            homeTheater.EndMovie();
            Console.ReadKey();
        }
    }
}
