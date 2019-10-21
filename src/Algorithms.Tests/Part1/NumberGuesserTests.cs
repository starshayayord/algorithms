using System;
using System.Linq;
using NUnit.Framework;
using Part1;

namespace Algorithms.Tests.Part1
{
    [TestFixture]
    public class NumberGuesserTests
    {
        private const int Min = 0;
        private const int Count = 100;
        private static readonly Random Random = new Random();
        private readonly NumberGuesser _guesser = new NumberGuesser();

        [Test]
        public void Should_Guess_Successfully()
        {
            var array = Enumerable.Range(Min, Count).ToArray();
            var secretNumber = Random.Next(Min, Count - 1);
            var maxAttempts = Math.Ceiling(Math.Log(Count, 2));

            var guessResult = _guesser.GuessPosition(array, secretNumber);

            Assert.AreEqual(Array.IndexOf(array, secretNumber), guessResult.IndexOf);
            Assert.GreaterOrEqual(maxAttempts, guessResult.Attempts);
        }

        [Test]
        public void Should_Guess_WhenLastAttempt_Successfully()
        {
            var array = new[] {1, 2, 3, 4, 5};
            var secretNumber = 2;

            var guessResult = _guesser.GuessPosition(array, secretNumber);

            Assert.AreEqual(Array.IndexOf(array, secretNumber), guessResult.IndexOf);
            Assert.AreEqual(3, guessResult.Attempts);
        }

        [Test]
        public void ShouldNot_Guess_WhenMissingElement()
        {
            var array = new[] {1, 2, 3, 4, 5};
            var secretNumber = 6;
            var maxAttempts = Math.Ceiling(Math.Log(array.Length, 2));

            var guessResult = _guesser.GuessPosition(array, secretNumber);

            Assert.AreEqual(-1, guessResult.IndexOf);
            Assert.AreEqual(maxAttempts, guessResult.Attempts);
        }
    }
}
