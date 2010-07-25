using System;
using System.Collections.ObjectModel;

namespace MarsRoverChallenge.Commands
{
    public interface IDSLCommand
    {
        Tuple<string, Rover, Plateau> Execute(string[] commandElements, Rover rover, Plateau plateau);
    }
}
