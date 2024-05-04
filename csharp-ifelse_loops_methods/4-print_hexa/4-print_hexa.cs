using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 98; i++)
            {
                Console.Write($"{i} = 0x{i:X}".ToLower() + "\n");
            }
        }
    }
}
