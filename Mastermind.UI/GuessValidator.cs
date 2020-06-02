using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mastermind.Models;

namespace Mastermind.UI
{
    public static class GuessValidator
    {
        public static bool IsValidEntryString(string input, int numEntries, int maxNum)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            return input.Length == numEntries && input.All(x => char.IsDigit(x) && char.GetNumericValue(x) <= maxNum);
        }
    }
}
