using System;

namespace Text
{
    /// <summary>
    /// class for string data searches
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts the amount of words in a string
        /// </summary>
        /// <param name="s">String to search</param>
        /// <returns>amount of words</returns>
        public static int CamelCase(string s)
        {
            if (s == null || s == "") return 0;

            string spaced = "";
            int count;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i])) spaced += ' ';
                spaced += s[i];
            }

            string[] words = spaced.Split(' ');
            count = words.Length;
            return count;
        }
    }
}
