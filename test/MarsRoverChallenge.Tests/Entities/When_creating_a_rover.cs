using NUnit.Framework;
using System;

namespace MarsRoverChallenge.Tests
{
    [TestFixture]
    public class When_creating_a_valid_rover
    {
        private Rover _rover;
        private Position _currentPosition;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _currentPosition = new Position(1, 2);
            _rover = new Rover(_currentPosition, "N", new Plateau(5,5));
        }

        [Test]
        public void should_have_a_current_position_of_x1_y2()
        {
            Assert.AreEqual(_currentPosition, _rover.CurrentPosition);
        }

        [Test]
        public void should_have_an_orientation_of_N()
        {
            Assert.AreEqual("N", _rover.Orientation);
        }
    }

    [TestFixture]
    public class When_creating_a_rover_with_an_invalid_orientation
    {
        private Rover _rover;
        private Position _currentPosition;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _currentPosition = new Position(1, 2);
            _rover = new Rover(_currentPosition, "N", new Plateau(5, 5));
        }

        [Test]
        public void should_have_a_current_position_of_x1_y2()
        {
            Assert.AreEqual(_currentPosition, _rover.CurrentPosition);
        }

        [Test]
        public void should_have_an_orientation_of_N()
        {
            Assert.AreEqual("N", _rover.Orientation);
        }
    }

    [TestFixture]
    public class When_creating_a_rover_with_a_null_plateau
    {
        private bool _exceptionThrown = false;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            try
            {
                new Rover(new Position(1, 2), "N", null);
            }
            catch (ApplicationException)
            {
                _exceptionThrown = true;            
            }
        }

        [Test]
        public void should_have_thrown_an_exception()
        {
            Assert.AreEqual(true, _exceptionThrown);
        }
    }

    [TestFixture]
    public class When_creating_a_rover_with_a_null_position
    {
        private bool _exceptionThrown = false;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            try
            {
                new Rover(null, "N", new Plateau(5,5));
            }
            catch (ApplicationException)
            {
                _exceptionThrown = true;            
            }
        }

        [Test]
        public void should_have_thrown_an_exception()
        {
            Assert.AreEqual(true, _exceptionThrown);
        }
    }
}
