using System.Collections.Generic;
using NUnit.Framework;
using MarsRoverChallenge.Commands;

namespace MarsRoverChallenge.Tests.Commands
{
    [TestFixture]
    public class When_building_the_rover_command_collection
    {
        private IRoverCommandCollectionBuilder _builder;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _builder = new RoverCommandCollectionBuilder();
        }

        [Test]
        public void should_have_3_items_in_the_resulting_collection()
        {
            Assert.AreEqual(3, _builder.Build().Count);
        }
    }
}
