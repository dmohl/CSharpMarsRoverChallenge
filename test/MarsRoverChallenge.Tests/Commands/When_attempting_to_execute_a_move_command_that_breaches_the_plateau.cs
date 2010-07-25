using System;
using NUnit.Framework;
using MarsRoverChallenge.Commands;

namespace MarsRoverChallenge.Tests.Commands
{
    [TestFixture]
    public class When_attempting_to_execute_a_move_command_that_breaches_the_north_plateau_edge
    {
        private Rover _rover;
        private bool _exceptionThrown = false;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(5, 5), "N", new Plateau(5, 5));
            try
            {
                new MoveCommand().Execute(_rover);
            }
            catch (ApplicationException)
            {
                _exceptionThrown = true;
            }                
        }

        [Test]
        public void should_have_exception_thrown()
        {
            Assert.AreEqual(true, _exceptionThrown);
        }
    }

    [TestFixture]
    public class When_attempting_to_execute_a_move_command_that_breaches_the_east_plateau_edge
    {
        private Rover _rover;
        private bool _exceptionThrown = false;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(5, 5), "E", new Plateau(5, 5));
            try
            {
                new MoveCommand().Execute(_rover);
            }
            catch (ApplicationException)
            {
                _exceptionThrown = true;
            }
        }

        [Test]
        public void should_have_exception_thrown()
        {
            Assert.AreEqual(true, _exceptionThrown);
        }
    }

    [TestFixture]
    public class When_attempting_to_execute_a_move_command_that_breaches_the_south_plateau_edge
    {
        private Rover _rover;
        private bool _exceptionThrown = false;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(0, 0), "S", new Plateau(5, 5));
            try
            {
                new MoveCommand().Execute(_rover);
            }
            catch (ApplicationException)
            {
                _exceptionThrown = true;
            }
        }

        [Test]
        public void should_have_exception_thrown()
        {
            Assert.AreEqual(true, _exceptionThrown);
        }
    }

    [TestFixture]
    public class When_attempting_to_execute_a_move_command_that_breaches_the_west_plateau_edge
    {
        private Rover _rover;
        private bool _exceptionThrown = false;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(0, 0), "W", new Plateau(5, 5));
            try
            {
                new MoveCommand().Execute(_rover);
            }
            catch (ApplicationException)
            {
                _exceptionThrown = true;
            }
        }

        [Test]
        public void should_have_exception_thrown()
        {
            Assert.AreEqual(true, _exceptionThrown);
        }
    }
}
