using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverChallenge.BaseModels;

namespace MarsRoverChallenge
{
    public class MarsRover : Vehicle, ISensor
    {
        public MarsRover((int,int) coordinates, EInstructions.Directions direction): base(coordinates, direction)
        {
        }

        public void CheckBoundaries()
        { 

        }

        public List<(int, int)> CheckObstacles(Surface surface)
        {
            //check x and y direction starting from rover's current coordinates
            int x = Coordinates.Item1;
            int y = Coordinates.Item2;

            List<(int, int)> obstacles = new List<(int, int)>;

            for (int  i = x;  i < surface.MaxBoundary.Item1;  i++)
            {
                if (surface.SurfaceMatrix[i,y].Equals("*"))
                {
                    obstacles.Add((i, y));
                }
            }

            for (int i = y; i < surface.MaxBoundary.Item2; i++)
            {
                if (surface.SurfaceMatrix[x, i].Equals("*"))
                {
                    obstacles.Add((x, i));
                }
            }

            return obstacles; 
        }

    }
}
