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
        internal static string CorrectPosition = "+";
        internal static string WrongPosition = "-";

        internal static string WriteGuessNumber(int guessNumber)
        {
            return $"Turn {guessNumber}: ";
        }

        internal static string PromptForGuesses(int numEntries, int maxNumbers)
        {
            return $"Please enter {numEntries} numbers between 1 and {maxNumbers}.";
        }

        internal static string WriteSolution(List<int> entries)
        {
            return $"Correct solution was {string.Join(" ", entries)}";
        }
    }
}
