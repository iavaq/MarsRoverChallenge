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
        public List<Vehicle> VehiclesOnSurface;
        public Surface((int, int) minBoundary, (int, int) maxBoundary)
        {
            MinBoundary = minBoundary;
            MaxBoundary = maxBoundary;
        }

        public void GetVehiclesOnSurface()
        { 
        }

    }
}
