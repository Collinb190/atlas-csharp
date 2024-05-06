using System;
using System.Collections.Generic;

class List
{
   public static int Sum(List<int> myList)
    {
        HashSet<int> unique = new HashSet<int>(myList);
        int total = 0;

        foreach (int num in unique)
        {
            total += num;
        }
        return total;
    }
}
