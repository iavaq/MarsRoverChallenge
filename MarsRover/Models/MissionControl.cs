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
    
        //public EInstructions.Directions directions;
        //public EInstructions.Movements movements;

        public MissionControl((int, int) maxBoundary, (int, int) coordinates, EInstructions.Directions direction, string instructions)
        {
            Rover = new MarsRover(coordinates, direction);
            PlateauSurface = new Plateau(maxBoundary);
            PlateauSurface.AddVehicles(Rover);
            Instructions = instructions;
        }

        public string CurrentLocation()
        {
            FollowInstructions();
            string output = Rover.Coordinates.ToString() + " " + Rover.Direction.ToString();
            return output;
        }

        public void FollowInstructions()
        {
            foreach (char c in Instructions)
            { 
                switch (c)
                { 
                    case 'L': Rover.LeftTurn(); break;
                    case 'R': Rover.RightTurn(); break;
                    case 'M': Rover.MoveForward(PlateauSurface); break;
                }

            }
            PlateauSurface.UpdateMatrix(Rover);
        }

        public void UpdateSurface()
        {

        }

    }
}
