using NUnit.Framework;
using MarsRoverChallenge.Commands;

namespace MarsRoverChallenge.Tests.Commands
{
    [TestFixture]
    public class When_executing_the_move_command_and_the_rover_is_oriented_North
    {
        private Rover _rover;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(1, 1), "N", new Plateau(5,5));
            new MoveCommand().Execute(_rover);
        }

        [Test]
        public void should_have_a_position_y_coordinate_of_2()
        {
            Assert.AreEqual(2, _rover.CurrentPosition.YCoordinate);
        }

        [Test]
        public void should_have_a_position_x_coordinate_of_1()
        {
            Assert.AreEqual(1, _rover.CurrentPosition.XCoordinate);
        }
    }

    [TestFixture]
    public class When_executing_the_move_command_and_the_rover_is_oriented_East
    {
        private Rover _rover;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(1, 1), "E", new Plateau(5, 5));
            new MoveCommand().Execute(_rover);
        }

        [Test]
        public void should_have_a_position_y_coordinate_of_1()
        {
            Assert.AreEqual(1, _rover.CurrentPosition.YCoordinate);
        }

        [Test]
        public void should_have_a_position_x_coordinate_of_2()
        {
            Assert.AreEqual(2, _rover.CurrentPosition.XCoordinate);
        }
    }

    [TestFixture]
    public class When_executing_the_move_command_and_the_rover_is_oriented_South
    {
        private Rover _rover;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(1, 1), "S", new Plateau(5, 5));
            new MoveCommand().Execute(_rover);
        }

        [Test]
        public void should_have_a_position_y_coordinate_of_0()
        {
            Assert.AreEqual(0, _rover.CurrentPosition.YCoordinate);
        }

        [Test]
        public void should_have_a_position_x_coordinate_of_1()
        {
            Assert.AreEqual(1, _rover.CurrentPosition.XCoordinate);
        }
    }

    [TestFixture]
    public class When_executing_the_move_command_and_the_rover_is_oriented_West
    {
        private Rover _rover;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _rover = new Rover(new Position(1, 1), "W", new Plateau(5, 5));
            new MoveCommand().Execute(_rover);
        }

        [Test]
        public void should_have_a_position_y_coordinate_of_1()
        {
            Assert.AreEqual(1, _rover.CurrentPosition.YCoordinate);
        }

        [Test]
        public void should_have_a_position_x_coordinate_of_0()
        {
            Assert.AreEqual(0, _rover.CurrentPosition.XCoordinate);
        }
    }
}
