using System;

namespace MarsRoverChallenge.Commands
{
    public abstract class RoverCommand : IRoverCommand
    {
        public virtual void Execute(Rover rover)
        {
            if (rover == null)
                throw new ApplicationException("Invalid Command. The rover information was not provided.");
        }
    }
}
