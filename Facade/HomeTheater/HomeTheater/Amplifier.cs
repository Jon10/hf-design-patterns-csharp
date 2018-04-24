using System;

namespace HomeTheater
{
    internal class Amplifier
    {
        internal void On() => Console.WriteLine("Amplifier set to On");

        internal void SetDvd(DvdPlayer dvd) => Console.WriteLine($"Amplifier set to DVD");

        internal void SetSurroundSound() => Console.WriteLine($"Amplifier set to SurroundSound");

        internal void SetVolume(int volume) => Console.WriteLine($"Amplifier volume set to {volume}");

        internal void Off() => Console.WriteLine("Amplifier set to Off");
    }
}