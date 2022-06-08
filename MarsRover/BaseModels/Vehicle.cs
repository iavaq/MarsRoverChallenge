using MarsRoverChallenge.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverChallenge
{
    public abstract class Vehicle: INavigation
    {
        public (int, int) Coordinates { get; private set; }
        public EInstructions.Directions Direction { get; private set; }
        public Vehicle((int, int) coordinates, EInstructions.Directions direction)
        {
            Coordinates = coordinates;
            Direction = direction;
        }

        public virtual void LeftTurn()
        {
            if (Direction.Equals(EInstructions.Directions.E))
            {
                Direction = 0;
            }

            Direction += 90;
            Console.WriteLine(Direction);
        }

        public virtual void RightTurn()
        {
            Direction -= 90;
            if (Direction.Equals(EInstructions.Directions.NONE))
            {
                Direction = EInstructions.Directions.E;
            }

            Console.WriteLine(Direction);
        }

        public virtual void MoveForward()
        {
            //check space first
            int x = Coordinates.Item1;
            int y = Coordinates.Item2;

            switch (Direction)
            {
                case EInstructions.Directions.E: x++; break;
                case EInstructions.Directions.W: x--; break;
                case EInstructions.Directions.S:; y--; break;
                case EInstructions.Directions.N: y++; break;
            }

            Coordinates = (x, y);
            Console.WriteLine(Coordinates);
        }

    }
}
 