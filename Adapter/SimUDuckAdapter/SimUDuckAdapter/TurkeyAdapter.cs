﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckAdapter
{
    class TurkeyAdapter : IDuck
    {
        ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey) => _turkey = turkey;

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }
    }
}
