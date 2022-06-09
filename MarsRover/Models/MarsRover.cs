using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverChallenge.BaseModels;

namespace MarsRoverChallenge
{
    public class MarsRover : Vehicle
    {
        public MarsRover((int,int) coordinates, EInstructions.Directions direction): base(coordinates, direction)
        {
        }

    }
}
