using System;
using System.Collections.ObjectModel;
using MarsRoverChallenge.Commands;

namespace MarsRoverChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            var commandProcessor = new CommandProcessor();
            Plateau currentPlateau = null;
            Rover currentRover = null;

            while (input.ToUpper() != "Q")
            {
                Console.WriteLine(":>");
                input = Console.ReadLine();
                var commandResult = 
                    commandProcessor.Process(input, currentRover, currentPlateau);
                var response = commandResult.Item1;
                currentRover = commandResult.Item2;
                currentPlateau = commandResult.Item3;

                Console.WriteLine("{0}\r\n", response);
            }
        }
    }
}
