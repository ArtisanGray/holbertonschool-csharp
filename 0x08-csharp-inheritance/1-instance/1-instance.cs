using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>
    /// tests if an object given is an array
    /// </summary>
    /// <param name="obj">input type</param>
    /// <returns>whether or not it is an instance of class Array.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj) == true)
            return true;
        else
            return false;
    }
}