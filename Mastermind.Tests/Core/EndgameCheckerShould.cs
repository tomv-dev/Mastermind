using System;
using System.Collections.Generic;
using NUnit;
using Mastermind.Core;
using NUnit.Framework;

namespace Mastermind.Tests.Core
{
    [TestFixture]
    public class EndgameCheckerShould
    {
        [Test]
        public void TestUserHasWon3Nums()
        {
            Assert.IsTrue(EndgameChecker.UserHasWon(new List<int>() {1,2,3}, new List<int>() {1,2,3}));
        }

        [Test]
        public void TestUserHasWon10Nums()
        {
            Assert.IsTrue(EndgameChecker.UserHasWon(new List<int>() { 4, 1, 7, 3, 6, 9, 4, 6, 8, 2 }, new List<int>() { 4, 1, 7, 3, 6, 9, 4, 6, 8, 2 }));
        }

        [Test]
        public void TestUserHasLost3Nums()
        {
            Assert.IsFalse(EndgameChecker.UserHasWon(new List<int>() { 1, 2, 3 }, new List<int>() { 4, 5, 6 }));
        }

        [Test]
        public void TestUserHasLost10Nums()
        {
            Assert.IsFalse(EndgameChecker.UserHasWon(new List<int>() { 0, 1, 7, 3, 6, 9, 4, 6, 8, 2 }, new List<int>() { 4, 1, 7, 3, 6, 9, 4, 6, 8, 2 }));
        }
    }
}
