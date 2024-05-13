using System;
using Text;

namespace TextConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "A man, a plan, a canal: Panama.";
            bool result = Str.IsPalindrome(phrase);
            Console.WriteLine(result);
        }
    }
}
