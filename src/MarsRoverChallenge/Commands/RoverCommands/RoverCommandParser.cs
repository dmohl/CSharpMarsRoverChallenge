using System;
using System.Collections.Generic;

namespace MarsRoverChallenge.Commands
{
    public class RoverCommandParser : IRoverCommandParser
    {
        protected readonly IRoverCommandCollectionBuilder _roverCommandsCollectionBuilder;
        protected IDictionary<string, IRoverCommand> RoverCommandCollection { get; set; }

        public RoverCommandParser() : this(new RoverCommandCollectionBuilder()) { }

        public RoverCommandParser(IRoverCommandCollectionBuilder roverCommandsCollectionBuilder)
        {
            _roverCommandsCollectionBuilder = roverCommandsCollectionBuilder;
            Initialize();
        }

        protected void Initialize()
        {
            RoverCommandCollection = _roverCommandsCollectionBuilder.Build();
        }

        public IList<IRoverCommand> Parse(string[] commandElements)
        {
            var roverCommands = new List<IRoverCommand>();
            for (var index = 0; index < commandElements[0].Length; index++)
            {
                IRoverCommand roverCommand;
                if (!RoverCommandCollection.TryGetValue(commandElements[0][index].ToString().ToUpper(), out roverCommand))
                    throw new ApplicationException("Invalid Command");

                roverCommands.Add(roverCommand);
            }

            return roverCommands;
        }
    }
}
