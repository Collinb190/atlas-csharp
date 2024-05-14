using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();

        Console.WriteLine($"{objType.Name} Properties:");
        foreach (PropertyInfo pInfo in objType.GetProperties())
            Console.WriteLine(pInfo.Name);

        Console.WriteLine($"{objType.Name} Methods:");
        foreach (MethodInfo mInfo in objType.GetMethods())
            Console.WriteLine(mInfo.Name);
    }
}
