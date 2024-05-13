using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void First()
        {
            string s = "fabcdabcd";
            int i = Str.UniqueChar(s);
            Assert.AreEqual(i, 0);
        }

        [Test]
        public void Last()
        {
            string s = "abcdabcdf";
            int i = Str.UniqueChar(s);
            Assert.AreEqual(i, 8);
        }

        [Test]
        public void Regular()
        {
            string s = "abcdfabcd";
            int i = Str.UniqueChar(s);
            Assert.AreEqual(i, 4);
        }

        [Test]
        public void NoUnique()
        {
            string s = "abcdabcd";
            int i = Str.UniqueChar(s);
            Assert.AreEqual(i, -1);
        }

        [Test]
        public void Empty()
        {
            string s = "";
            int i = Str.UniqueChar(s);
            Assert.AreEqual(i, -1);
        }
    }
}