using System;
using Text;

namespace TextConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdfabcd";
            int i = Str.UniqueChar(s);
            Console.WriteLine(i);
        }
    }
}
