using System;
using NUnit.Framework;

namespace MarsRoverChallenge.Tests
{
    [TestFixture]
    public class When_providing_mars_rover_challenge_input
    {
        private string _output;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            var input = "5 5\r\n1 2 N\r\nLMLMLMLMM\r\n3 3 E\r\nMMRMMRMRRM";
            var commandProcessorResult = new CommandProcessor().Process(input, null, null);
            _output = commandProcessorResult.Item1;
        }

        [Test]
        public void should_have_an_output_of_1_3_N__5_1_E()
        {
            Assert.AreEqual("1 3 N\r\n5 1 E\r\n", _output);
        }
    }
}
