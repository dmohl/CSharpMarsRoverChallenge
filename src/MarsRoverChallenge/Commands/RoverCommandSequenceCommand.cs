using System;
using System.Collections.ObjectModel;

namespace MarsRoverChallenge.Commands
{
    public class RoverCommandSequenceCommand : IDSLCommand
    {
        protected readonly IRoverCommandParser _roverCommandParser;

        public RoverCommandSequenceCommand() : this(new RoverCommandParser()) { }

        public RoverCommandSequenceCommand(IRoverCommandParser roverCommandParser)
        {
            _roverCommandParser = roverCommandParser;
        }

        public virtual Tuple<string, Rover, Plateau> Execute(
            string[] commandElements, Rover rover, Plateau plateau)
        {
            var roverCommands = _roverCommandParser.Parse(commandElements);

            foreach (var roverCommand in roverCommands)
            {
                roverCommand.Execute(rover);
            }

            var response = string.Format("{0} {1} {2}",
                rover.CurrentPosition.XCoordinate,
                rover.CurrentPosition.YCoordinate, rover.Orientation);

            return new Tuple<string, Rover, Plateau>(response, rover, plateau);
        }
    }
}
