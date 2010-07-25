using System;

namespace MarsRoverChallenge
{
    public class Position
    {
        public Position(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Position))
                return false;

            var position = (Position)obj;
            return ((this.XCoordinate == position.XCoordinate)
                && (this.YCoordinate == position.YCoordinate));
        }

        public override int GetHashCode()
        {
            var stringToHash = string.Format("{0}:{1}", XCoordinate.ToString(), 
                YCoordinate.ToString());
            return stringToHash.GetHashCode();
        }
    }
}
