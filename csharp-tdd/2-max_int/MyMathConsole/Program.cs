using System;
using MyMath;
using System.Collections.Generic;

namespace MyMathConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int> { 6, 9, 12, 15, 18 };
            int x = Operations.Max(values);
            Console.WriteLine(x);
        }
    }
}
