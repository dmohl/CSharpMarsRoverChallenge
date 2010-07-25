using System.Collections.Generic;

namespace MarsRoverChallenge.Commands
{
    public class RoverCommandCollectionBuilder : MarsRoverChallenge.Commands.IRoverCommandCollectionBuilder
    {
        public virtual IDictionary<string, IRoverCommand> Build()
        {
            var roverCommandCollection = new Dictionary<string, IRoverCommand>();
            roverCommandCollection.Add("M", new MoveCommand());
            roverCommandCollection.Add("L", new TurnLeftCommand());
            roverCommandCollection.Add("R", new TurnRightCommand());

            return roverCommandCollection;
        }
    }
}
