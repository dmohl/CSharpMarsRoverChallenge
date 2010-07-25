using System;
using MarsRoverChallenge.Specifications;
using NUnit.Framework;

namespace MarsRoverChallenge.Tests.Specifications
{
    [TestFixture]
    public class When_checking_for_valid_satisfaction_of_the_position_in_plateau_specification
    {
        protected PositionInPlateauSpecification _specification;
        protected Position _position;
        protected Plateau _plateau;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _specification = new PositionInPlateauSpecification();
            _position = new Position(1, 1);
            _plateau = new Plateau(5, 5);
        }

        [Test]
        public void should_be_satisfied()
        {
            Assert.IsTrue(_specification.IsSatisfiedBy(_position, _plateau));
        }
    }

    [TestFixture]
    public class When_checking_for_valid_satisfaction_of_the_position_in_plateau_specification_on_the_high_fringe
    {
        protected PositionInPlateauSpecification _specification;
        protected Position _position;
        protected Plateau _plateau;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _specification = new PositionInPlateauSpecification();
            _position = new Position(5, 5);
            _plateau = new Plateau(5, 5);
        }

        [Test]
        public void should_be_satisfied()
        {
            Assert.IsTrue(_specification.IsSatisfiedBy(_position, _plateau));
        }
    }

    [TestFixture]
    public class When_checking_for_valid_satisfaction_of_the_position_in_plateau_specification_on_the_low_fringe
    {
        protected PositionInPlateauSpecification _specification;
        protected Position _position;
        protected Plateau _plateau;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _specification = new PositionInPlateauSpecification();
            _position = new Position(0, 0);
            _plateau = new Plateau(5, 5);
        }

        [Test]
        public void should_be_satisfied()
        {
            Assert.IsTrue(_specification.IsSatisfiedBy(_position, _plateau));
        }
    }

    [TestFixture]
    public class When_checking_for_invalid_satisfaction_of_the_position_in_plateau_specification_due_to_the_high_X_Coordinate
    {
        protected PositionInPlateauSpecification _specification;
        protected Position _position;
        protected Plateau _plateau;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _specification = new PositionInPlateauSpecification();
            _position = new Position(6, 5);
            _plateau = new Plateau(5, 5);
        }

        [Test]
        public void should_not_be_satisfied()
        {
            Assert.IsFalse(_specification.IsSatisfiedBy(_position, _plateau));
        }
    }

    [TestFixture]
    public class When_checking_for_invalid_satisfaction_of_the_position_in_plateau_specification_due_to_the_high_Y_Coordinate
    {
        protected PositionInPlateauSpecification _specification;
        protected Position _position;
        protected Plateau _plateau;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _specification = new PositionInPlateauSpecification();
            _position = new Position(5, 6);
            _plateau = new Plateau(5, 5);
        }

        [Test]
        public void should_not_be_satisfied()
        {
            Assert.IsFalse(_specification.IsSatisfiedBy(_position, _plateau));
        }
    }

    [TestFixture]
    public class When_checking_for_invalid_satisfaction_of_the_position_in_plateau_specification_due_to_the_low_X_Coordinate
    {
        protected PositionInPlateauSpecification _specification;
        protected Position _position;
        protected Plateau _plateau;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _specification = new PositionInPlateauSpecification();
            _position = new Position(-1, 5);
            _plateau = new Plateau(5, 5);
        }

        [Test]
        public void should_not_be_satisfied()
        {
            Assert.IsFalse(_specification.IsSatisfiedBy(_position, _plateau));
        }
    }

    [TestFixture]
    public class When_checking_for_invalid_satisfaction_of_the_position_in_plateau_specification_due_to_the_low_Y_Coordinate
    {
        protected PositionInPlateauSpecification _specification;
        protected Position _position;
        protected Plateau _plateau;

        [TestFixtureSetUp]
        public void BecauseOf()
        {
            _specification = new PositionInPlateauSpecification();
            _position = new Position(5, -1);
            _plateau = new Plateau(5, 5);
        }

        [Test]
        public void should_not_be_satisfied()
        {
            Assert.IsFalse(_specification.IsSatisfiedBy(_position, _plateau));
        }
    }
}
