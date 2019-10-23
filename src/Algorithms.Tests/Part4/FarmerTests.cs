using NUnit.Framework;
using Part4;

namespace Algorithms.Tests.Part4
{
    [TestFixture]
    public class FarmerTests
    {
        private readonly Farmer _farmer = new Farmer();

        [Test]
        public void Should_CrossField_Successfully()
        {
            var side = _farmer.CrossField(1680, 640);

            Assert.AreEqual(80, side);
        }

        [Test]
        public void Should_CrossField_WhenZero()
        {
            var side = _farmer.CrossField(16, 0);

            Assert.AreEqual(0, side);
        }

        [Test]
        public void Should_CrossField_WhenOdd()
        {
            var side = _farmer.CrossField(11, 97);

            Assert.AreEqual(1, side);
        }
    }
}
