﻿using System;

namespace MyMath
{
    /// <summary>
    /// Class containg methods for matrix manipulation.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of a matrix.
        /// </summary>
        /// <param name="matrix">Matrix whose elements to divide.</param>
        /// <param name="num">Divisor.</param>
        /// <returns>The divided sets of the matrix.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null) return null;

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] result = new int[rows, columns];

            try
            {
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < columns; y++)
                    {
                        result[x, y] = matrix[x, y] / num;
                    }
                }
                return result;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
