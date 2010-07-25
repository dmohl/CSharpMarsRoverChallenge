using System;
using System.Collections.Generic;

namespace MarsRoverChallenge.Commands
{
    public interface IRoverCommandCollectionBuilder
    {
        IDictionary<string, IRoverCommand> Build();
    }
}
