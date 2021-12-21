using System;

class Obj
{
    /// <summary>
    /// tests if an object is of type Integer. 
    /// </summary>
    /// <param name="obj">obj passed as input</param>
    /// <returns>whether or not the object is an int.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType().Equals(typeof(int)) == true)
        {
            return true;
        }
        else
            return false;
    }
}