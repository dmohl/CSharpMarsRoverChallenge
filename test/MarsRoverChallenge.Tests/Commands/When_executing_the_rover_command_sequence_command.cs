using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using MarsRoverChallenge.Commands;

namespace MarsRoverChallenge.Tests.Commands
{
    [TestFixture]
    public class When_executing_the_rover_command_sequence_command
    {
        protected Tuple<string, Rover, Plateau> _dslCommandResult;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(new Position(3, 3), "E", plateau);
            _dslCommandResult = new RoverCommandSequenceCommand().Execute(new string[] { "MMRMMRMRRM" }, rover, plateau);
        }

        [Test]
        public void should_have_a_response_of_5_1_E()
        {
            Assert.AreEqual("5 1 E", _dslCommandResult.Item1);
        }
    }
}
