using System;
using System.Collections.ObjectModel;

namespace MarsRoverChallenge.Commands
{
    public class CreateRoverCommand : IDSLCommand
    {
        public virtual Tuple<string, Rover, Plateau> Execute(
            string[] commandElements, Rover rover, Plateau plateau)
        {
            var tempInt = 0;
            var xCoordinate = 0;
            var yCoordinate = 0;

            if (!int.TryParse(commandElements[0], out xCoordinate) ||
                !int.TryParse(commandElements[1], out yCoordinate) ||
                int.TryParse(commandElements[2], out tempInt))
            {
                throw new ApplicationException("Invalid Command. The rover creation command requires two integers followed by an alpha character.");
            }

            var newRover = new Rover(
                new Position(xCoordinate, yCoordinate), commandElements[2], plateau);
            return new Tuple<string, Rover, Plateau>("", newRover, plateau);
        }
    }
}
