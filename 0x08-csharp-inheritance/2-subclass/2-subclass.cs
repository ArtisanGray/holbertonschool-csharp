using System;

class Obj
{
    /// <summary>
    /// tests if a given type is a inherited subclass.
    /// </summary>
    /// <param name="derivedType">the supposed inheritance.</param>
    /// <param name="baseType">base class to compare to.</param>
    /// <returns>true if inherited, false otherwise.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType) == true)
            return true;
        else
            return false;
    }
}
