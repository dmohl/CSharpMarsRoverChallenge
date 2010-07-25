using System;
using NUnit.Framework;
using MarsRoverChallenge.Commands;

namespace MarsRoverChallenge.Tests.Commands
{
    [TestFixture]
    public class When_executing_the_turn_left_command_with_a_current_orientation_of_N
    {
        private Rover _rover;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(1, 2), "N", new Plateau(5, 5));
            new TurnLeftCommand().Execute(_rover);
        }

        [Test]
        public void should_have_an_orientation_of_W_for_the_rover()
        {
            Assert.AreEqual("W", _rover.Orientation);
        }
    }

    [TestFixture]
    public class When_executing_the_turn_left_command_with_a_current_orientation_of_E
    {
        private Rover _rover;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(1, 2), "E", new Plateau(5, 5));
            new TurnLeftCommand().Execute(_rover);
        }

        [Test]
        public void should_have_an_orientation_of_N_for_the_rover()
        {
            Assert.AreEqual("N", _rover.Orientation);
        }
    }

    [TestFixture]
    public class When_executing_the_turn_left_command_with_a_current_orientation_of_S
    {
        private Rover _rover;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(1, 2), "S", new Plateau(5, 5));
            new TurnLeftCommand().Execute(_rover);
        }

        [Test]
        public void should_have_an_orientation_of_E_for_the_rover()
        {
            Assert.AreEqual("E", _rover.Orientation);
        }
    }

    [TestFixture]
    public class When_executing_the_turn_left_command_with_a_current_orientation_of_W
    {
        private Rover _rover;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(1, 2), "W", new Plateau(5, 5));
            new TurnLeftCommand().Execute(_rover);
        }

        [Test]
        public void should_have_an_orientation_of_S_for_the_rover()
        {
            Assert.AreEqual("S", _rover.Orientation);
        }
    }

    [TestFixture]
    public class When_executing_the_turn_left_command_with_null_provided_as_the_rover_input
    {
        private bool _exceptionThrown = false;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            try
            {
                new TurnLeftCommand().Execute(null);
            }
            catch (ApplicationException)
            {
                _exceptionThrown = true;
            }
        }

        [Test]
        public void should_have_an_orientation_of_W_for_the_rover()
        {
            Assert.AreEqual(true, _exceptionThrown);
        }
    }
}
