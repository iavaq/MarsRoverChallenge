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
        public Plateau((int, int) maxBoundary) : base(maxBoundary)
        {

        }
    }
}
