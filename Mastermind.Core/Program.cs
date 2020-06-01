using System;
using Mastermind.UI;

namespace Mastermind.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigLoader.LoadDefaultGameConfig();
            var consoleService = new ConsoleService();

            StateController.Instance.StartGame(config, consoleService);
            consoleService.Read();
        }
    }
}
