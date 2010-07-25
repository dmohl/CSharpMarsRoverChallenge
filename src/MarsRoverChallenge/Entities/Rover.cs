using System;
using MarsRoverChallenge.Specifications;

namespace MarsRoverChallenge
{
    public class Rover
    {
        protected readonly PositionInPlateauSpecification _positionInPlateauSpecification;
        protected string _orientation;
        protected Position _currentPosition;
        protected Plateau _currentPlateau;

        public Rover(Position position, string orientation, Plateau plateau)
        {
            _positionInPlateauSpecification = new PositionInPlateauSpecification();
            CurrentPlateau = plateau;
            CurrentPosition = position;
            Orientation = orientation;
        }

        public Position CurrentPosition
        {
            get
            {
                return _currentPosition;
            }
            set 
            { 
                if (value == null)
                    throw new ApplicationException(
                        "Invalid Rover Position. The rover position information was not supplied.");

                if (!_positionInPlateauSpecification.IsSatisfiedBy(value, CurrentPlateau))
                    throw new ApplicationException(
                        "Invalid Rover Position. This command would cause the rover to breach the plateau.");

                _currentPosition = value;
            }
        }

        public string Orientation
        {
            get { return _orientation; }
            set
            {
                if (String.IsNullOrEmpty(value) || !Constants.Orientations.Contains(value))
                    throw new ApplicationException(
                        "Invalid Rover Orientation. This command would cause the rover orientation to be set to an invalid value.");
                
                _orientation = value;
            }
        }

        public Plateau CurrentPlateau
        {
            get 
            { 
                return _currentPlateau; 
            }
            protected set
            {
                if (value == null)
                    throw new ApplicationException(
                        "Invalid Rover Plateau. The plateau information was not provided to the rover.");

                _currentPlateau = value;
            }
        }
    }
}
