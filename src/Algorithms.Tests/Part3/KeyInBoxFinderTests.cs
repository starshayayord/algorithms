using NUnit.Framework;
using Part3;
using Part3.Models;

namespace Algorithms.Tests.Part3
{
    [TestFixture]
    public class KeyInBoxFinderTests
    {
        private const string BoxWithKeyName = "33";
        private readonly KeyInBoxFinder _finder = new KeyInBoxFinder();

        [Test]
        public void Should_FindKeyWithCycle_Successfully()
        {
            var boxes = GetBoxes();

            var boxName = _finder.FindKeyCycle(boxes);

            Assert.AreEqual(BoxWithKeyName, boxName);
        }

        [Test]
        public void Should_FindKeyWithRecursive_Successfully()
        {
            var boxes = GetBoxes();

            var boxName = _finder.FindKeyRecursive(boxes);

            Assert.AreEqual(BoxWithKeyName, boxName);
        }

        [Test]
        public void Should_WorkWithCycle_WhenNoKey()
        {
            var boxes = GetBoxesWithoutKey();

            var boxName = _finder.FindKeyCycle(boxes);

            Assert.IsNull(boxName);
        }

        [Test]
        public void Should_WorkRecursive_WhenNoKey()
        {
            var boxes = GetBoxesWithoutKey();

            var boxName = _finder.FindKeyRecursive(boxes);

            Assert.IsNull(boxName);
        }


        private Box[] GetBoxes()
        {
            return new[]
            {
                new Box {Name = "0", InnerBox = new Box {Name = "00", InnerBox = new Box {Name = "000"}}},
                new Box {Name = "1", InnerBox = new Box {Name = "11"}},
                new Box {Name = "2", InnerBox = new Box {Name = "22", InnerBox = new Box {Name = "222"}}},
                new Box
                {
                    Name = "3", InnerBox = new Box {Name = BoxWithKeyName, HasKey = true, InnerBox = new Box {Name = "333"}}
                },
            };
        }

        private Box[] GetBoxesWithoutKey()
        {
            return new[]
            {
                new Box {Name = "0", InnerBox = new Box {Name = "00", InnerBox = new Box {Name = "000"}}},
                new Box {Name = "1", InnerBox = new Box {Name = "11"}},
                new Box {Name = "2", InnerBox = new Box {Name = "22", InnerBox = new Box {Name = "222"}}}
            };
        }
    }
}
