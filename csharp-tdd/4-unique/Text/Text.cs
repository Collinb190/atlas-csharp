using System;

namespace Text
{
    /// <summary>
    /// Class containg string data search methods
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Finds the index of the first non-repeating character of a string
        /// </summary>
        /// <param name="s">String to search</param>
        /// <returns>index of the first non-repeating character</returns>
        public static int UniqueChar(string s)
        {
            if (s == null) return -1;
            char[] compare = s.ToCharArray();
            int counter;

            for (int i = 0; i < compare.Length; i++)
            {
                counter = 0;
                for (int k = 0; k < compare.Length; k++)
                {
                    if (i != k)
                        if (compare[i] == compare[k]) counter += 1;
                }
                if (counter == 0) return i;
            }
            return -1;
        }
    }
}
