using System;
using MyMath;

namespace MyMathConsole
{    
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            int sum = Operations.Add(a, b);
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
