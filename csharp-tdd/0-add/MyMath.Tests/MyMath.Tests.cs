using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void positive()
        {
            int sum = Operations.Add(3, 3);
            Assert.AreEqual(sum, 6);
        }

        [Test]
        public void negative()
        {
            int sum = Operations.Add(3, -6);
            Assert.AreEqual(sum, -3);
        }

        [Test]
        public void doubleZero()
        {
            int sum = Operations.Add(0, 0);
            Assert.AreEqual(sum, 0);
        }

        [Test]
        public void singleZero()
        {
            int sum = Operations.Add(0, -6);
            Assert.AreEqual(sum, -6);
        }
    }
}