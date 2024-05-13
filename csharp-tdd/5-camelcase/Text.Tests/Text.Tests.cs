using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void Empty()
        {
            string s = "";
            int c = Str.CamelCase(s);
            Assert.AreEqual(c, 0);
        }

        [Test]
        public void Nothing()
        {
            string s = null;
            int c = Str.CamelCase(s);
            Assert.AreEqual(c, 0);
        }

        [Test]
        public void Regular()
        {
            string s = "twoWords";
            int c = Str.CamelCase(s);
            Assert.AreEqual(c, 2);
        }
    }
}