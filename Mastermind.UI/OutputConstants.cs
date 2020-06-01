using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Mastermind.UI
{
    internal static class OutputConstants
    {
        internal static string NewGame = "Welcome to Mastermind!";
        internal static string UserWins = "You Win!";
        internal static string UserLoses = "You Lose!";

        internal static string PromptForGuesses(int numEntries, int maxNumbers)
        {
            return $"Please enter {numEntries} numbers between 1 and {maxNumbers}.";
        }

        internal static string WriteResponse(int numCorrect, int numWrongPosition, int numIncorrect)
        {
            return $"{numCorrect} correct | {numWrongPosition} in wrong position | {numIncorrect} wrong";
        }

        internal static string WriteSolution(List<int> entries)
        {
            return $"Correct solution was {string.Join(" ", entries)}";
        }
    }
}
