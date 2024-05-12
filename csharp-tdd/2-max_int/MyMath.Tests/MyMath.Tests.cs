using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperatonsTests
    {
        [Test]
        public void ZeroValue()
        {
            List<int> values = new List<int>();
            int result = Operations.Max(values);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void OneValue()
        {
            List<int> values = new List<int> { -3 };
            int result = Operations.Max(values);
            Assert.AreEqual(result, -3);
        }

        [Test]
        public void AllPositive()
        {
            List<int> values = new List<int> { 45, 4, 78, 15, 22, 69, 420 };
            int result = Operations.Max(values);
            Assert.AreEqual(result, 420);
        }

        [Test]
        public void AllNegative()
        {
            List<int> values = new List<int> { -45, -4, -78, -15, -22, -69, -420 };
            int result = Operations.Max(values);
            Assert.AreEqual(result, -4);
        }
    }
}