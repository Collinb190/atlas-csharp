using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int k = 1; k < 10; k++)
                {
                    if (i < k && i != 8 && k != 9)
                    {
                        Console.Write($"{i}{k}, ");
                    }
                    else if (i == 8 && k == 9)
                    {
                        Console.WriteLine($"{i}{k}");
                    }
                }
            }
        }
    }
}
