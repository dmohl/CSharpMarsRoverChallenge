using System.Collections.Generic;

namespace MarsRoverChallenge.Commands
{
    public abstract class TurnCommand : RoverCommand
    {
        protected abstract int CalculateOrientationIndex(
            int currentOrientationIndex, List<string> orientations);

        public override void Execute(Rover rover)
        {
            base.Execute(rover);
            var currentOrientationIndex = 
                Constants.Orientations.FindIndex(x => x == rover.Orientation);

            var orientationIndex = CalculateOrientationIndex(
                currentOrientationIndex, Constants.Orientations);

            rover.Orientation = Constants.Orientations[orientationIndex];
        }
    }
}
