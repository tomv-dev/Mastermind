using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Mastermind.Core;
using Mastermind.Models;

namespace Mastermind.Tests.Models
{
    [TestFixture]
    public class BoardShould
    {
        private static readonly List<int> _solution = new List<int> { 1, 2, 3, 4 };
        private Board _target;

        [SetUp]
        public void Setup()
        {
            _target = new Board(_solution);
        }
        [Test]
        public void GetResultForGuessHitPositionOne()
        {
            Assert.AreEqual(_target.GetResultForGuess(1, 0), GuessResponse.RightPosition);
        }
        [Test]
        public void GetResultForGuessMissPositionOne()
        {
            Assert.AreEqual(_target.GetResultForGuess(5, 2), GuessResponse.NotInSolution);
        }
        [Test]
        public void GetResultForGuessWrongPositionPositionOne()
        {
            Assert.AreEqual(_target.GetResultForGuess(4, 0), GuessResponse.WrongPosition);
        }

    }
}
