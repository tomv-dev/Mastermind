using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mastermind.Core
{
    public static class EndgameChecker
    {
        public static bool UserHasWon(List<int> guesses, List<int> solution)
        {
            return guesses.SequenceEqual(solution);
        }
    }
}
