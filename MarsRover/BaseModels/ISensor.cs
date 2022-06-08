using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverChallenge.BaseModels
{
    public interface ISensor
    {
        void CheckBoundaries();
        List<(int, int)> CheckObstacles(Surface surface); //returns coordinates of nearest obstacle(s)
    }
}
