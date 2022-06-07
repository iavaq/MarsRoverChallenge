using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverChallenge.BaseModels;

namespace MarsRoverChallenge.Models
{
    public class Plateau : Surface
    {
        private static (int, int) minBoundary = (0, 0);
        public Plateau((int, int) maxBoundary) : base(minBoundary, maxBoundary)
        {
        }
    }
}
