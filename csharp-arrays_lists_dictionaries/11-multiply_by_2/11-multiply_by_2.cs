using System;
using System.Collections.Generic;

class Dictionary
{
   public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        string[] keys = new string[myDict.Keys.Count];
        myDict.Keys.CopyTo(keys, 0);

        foreach (string key in keys)
        {
            myDict[key] *= 2;
        }
        return myDict;
    }
}
