using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Mastermind.Core;

namespace Mastermind.Models
{
    public class Board
    {
        private readonly EntryValidationService _entryValidationService;

        public Board(List<int> entries)
        {
            _entryValidationService = new EntryValidationService(entries);
        }

        public GuessResponse GetResultForGuess(int guess, int position)
        {
            if (_entryValidationService.HasEntryAtPosition(guess, position))
            {
                return GuessResponse.RightPosition;
            }

            return _entryValidationService.HasEntryWrongPosition(guess, position) ? GuessResponse.WrongPosition : GuessResponse.NotInSolution;
        }
    } 
}
