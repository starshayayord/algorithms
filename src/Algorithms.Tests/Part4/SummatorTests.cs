using NUnit.Framework;
using Part4;

namespace Algorithms.Tests.Part4
{
    [TestFixture]
    public class SummatorTests
    {
        private readonly Summator _summator = new Summator();

        [Test]
        public void Should_SumDigit_Successfully()
        {
            var x = 264;

            var sum = _summator.Sum(x);

            Assert.AreEqual(12, sum);
        }

        [Test]
        public void Should_SumDigit_WhenOneDigit()
        {
            var x = 2;

            var sum = _summator.Sum(x);

            Assert.AreEqual(2, sum);
        }

        [Test]
        public void Should_SumDigit_WhenZero()
        {
            var x = 0;

            var sum = _summator.Sum(x);

            Assert.AreEqual(0, sum);
        }
    }
}
