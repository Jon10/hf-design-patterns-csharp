﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJView
{
    public interface IController
    {
        void Start();
        void Stop();
        void IncreaseBPM();
        void DecreaseBPM();
        void SetBPM(int bpm);
    }
}
