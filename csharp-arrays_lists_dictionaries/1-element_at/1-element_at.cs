using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        int x = array[index];
        if (index < 0 || index > array.Length - 1)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        return x;
    }
}
