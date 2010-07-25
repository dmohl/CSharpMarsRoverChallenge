using System;

namespace MarsRoverChallenge.Commands
{
    public interface IDSLCommandFactory
    {
        IDSLCommand Create(string[] commandElements);
    }
}
