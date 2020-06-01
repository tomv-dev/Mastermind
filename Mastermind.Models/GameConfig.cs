using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Mastermind.Models
{
    public class GameConfig
    {
        public int NumbersInSolution { get; set; }
        public int NumberOfGuesses { get; set; }
        public int MaxNumber { get; set; }
    }
}
