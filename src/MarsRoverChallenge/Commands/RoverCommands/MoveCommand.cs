using System;
using MarsRoverChallenge.Specifications;

namespace MarsRoverChallenge.Commands
{
    public class MoveCommand : RoverCommand
    {
        public override void Execute(Rover rover)
        {
            base.Execute(rover); 
            rover.CurrentPosition = CalculateNewRoverPosition(
                    new Position(rover.CurrentPosition.XCoordinate, 
                        rover.CurrentPosition.YCoordinate), 
                    rover.Orientation); 
        }

        protected virtual Position CalculateNewRoverPosition(Position roverPosition,
            string orientation)
        {
            switch (orientation)
            {
                case "N":
                    roverPosition.YCoordinate++;
                    break;
                case "E":
                    roverPosition.XCoordinate++;
                    break;
                case "S":
                    roverPosition.YCoordinate--;
                    break;
                case "W":
                    roverPosition.XCoordinate--;
                    break;
            }

            return roverPosition;
        }
    }
}
