using System;
using MyMath;

namespace MyMathConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] values = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] result = Matrix.Divide(values, 2);
            int rows = result.GetLength(0);
            int columns = result.GetLength(1);

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Console.WriteLine($"{result[x, y] }");
                }
            }
        }
    }
}
