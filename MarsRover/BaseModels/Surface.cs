using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverChallenge
{
    public abstract class Surface
    {
        public readonly (int, int) MinBoundary;
        public readonly (int, int) MaxBoundary;
        public bool[,] SurfaceMatrix { get; private set; }
        public List<Vehicle> VehiclesOnSurface { get; private set; }

        public Surface((int, int) minBoundary, (int, int) maxBoundary)
        {
            MinBoundary = minBoundary;
            MaxBoundary = maxBoundary;
            SurfaceMatrix = new bool[MaxBoundary.Item1+1,MaxBoundary.Item2+1];
            VehiclesOnSurface = new List<Vehicle> { };
        }

        public void AddVehicles(Vehicle aVehicle)
        {
            
            VehiclesOnSurface.Add(aVehicle);
            UpdateMatrix(aVehicle);
        }

        public virtual void UpdateMatrix(Vehicle aVehicle)
        {
            int x = aVehicle.Coordinates.Item1;
            int y = aVehicle.Coordinates.Item2;

            SurfaceMatrix[x, y] = true;

        }

        public void PrintMatrix()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 5; j++)
                    Console.Write(SurfaceMatrix[i, j] + " ");
            }
        }


    }
}
