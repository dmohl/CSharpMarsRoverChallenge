using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MarsRoverChallenge.Commands;
using System.Text;
using System.Text.RegularExpressions;

namespace MarsRoverChallenge
{
    public class CommandProcessor
    {
        protected readonly IDSLCommandFactory _dslCommandFactory;

        public CommandProcessor() : this(new DSLCommandFactory()) { }

        public CommandProcessor(IDSLCommandFactory dslCommandFactory)
        {
            _dslCommandFactory = dslCommandFactory;
        }

        public Tuple<string, Rover, Plateau> Process(string input, 
            Rover currentRover, Plateau currentPlateau)
        {
            var rover = currentRover;
            var plateau = currentPlateau;
            var responseMessage = new StringBuilder();
            var commands = Regex.Split(input, "\r\n");
            foreach (var command in commands)
            {
                var commandElements = command.Split(' ');
                var dslCommand = _dslCommandFactory.Create(commandElements);

                try
                {
                    var dslCommandResponse = 
                        dslCommand.Execute(commandElements, rover, plateau);
                    
                    if (!String.IsNullOrEmpty(dslCommandResponse.Item1))
                        responseMessage.AppendLine(dslCommandResponse.Item1);
                    
                    rover = dslCommandResponse.Item2;
                    plateau = dslCommandResponse.Item3;
                }
                catch (Exception ex)
                {
                    responseMessage.AppendLine(ex.Message);
                }
            }

            return new Tuple<string, Rover, Plateau>(responseMessage.ToString(), rover, plateau);
        }
    }
}
