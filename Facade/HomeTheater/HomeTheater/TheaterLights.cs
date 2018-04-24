using System;

namespace HomeTheater
{
    internal class TheaterLights
    {
        internal void Dim(int level) => Console.WriteLine($"Theater Lights set to dim level {level}");

        internal void On() => Console.WriteLine("Theater lights set to On");
    }
}