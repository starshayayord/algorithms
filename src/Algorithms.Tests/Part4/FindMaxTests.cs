using System.Collections.Generic;
using NUnit.Framework;
using Part4;

namespace Algorithms.Tests.Part4
{
    [TestFixture]
    public class FindMaxTests
    {
        private readonly FindMax _finder = new FindMax();

        [Test]
        public void Should_FindMax_Successfully()
        {
            var list = new List<int> {3, 5, 1, 14, 2};

            var max = _finder.Find(list);

            Assert.AreEqual(14, max);
        }

        [Test]
        public void Should_FindMax_WhenOne()
        {
            var list = new List<int> {3};

            var max = _finder.Find(list);

            Assert.AreEqual(3, max);
        }

        [Test]
        public void Should_FindMax_WhenTwo()
        {
            var list = new List<int> {3, 1};

            var max = _finder.Find(list);

            Assert.AreEqual(3, max);
        }
    }
}
