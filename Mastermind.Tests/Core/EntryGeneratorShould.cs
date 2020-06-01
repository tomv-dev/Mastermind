using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Mastermind.Core;

namespace Mastermind.Tests.Core
{
    [TestFixture]
    public class EntryGeneratorShould
    {
        [Test]
        public void TestGenerate35()
        {
            const int targetNumEntries = 3;
            const int targetMaxNum = 5;

            var generated = EntryGenerator.Generate(targetNumEntries, targetMaxNum);
            Assert.That(generated.Count == targetNumEntries);
            
            generated.ForEach(x => Assert.That(x <= 5));
        }

    }
}
