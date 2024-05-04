﻿using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length)
        {
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("\\");
                }
            }
            Console.WriteLine("");
        }
    }
}
