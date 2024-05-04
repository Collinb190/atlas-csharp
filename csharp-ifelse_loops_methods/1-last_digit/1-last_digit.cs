using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
	    int remainder = number % 10;

        if (remainder == 0)
        {
            Console.WriteLine($"The last digit of {number} is {remainder} and is 0");
        }
        else if (remainder > 5)
        {
            Console.WriteLine($"The last digit of {number} is {remainder} and is greater than 5");
        }
        else
        {
            Console.WriteLine($"The last digit of {number} is {remainder} and is less than 6 and not 0");
        }
    }
}
