using NUnit.Framework;

namespace MarsRoverChallenge.Tests
{
    [TestFixture]
    public class When_creating_a_plateau 
    {
        private Plateau _plateau;
        
        [TestFixtureSetUp]
        protected void BecauseOf()
        {
            _plateau = new Plateau(4, 6);
        }

        [Test]
        public void should_have_a_maximum_x_coordinate_of_4()
        {
            Assert.AreEqual(4, _plateau.MaximumXCoordinate);
        }

        [Test]
        public void should_have_a_maximum_y_coordinate_of_6()
        {
            Assert.AreEqual(6, _plateau.MaximumYCoordinate);
        }
    }
}
