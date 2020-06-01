using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind.Core
{
    public class EntryValidationService
    {
        private readonly List<int> _solution;
        public EntryValidationService(List<int> solution)
        {
            _solution = solution;
        }
        public bool HasEntryWrongPosition(int guess, int guessIndex)
        {
            return _solution.Contains(guess) && !HasEntryAtPosition(guess, guessIndex);
        }

        public bool HasEntryAtPosition(int guess, int guessIndex)
        {
            return _solution[guessIndex] == guess;
        }
    }
}
