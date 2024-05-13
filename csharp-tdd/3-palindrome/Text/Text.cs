using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Class for Str related methods.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// method that returns True if a string is a palindrome or False if it’s not.
        /// </summary>
        /// <param name="s">String to be examined.</param>
        /// <returns>True or False.</returns>
        public static bool IsPalindrome(string s)
        {
            string original = "";

            foreach (char value in s)
            {
                if (!char.IsPunctuation(value) && value != ' ') original += char.ToLower(value);
            }

            string backward = new string(original.Reverse().ToArray());

            if (backward == original) return true;
            else return false;
        }
    }
}
