using System.Collections.Generic;
using NUnit.Framework;
using Part4;

namespace Algorithms.Tests.Part4
{
    [TestFixture]
    public class RecursiveCountTests
    {
        private readonly RecursiveCount _recursiveCount = new RecursiveCount();

        [Test]
        public void Should_Count_Successfully()
        {
            var list = new List<int> {1, 2, 34};

            var count = _recursiveCount.Count(list);

            Assert.AreEqual(3, count);
        }

        [Test]
        public void Should_Count_WhenEmpty()
        {
            var list = new List<int>();

            var count = _recursiveCount.Count(list);

            Assert.AreEqual(0, count);
        }
    }
}
