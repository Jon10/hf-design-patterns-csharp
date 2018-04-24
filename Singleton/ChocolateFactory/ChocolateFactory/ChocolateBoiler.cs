using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFactory
{
    sealed class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;
        private static readonly Lazy<ChocolateBoiler> _lazy =
            new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler Instance => _lazy.Value;

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;

                Console.WriteLine("Filled...");
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                _boiled = true;

                Console.WriteLine("Boiled...");
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                _empty = true;

                Console.WriteLine("Drained...");
            }
        }

        public bool IsBoiled()
        {
            return _boiled;
        }

        public bool IsEmpty()
        {
            return _empty;
        }
    }
}
