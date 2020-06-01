using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind.UI
{
    public class ConsoleService : IInterfaceService
    {
        public string Read()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
