using System;
using System.Collections.Generic;

class Shape
{
    /// <summary>
    /// an open ended class that defines a shape's area.
    /// </summary>
    /// <returns>nothing. error.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}