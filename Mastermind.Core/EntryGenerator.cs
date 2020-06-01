using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mastermind.Core
{
    public static class EntryGenerator
    {
        public static List<int> Generate(int numEntries, int maxNum)
        {
            var random = new Random();
            return Enumerable.Range(0, numEntries).Select(i => random.Next(1, maxNum)).ToList();
        }
    }
}
