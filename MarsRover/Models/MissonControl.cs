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
        public MarsRover Rover { get; private set; }
    
        public Plateau PlateauSurface { get; private set; }

        public EInstructions.Directions directions;
        public EInstructions.Movements movements;

        public MissionControl(MarsRover rover, Plateau plateauSurface )
        {
            Rover = rover;
            PlateauSurface = plateauSurface;
        }

        //get min max boundaries for plateau
        //get coordinates for rover

    }
}
