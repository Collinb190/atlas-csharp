using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> numbers = new List<int>();
        for (int i = 0; i < size; i++)
        {
            numbers.Add(i);
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write("{0}{1}", numbers[i], i == numbers.Count - 1 ? "":" ");
        }
        Console.WriteLine();
        return numbers;
    }
}
