using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>
    /// Checks if the object is an int
    /// </summary>
    /// <param name="obj">Object to be checked</param>
    /// <returns>True if integer or false if not</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj is int);
    }

}
