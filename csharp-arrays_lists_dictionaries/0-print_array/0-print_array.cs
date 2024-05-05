﻿using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            else if (size == 0)
            {
                Console.WriteLine();
                return new int[0];
            }
            else
            {
                int[] newArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = i;
                    Console.Write(newArray[i] + " ");
                }
                Console.WriteLine();
                return newArray;
            }
        }
    }
}
