using System;
using MarsRoverChallenge.Commands;
using NUnit.Framework;

namespace MarsRoverChallenge.Tests
{
    [TestFixture]
    public class When_providing_multi_line_input_to_the_command_process
    {
        private Tuple<string, Rover, Plateau> _commandProcessorResult;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            var input = "5 5\r\n1 1 N";
            _commandProcessorResult = new CommandProcessor().Process(input, null, null);
        }

        [Test]
        public void should_have_a_response_text_of_blank()
        {
            Assert.AreEqual("", _commandProcessorResult.Item1);
        }

        [Test]
        public void should_have_a_rover_with_a_plateau_of_x5_y5()
        {
            Assert.AreEqual(new Plateau(5, 5), _commandProcessorResult.Item2.CurrentPlateau);
        }

        [Test]
        public void should_have_a_rover_with_a_position_of_x1_y1()
        {
            Assert.AreEqual(new Position(1, 1), _commandProcessorResult.Item2.CurrentPosition);
        }

        [Test]
        public void should_have_a_rover_with_an_orientation_of_N()
        {
            Assert.AreEqual("N", _commandProcessorResult.Item2.Orientation);
        }

        [Test]
        public void should_have_a_plateau_with_x5_and_y5()
        {
            Assert.AreEqual(new Plateau(5, 5), _commandProcessorResult.Item3);
        }
    }

    [TestFixture]
    public class When_providing_multi_line_input_to_the_command_process_to_command_a_rover_with_rover_command_LMLMLMLMM
    {
        private Tuple<string, Rover, Plateau> _commandProcessorResult;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            var input = "5 5\r\n1 2 N\r\nLMLMLMLMM";
            _commandProcessorResult = new CommandProcessor().Process(input, null, null);
        }

        [Test]
        public void should_have_a_response_text_of_1_3_N()
        {
            Assert.AreEqual("1 3 N\r\n", _commandProcessorResult.Item1);
        }

        [Test]
        public void should_have_a_rover_with_a_plateau_of_x5_y5()
        {
            Assert.AreEqual(new Plateau(5, 5), _commandProcessorResult.Item2.CurrentPlateau);
        }

        [Test]
        public void should_have_a_rover_with_a_position_of_x1_y3()
        {
            Assert.AreEqual(new Position(1, 3), _commandProcessorResult.Item2.CurrentPosition);
        }

        [Test]
        public void should_have_a_rover_with_an_orientation_of_N()
        {
            Assert.AreEqual("N", _commandProcessorResult.Item2.Orientation);
        }

        [Test]
        public void should_have_a_plateau_with_x5_and_y5()
        {
            Assert.AreEqual(new Plateau(5, 5), _commandProcessorResult.Item3);
        }
    }

    [TestFixture]
    public class When_providing_multi_line_input_to_the_command_process_to_command_a_rover_with_rover_command_MMRMMRMRRM
    {
        private Tuple<string, Rover, Plateau> _commandProcessorResult;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            var input = "5 5\r\n3 3 E\r\nMMRMMRMRRM";
            _commandProcessorResult = new CommandProcessor().Process(input, null, null);
        }

        [Test]
        public void should_have_a_response_text_of_5_1_E()
        {
            Assert.AreEqual("5 1 E\r\n", _commandProcessorResult.Item1);
        }

        [Test]
        public void should_have_a_rover_with_a_plateau_of_x5_y5()
        {
            Assert.AreEqual(new Plateau(5, 5), _commandProcessorResult.Item2.CurrentPlateau);
        }

        [Test]
        public void should_have_a_rover_with_a_position_of_x5_y1()
        {
            Assert.AreEqual(new Position(5, 1), _commandProcessorResult.Item2.CurrentPosition);
        }

        [Test]
        public void should_have_a_rover_with_an_orientation_of_E()
        {
            Assert.AreEqual("E", _commandProcessorResult.Item2.Orientation);
        }

        [Test]
        public void should_have_a_plateau_with_x5_and_y5()
        {
            Assert.AreEqual(new Plateau(5, 5), _commandProcessorResult.Item3);
        }
    }
}
