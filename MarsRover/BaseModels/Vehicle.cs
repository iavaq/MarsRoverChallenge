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
        {
            if (Direction.Equals(EInstructions.Directions.E))
            {
                Direction = EInstructions.Directions.NONE;
            }

            Direction += 90;
            Console.WriteLine(Direction);
        }

        public void RightTurn()
        {
            if (Direction.Equals(EInstructions.Directions.NONE))
            {
                Direction = EInstructions.Directions.E;
            }

            Direction -= 90;
            Console.WriteLine(Direction);
        }

        public void MoveForward()
        {
            int x = Coordinates.Item1;
            int y = Coordinates.Item2;

            switch (Direction)
            {
                case EInstructions.Directions.E: x++;  break;
                case EInstructions.Directions.W: x--;  break;
                case EInstructions.Directions.S:; y--; break;
                case EInstructions.Directions.N: y++;  break;
            }

            Coordinates = (x, y);
            Console.WriteLine(Coordinates);
        }
    }
}
 