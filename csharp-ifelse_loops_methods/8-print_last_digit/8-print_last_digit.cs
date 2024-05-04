using System;

namespace _8_print_last_digit
{
    class Number
    {
        public static int PrintLastDigit(int number)
        {
            number = Math.Abs(number);
            number %= 10;
            Console.Write(number);
            return number;
        }
    }
}
