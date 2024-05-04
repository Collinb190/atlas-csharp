using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 97; i <= 122; i++)
            {
                char letter = (char)i;
                Console.Write(letter);
            }
        }
    }
}
