using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverChallenge.BaseModels
{
    public interface IControl
    {
        void LeftTurn();
        void RightTurn();
        void MoveForward();
    }
}
