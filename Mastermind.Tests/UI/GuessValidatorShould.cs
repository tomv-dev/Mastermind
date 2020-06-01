using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Mastermind.UI;
namespace Mastermind.Tests.UI
{
    [TestFixture]
    public class GuessValidatorShould
    {
        [Test]
        public void IsInvalidStringLetters()
        {
            var response = GuessValidator.IsValidEntryString("123B", 4, 5);
            Assert.IsFalse(response);

        }

        [Test]
        public void IsInvalidStringTooManyNums()
        {
            var response = GuessValidator.IsValidEntryString("1234567", 5, 9);
            Assert.IsFalse(response);

        }

        [Test]
        public void IsInvalidStringNumberOverHighest()
        {
            var response = GuessValidator.IsValidEntryString("1235", 4, 4);
            Assert.IsFalse(response);

        }

        [Test]
        public void IsValidString()
        {
            var response = GuessValidator.IsValidEntryString("1235", 4, 5);
            Assert.IsTrue(response);

        }
    }
}
