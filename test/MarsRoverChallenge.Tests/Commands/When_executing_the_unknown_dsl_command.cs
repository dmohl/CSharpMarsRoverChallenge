using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using MarsRoverChallenge.Commands;

namespace MarsRoverChallenge.Tests.Commands
{
    [TestFixture]
    public class When_executing_the_unknown_dsl_commandv
    {
        protected Tuple<string, Rover, Plateau> _dslCommandResult;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(new Position(3, 3), "E", plateau);
            _dslCommandResult = new UnknownDSLCommand().Execute(new string[] { "MMRMMRMRRM" }, rover, plateau);
        }

        [Test]
        public void should_have_a_response_of_blank()
        {
            Assert.AreEqual("Unknown Command", _dslCommandResult.Item1);
        }
    }
}
