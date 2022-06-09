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

        public virtual void MoveForward(Surface surface)
        {
            //check space first
            int x = Coordinates.Item1;
            int y = Coordinates.Item2;
            int space = 0;

            List<(int, int)> obstacles = new List<(int, int)> { };

            switch (Direction)
            {
                case EInstructions.Directions.E:
                    {
                        for (int i = x; i <= surface.MaxBoundary.Item1; ++i)
                            if (surface.SurfaceMatrix[i, y].Equals("*"))
                            {
                                obstacles.Add((i, y));
                                space = i - x;
                                break;
                            }
                        if (space > ++x)
                            x++;
                       // else throw colision exception
                        break;
                    }
                case EInstructions.Directions.W: 
                    {
                        for (int i = x; i >= surface.MinBoundary.Item1; --i)
                            if (surface.SurfaceMatrix[i, y].Equals("*"))
                            {
                                obstacles.Add((i, y));
                                space = x - i;
                                break;
                            }
                        if (space > --x)
                            x--;
                        // else throw colision exception
                        break;
                    }
                case EInstructions.Directions.S:;
                    {
                        for (int i = y; i >= surface.MinBoundary.Item2; --i)
                            if (surface.SurfaceMatrix[x, i].Equals("*"))
                            {
                                obstacles.Add((x, i));
                                space = y - i;
                                break;
                            }
                        if (space > --y)
                            y--;
                        // else throw colision exception
                        break;
                    }
                case EInstructions.Directions.N:
                    {
                        for (int i = y; i <= surface.MaxBoundary.Item2; ++i)
                            if (surface.SurfaceMatrix[x, i].Equals("*"))
                            {
                                obstacles.Add((x, i));
                                space = i - y;
                                break;
                            }
                        if (space > ++y)
                            y++;
                        // else throw colision exception
                        break;
                    }
            }

            Coordinates = (x, y);
            Console.WriteLine(Coordinates);
        }

    }
}
 