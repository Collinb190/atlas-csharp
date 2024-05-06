using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
   public static string BestScore(Dictionary<string, int> myList)
    {
        string bestKey = "";
        int maxValue = int.MinValue;

        if (myList.Count == 0)
        {
            return "None";
        }
        foreach (KeyValuePair<string, int> pair in myList)
        {
            if (pair.Value > maxValue)
            {
                maxValue = pair.Value;
                bestKey = pair.Key;
            }
        }
        return bestKey;
    }
}
