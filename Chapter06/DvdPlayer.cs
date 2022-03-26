﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Chapter06
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            WriteLine("DVD player is pausing.");
        }

        public void Play()
        {
            WriteLine("DVD player is playing.");
        }
    }
}
