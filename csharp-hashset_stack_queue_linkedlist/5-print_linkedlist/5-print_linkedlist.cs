using System;
using System.Collections.Generic;

class LList
{
  public static LinkedList<int> CreatePrint(int size)
    {
        List<int> template = new List<int>();

        if (size < 0)
        {
           LinkedList<int> empty = new LinkedList<int>();
           return empty;
        }

        for (int i = 0; i < size; i++)
        {
            template.Add(i);
            Console.WriteLine(i);
        }
        LinkedList<int> result = new LinkedList<int>(template);
        return result;
    }
}
