using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
   public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> sortedKeys = myDict.Keys.ToList();
        sortedKeys.Sort();
        foreach (string key in sortedKeys)
        {
            string value = myDict[key];
            Console.WriteLine("{0}: {1}", key, value);
        }
    }
}
