using System;
using Text;

namespace TextConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "twoWords";
            int c = Str.CamelCase(s);
            Console.WriteLine(c);
        }
    }
}
