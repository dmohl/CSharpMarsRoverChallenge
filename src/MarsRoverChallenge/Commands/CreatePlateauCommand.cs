using System;

namespace MarsRoverChallenge.Commands
{
    public class CreatePlateauCommand : IDSLCommand
    {
        public virtual Tuple<string, Rover, Plateau> Execute(
            string[] commandElements, Rover rover, Plateau plateau)
        {
            var xCoordinate = 0;
            var yCoordinate = 0;

            if (!int.TryParse(commandElements[0], out xCoordinate) ||
                !int.TryParse(commandElements[1], out yCoordinate))
            {
                throw new ApplicationException("Invalid Command. Plateau maximum values must be specified with integers.");
            }

            var newPlateau = new Plateau(xCoordinate, yCoordinate);
            return new Tuple<string, Rover, Plateau>("", rover, newPlateau);
        }
    }
}
