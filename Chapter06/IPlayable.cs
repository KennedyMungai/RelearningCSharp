using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Chapter06
{
    public interface IPlayable
    {
        void Play();
        void Pause();

        void Stop()
        {
            WriteLine("Default implementation of stop.");
        }
    }
}
