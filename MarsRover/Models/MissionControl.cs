using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverChallenge.BaseModels;
using MarsRoverChallenge.Models;

namespace MarsRoverChallenge
{
    public class MissionControl
    {
        public Plateau PlateauSurface { get; private set; }
        public MarsRover Rover { get; private set; }

        public string Instructions { get; private set; }
    
  
        public EInstructions.Directions directions;
        public EInstructions.Movements movements;

        public MissionControl((int, int) coordinates, EInstructions.Directions direction, (int, int) maxBoundary, string instructions)
        {
            Rover = new MarsRover(coordinates, direction);
            PlateauSurface = new Plateau(maxBoundary);
            Instructions = instructions;
        }

        public (int,int) CurrentLocation()
        {
            return Rover.Coordinates;
        }

    }
}
