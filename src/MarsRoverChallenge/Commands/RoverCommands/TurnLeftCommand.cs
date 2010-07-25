using System.Collections.Generic;

namespace MarsRoverChallenge.Commands
{
    public class TurnLeftCommand : TurnCommand
    {
        protected override int CalculateOrientationIndex(
            int currentOrientationIndex, List<string> orientations)
        {
            var orientationIndex = currentOrientationIndex - 1;
            if (orientationIndex < 0)
                orientationIndex = orientations.Count - 1;
            return orientationIndex;
        }
    }
}
