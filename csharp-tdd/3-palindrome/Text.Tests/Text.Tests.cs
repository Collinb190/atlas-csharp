using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void Empty()
        {
            string s = "";
            bool result = Str.IsPalindrome(s);
            Assert.IsTrue(result);
        }

        [Test]
        public void OneWordTrue()
        {
            string s = "Racecar";
            bool result = Str.IsPalindrome(s);
            Assert.IsTrue(result);
        }

        [Test]
        public void OneWordFalse()
        {
            string s = "nope";
            bool result = Str.IsPalindrome(s);
            Assert.IsFalse(result);
        }

        [Test]
        public void FullStringTrue()
        {
            string s = "A man, a plan, a canal: Panama.";
            bool result = Str.IsPalindrome(s);
            Assert.IsTrue(result);
        }
    }
}