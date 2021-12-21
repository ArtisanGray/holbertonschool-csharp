using System;
using System.Collections.Generic;
using System.Reflection;

class Obj
{
    /// <summary>
    /// gets the available methods an properties of a given object.
    /// </summary>
    /// <param name="myObj">object to be parsed</param>
    public static void Print(object myObj)
    {
        int i = 0, j = 0;

        var info = myObj.GetType().GetTypeInfo();
        var properties = info.GetProperties();
        var methods = info.GetMethods();

        Console.WriteLine("{0} Properties:", info.Name);
        for (; i < properties.Length; i++)
        {
            Console.WriteLine(properties[i].Name);
        }
        Console.WriteLine("{0} Methods:", info.Name);
        for (; j < methods.Length; j++)
        {
            if (methods[i].IsPublic == true)
                Console.WriteLine(methods[j].Name);
        }
    }
}
