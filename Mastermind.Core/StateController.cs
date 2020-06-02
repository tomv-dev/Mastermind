using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using Mastermind.Models;
using Mastermind.UI;

namespace Mastermind.Core
{
    public class StateController
    {
        private static Lazy<StateController> _instance = new Lazy<StateController>(() => new StateController());
        private Board _board;

        public static StateController Instance => _instance.Value;

        public void StartGame(GameConfig config, IInterfaceService interfaceService)
        {
            var outputService = new OutputService(interfaceService, config);

            var solution = EntryGenerator.Generate(config.NumbersInSolution, config.MaxNumber);
            _board = new Board(solution);

            outputService.WriteNewGame();

            for(var guessNumber = 1; guessNumber <= config.NumberOfGuesses; guessNumber++)
            {
                outputService.WriteGuessNumber(guessNumber);
                var userGuesses = outputService.GetGuesses();
                if (EndgameChecker.UserHasWon(userGuesses, solution))
                {
                    outputService.WriteUserWins();
                    return;
                }

                var response = userGuesses.Select((guess, i) => _board.GetResultForGuess(guess, i));
                outputService.WriteResponse(response);
            }
            outputService.WriteUserLoses();
            outputService.WriteSolution(solution);
        }

        private StateController() { }
    }
}
