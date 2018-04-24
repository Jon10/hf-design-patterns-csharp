using System;

namespace HomeTheater
{
    internal class DvdPlayer
    {
        internal void On() => Console.WriteLine("DVD Player set to On");

        internal void Play(string movie) => Console.WriteLine($"{movie} DVD has been loaded");

        internal void Stop() => Console.WriteLine("DVD Player set to Stop");

        internal void Eject() => Console.WriteLine("DVD ejected");

        internal void Off() => Console.WriteLine("DVD Player set to Off");
    }
}