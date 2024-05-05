using System;

class Program
{
    static void Main(string[] args)
    {
        int[] newArray;

        newArray = _0_print_array.Array.CreatePrint(10);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = _0_print_array.Array.CreatePrint(16);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = _0_print_array.Array.CreatePrint(0);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = _0_print_array.Array.CreatePrint(-10);
    }
}
