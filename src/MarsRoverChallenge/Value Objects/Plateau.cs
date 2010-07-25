using System;
using System.Collections.Generic;

namespace MarsRoverChallenge
{
    public class Plateau
    {
        public int MaximumXCoordinate { get; protected set; }
        public int MaximumYCoordinate { get; protected set; }

        public Plateau(int maximumXCoordinate, int maximumYCoordinate)
        {
            MaximumXCoordinate = maximumXCoordinate;
            MaximumYCoordinate = maximumYCoordinate;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Plateau))
                return false;

            var plateau = (Plateau)obj;
            return ((this.MaximumXCoordinate == plateau.MaximumXCoordinate)
                && (this.MaximumYCoordinate == plateau.MaximumYCoordinate));
        }

        public override int GetHashCode()
        {
            var stringToHash = string.Format("{0}:{1}", MaximumXCoordinate.ToString(),
                MaximumYCoordinate.ToString());
            return stringToHash.GetHashCode();
        }
    }
}
