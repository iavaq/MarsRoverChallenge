using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverChallenge
{
    public abstract class Surface
    {
        public readonly (int, int) MinBoundary;
        public readonly (int, int) MaxBoundary;

        public Surface((int, int) maxBoundary)
        {
            MinBoundary = (0,0);
            MaxBoundary = maxBoundary;
        }   
    }
}
