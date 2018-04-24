using System;

namespace HomeTheater
{
    internal class Projector
    {
        internal void On() => Console.WriteLine("Projector set to On");

        internal void WidescreenMode() => Console.WriteLine("Projector set to Widescreen Mode");

        internal void Off() => Console.WriteLine("Projector set to Off");
    }
}