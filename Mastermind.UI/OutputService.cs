using Mastermind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mastermind.UI
{
    public class OutputService
    {
        private readonly IInterfaceService _interfaceService;
        private readonly GameConfig _config;
        public OutputService(IInterfaceService interfaceService, GameConfig config)
        {
            _interfaceService = interfaceService;
            _config = config;
        }

        public void WriteResponse(IEnumerable<GuessResponse> response)
        {
            var guessResponses = response.ToList();
            var numCorrect = guessResponses.Count(x => x == GuessResponse.RightPosition);
            var numIncluded = guessResponses.Count(x => x == GuessResponse.WrongPosition);

            WriteNumCorrect(numCorrect);
            WriteNumIncluded(numIncluded);
            _interfaceService.WriteLine(string.Empty);
            _interfaceService.WriteLine(string.Empty);
        }

        public void WriteUserWins()
        {
            _interfaceService.WriteLine(OutputConstants.UserWins);
        }

        public void WriteNumCorrect(int numCorrect)
        {
            Enumerable.Range(0, numCorrect).ToList().ForEach(x => _interfaceService.Write(OutputConstants.CorrectPosition));
        }

        public void WriteNumIncluded(int numIncluded)
        {
            Enumerable.Range(0, numIncluded).ToList().ForEach(x => _interfaceService.Write(OutputConstants.WrongPosition));
        }

        public void WriteUserLoses()
        {
            _interfaceService.WriteLine(OutputConstants.UserLoses);
        }

        public void WriteSolution(List<int> entries)
        {
            _interfaceService.WriteLine(OutputConstants.WriteSolution(entries));
        }

        public void WriteGuessNumber(int guessNumber)
        {
            _interfaceService.Write(OutputConstants.WriteGuessNumber(guessNumber));
        }

        public List<int> GetGuesses()
        {
            string input = null;
            while(!GuessValidator.IsValidEntryString(input, _config.NumbersInSolution, _config.MaxNumber))
            {
                _interfaceService.WriteLine(OutputConstants.PromptForGuesses(_config.NumbersInSolution, _config.MaxNumber));
                input = _interfaceService.Read();
            }

            return input.Select(n => Convert.ToInt32(char.GetNumericValue(n))).ToList();
        }

        public void WriteNewGame()
        {
            _interfaceService.WriteLine(OutputConstants.NewGame);
            _interfaceService.WriteLine(string.Empty);
        }
    }
}
