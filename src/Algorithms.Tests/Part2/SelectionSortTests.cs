using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Part2;

namespace Algorithms.Tests.Part2
{
    [TestFixture]
    public class SelectionSortTests
    {
        [Test]
        public void Should_SortArray_Successfully()
        {
            var array = new[] {5, 3, 6, 2, 10};

            var sortedArray = SelectionSort<int>.Sort(array).ToArray();

            CollectionAssert.AreEqual(array.OrderBy(x => x).ToArray(), sortedArray);
        }

        [Test]
        public void Should_SortList_Successfully()
        {
            var list = new List<int> {5, 3, 6, 2, 10};

            var sortedList = SelectionSort<int>.Sort(list).ToList();

            CollectionAssert.AreEqual(list.OrderBy(x => x).ToList(), sortedList);
        }
    }
}
