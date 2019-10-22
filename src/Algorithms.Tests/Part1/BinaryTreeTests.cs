using NUnit.Framework;
using Part1;

namespace Algorithms.Tests.Part1
{
    [TestFixture]
    public class BinaryTreeTests
    {
        [Test]
        public void Should_AddToBinaryTree_Successfully()
        {
            var tree = new BinaryTrees.BinaryTree<string>();
            var values = new[] {"David", "Adam", "Marshal", "Maggie", "Mike"};

            foreach (var value in values)
            {
                tree.Add(value);
            }

            Assert.AreEqual("David", tree.Root.Value);
            Assert.AreEqual("Adam", tree.Root.Left.Value);
            Assert.AreEqual("Marshal", tree.Root.Right.Value);
            Assert.AreEqual("Maggie", tree.Root.Right.Left.Value);
            Assert.AreEqual("Mike", tree.Root.Right.Right.Value);
        }
    }
}
