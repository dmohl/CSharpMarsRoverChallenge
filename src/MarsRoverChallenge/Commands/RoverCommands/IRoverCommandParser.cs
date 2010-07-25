using System;
using System.Collections.Generic;

namespace MarsRoverChallenge.Commands
{
    public interface IRoverCommandParser
    {
        IList<IRoverCommand> Parse(string[] commandElements);
    }
}
