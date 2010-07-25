using System;
using System.Collections.ObjectModel;

namespace MarsRoverChallenge.Commands
{
    public class UnknownDSLCommand : IDSLCommand
    {
        public Tuple<string, Rover, Plateau> Execute(
            string[] commandElements, Rover rover, Plateau plateau)
        {
            return new Tuple<string, Rover, Plateau>("Unknown Command", rover, plateau);
        }
    }
}
