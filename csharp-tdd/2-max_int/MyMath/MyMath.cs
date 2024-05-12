using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Class of math operations.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Finds the max integer in a list of integers
        /// </summary>
        /// <param name="nums">List to search</param>
        /// <returns>Max integer in list nums</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count < 1) return 0;

            int result = int.MinValue;

            foreach (int value in nums)
            {
                if (value > result)
                {
                    result = value;
                }
            }
            return result;
        }
    }
}
