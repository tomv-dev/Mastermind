using System;
using System.Collections.Generic;
using System.Text;
using Mastermind.Models;

namespace Mastermind.Core
{
    public static class ConfigLoader
    {
        public static GameConfig LoadDefaultGameConfig()
        {
            return new GameConfig
            {
                NumbersInSolution = 4,
                NumberOfGuesses = 10,
                MaxNumber = 6
            };
        }
    }
}
