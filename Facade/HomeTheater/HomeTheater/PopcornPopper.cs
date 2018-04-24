using System;

namespace HomeTheater
{
    internal class PopcornPopper
    {
        internal void Pop()
        {
            Console.WriteLine("Popcorn Popper set to On");
            Console.WriteLine("Popcorn Popper popping popcorn");
        }

        internal void Off() => Console.WriteLine("Popcorn Popper set to Off");
    }
}