using MarsRoverChallenge.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverChallenge
{
    public abstract class Vehicle: IControl
    {
        public (int, int) Coordinates { get; set; }
        public EInstructions.Directions Direction { get; set; }
        public Vehicle((int, int) coordinates, EInstructions.Directions direction)
        {
            Coordinates = coordinates;
            Direction = direction;
        }
        public void LeftTurn()
        { }

        public void RightTurn()
        { }

        public void MoveForward(int steps)
        { }

        public void MoveBackwards(int steps)
        { }
    }
}
