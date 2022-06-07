using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverChallenge.BaseModels
{
    public static class EInstructions
    {
        public enum Directions 
        { 
            NONE = 0, 
            N = 90, 
            W = 180, 
            S = 270,
            E = 360
        }

        public enum Movements { NONE, L, R, F }
    }
}
