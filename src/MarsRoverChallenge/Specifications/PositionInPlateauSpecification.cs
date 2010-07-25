using System;

namespace MarsRoverChallenge.Specifications
{
    public class PositionInPlateauSpecification
    {
        public virtual bool IsSatisfiedBy(Position position, Plateau plateau)
        {
            return ((position.XCoordinate <= plateau.MaximumXCoordinate) &&
                (position.YCoordinate <= plateau.MaximumYCoordinate) &&
                (position.XCoordinate >= 0) &&
                (position.YCoordinate >= 0));
        }
    }
}
