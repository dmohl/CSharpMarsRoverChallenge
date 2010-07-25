using System;
using System.Collections.ObjectModel;
using MarsRoverChallenge.Commands;
using NUnit.Framework;

namespace MarsRoverChallenge.Tests
{
    [TestFixture]
    public class When_executing_the_create_rover_dsl_command
    {
        protected Tuple<string, Rover, Plateau> _dslCommandResult;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            var plateau = new Plateau(5, 5);
            _dslCommandResult = new CreateRoverCommand().Execute(new string[] { "1", "1", "N" }, null, plateau);
        }

        [Test]
        public void should_have_a_response_of_blank()
        {
            Assert.AreEqual("", _dslCommandResult.Item1);
        }

        [Test]
        public void should_have_non_null_rover()
        {
            Assert.IsNotNull(_dslCommandResult.Item2);
        }

        [Test]
        public void should_have_a_plateau_with_x5_y5()
        {
            Assert.AreEqual(new Plateau(5, 5), _dslCommandResult.Item3);
        }
    }

    [TestFixture]
    public class When_executing_the_create_rover_dsl_command_with_invalid_input_for_the_first_value
    {
        protected bool _exceptionThrown = false;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            try
            {
                var plateau = new Plateau(5, 5);
                new CreateRoverCommand().Execute(new string[] { "N", "5", "N" }, null, plateau);
            }
            catch (ApplicationException)
            {
                _exceptionThrown = true;
            }
        }

        [Test]
        public void should_have_thrown_an_exception()
        {
            Assert.IsTrue(_exceptionThrown);
        }
    }

    [TestFixture]
    public class When_executing_the_create_rover_dsl_command_with_invalid_input_for_the_second_value
    {
        protected bool _exceptionThrown = false;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            try
            {
                var plateau = new Plateau(5, 5);
                new CreateRoverCommand().Execute(new string[] { "5", "N", "N" }, null, plateau);
            }
            catch (ApplicationException)
            {
                _exceptionThrown = true;
            }
        }

        [Test]
        public void should_have_thrown_an_exception()
        {
            Assert.IsTrue(_exceptionThrown);
        }
    }

    [TestFixture]
    public class When_executing_the_create_rover_dsl_command_with_invalid_input_for_the_third_value
    {
        protected bool _exceptionThrown = false;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            try
            {
                var plateau = new Plateau(5, 5);
                new CreateRoverCommand().Execute(new string[] { "5", "5", "5" }, null, plateau);
            }
            catch (ApplicationException)
            {
                _exceptionThrown = true;
            }
        }

        [Test]
        public void should_have_thrown_an_exception()
        {
            Assert.IsTrue(_exceptionThrown);
        }
    }
}
