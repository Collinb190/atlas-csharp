using System;
using System.Collections.Generic;

class List
{
   public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        int i = 0;
        while(i < listLength)
        {
            try
            {
                result.Add(list1[i]/list2[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            i++;
        }
        return result;
    }
}
