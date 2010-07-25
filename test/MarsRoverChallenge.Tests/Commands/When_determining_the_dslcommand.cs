using System;
using NUnit.Framework;
using MarsRoverChallenge.Commands;

namespace MarsRoverChallenge.Tests.Commands
{
    [TestFixture]
    public class When_determining_the_dslcommand_for_a_valid_command_with_2_elements
    {
        private IDSLCommand _dslCommand;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _dslCommand = new DSLCommandFactory().Create(new string[] { "1", "1" });
        }

        [Test]
        public void should_have_a_dslCommand_of_type_CreatePlateauCommand()
        {
            Assert.IsInstanceOfType(typeof(CreatePlateauCommand), _dslCommand);
        }
    }

    [TestFixture]
    public class When_determining_the_dslcommand_for_a_valid_command_with_3_elements
    {
        private IDSLCommand _dslCommand;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _dslCommand = new DSLCommandFactory().Create(new string[] { "1", "1", "N" });
        }

        [Test]
        public void should_have_a_dslcommand_of_type_CreateRoverCoommand()
        {
            Assert.IsInstanceOfType(typeof(CreateRoverCommand), _dslCommand);
        }
    }

    [TestFixture]
    public class When_determining_the_dslcommand_for_a_valid_command_with_1_element
    {
        private IDSLCommand _dslCommand;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _dslCommand = new DSLCommandFactory().Create(new string[] { "RLMRRMM" });
        }

        [Test]
        public void should_have_a_dslcommand_of_type_RoverCommandSequenceCommand()
        {
            Assert.IsInstanceOfType(typeof(RoverCommandSequenceCommand), _dslCommand);
        }
    }

    [TestFixture]
    public class When_determining_the_dslcommand_for_an_invalid_command_with_4_element
    {
        private IDSLCommand _dslCommand;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _dslCommand = new DSLCommandFactory().Create(new string[] { "1", "1", "N", "R" });
        }

        [Test]
        public void should_have_a_dslcommand_of_type_Unknown()
        {
            Assert.IsInstanceOfType(typeof(UnknownDSLCommand), _dslCommand);
        }
    }
}
