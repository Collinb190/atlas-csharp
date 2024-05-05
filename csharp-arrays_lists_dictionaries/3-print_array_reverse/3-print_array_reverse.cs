using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine();
            return;
        }
        else if (array.Length == 0)
        {
            Console.WriteLine();
            return;
        }
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write("{0}{1}", array[i], i != 0 ? " ": "");
        }
        Console.WriteLine();
    }
}
