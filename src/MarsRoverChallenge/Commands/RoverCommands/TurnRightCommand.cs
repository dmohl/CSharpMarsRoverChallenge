using System.Collections.Generic;

namespace MarsRoverChallenge.Commands
{
    public class TurnRightCommand : TurnCommand
    {
        protected override int CalculateOrientationIndex(
            int currentOrientationIndex, List<string> orientations)
        {
            var orientationIndex = currentOrientationIndex + 1;
            if (orientationIndex > orientations.Count - 1)
                orientationIndex = 0;
            return orientationIndex;
        }
    }
}
