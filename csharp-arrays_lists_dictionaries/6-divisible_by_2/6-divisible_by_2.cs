using System;
using System.Collections.Generic;

class List
{
   public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> multiple = new List<bool>();
        foreach (int num in myList)
        {
            if  (num % 2 == 0)
            {
                multiple.Add(true);
            }
            else
            {
                multiple.Add(false);
            }
        }
        return multiple;
    }
}
