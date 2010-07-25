using System;
using System.Collections.Generic;

namespace MarsRoverChallenge.Commands
{
    public class DSLCommandFactory : IDSLCommandFactory
    {
        protected IDictionary<int, IDSLCommand> _dslCommands;

        public DSLCommandFactory()
        {
            Initialize();
        }

        protected void Initialize()
        {
            _dslCommands = new Dictionary<int, IDSLCommand>();
            _dslCommands.Add(1, new RoverCommandSequenceCommand());
            _dslCommands.Add(2, new CreatePlateauCommand());
            _dslCommands.Add(3, new CreateRoverCommand());
        }

        public IDSLCommand Create(string[] commandElements)
        {
            IDSLCommand dslCommand;
            if (!_dslCommands.TryGetValue(commandElements.Length, out dslCommand))
                dslCommand = new UnknownDSLCommand();

            return dslCommand;
        }
    }
}
