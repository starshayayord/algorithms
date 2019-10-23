using NUnit.Framework;
using Part3;

namespace Algorithms.Tests.Part3
{
    [TestFixture]
    public class FactorialTests
    {
        private readonly Factorial _factorial = new Factorial();

        [Test]
        public void Should_CalculateFactorial_Successfully()
        {
            var x = 5;

            var result = _factorial.Calculate(x);

            Assert.AreEqual(120, result);
        }

        [Test]
        public void Should_CalculateFactorial_For1()
        {
            var x = 1;

            var result = _factorial.Calculate(x);

            Assert.AreEqual(1, result);
        }
    }
}
