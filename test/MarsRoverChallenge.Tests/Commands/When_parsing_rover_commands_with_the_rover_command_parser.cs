using System;
using System.Collections.Generic;
using MarsRoverChallenge.Commands;
using NUnit.Framework;

namespace MarsRoverChallenge.Tests
{
    [TestFixture]
    public class When_parsing_rover_commands_with_the_rover_command_parser
    {
        private IList<IRoverCommand> _roverCommands;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _roverCommands = new RoverCommandParser().Parse(new string[]{"MMRRLL"});
        }

        [Test]
        public void should_have_six_commands_in_the_rover_commands_list()
        {
            Assert.AreEqual(6, _roverCommands.Count);
        }
    }

    [TestFixture]
    public class When_parsing_invalid_rover_commands_with_the_rover_command_parser
    {
        private bool _exceptionThrown = false;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            try
            {
                new RoverCommandParser().Parse(new string[]{"MMRTRL"});
            }
            catch (ApplicationException)
            {
                _exceptionThrown = true;
            }
        }

        [Test]
        public void should_have_had_an_exception_thrown()
        {
            Assert.IsTrue(_exceptionThrown);
        }
    }
}
