using System;

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
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// width property
    /// </summary>
    /// <returns>width value</returns>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
    /// <summary>
    /// height property
    /// </summary>
    /// <returns>height value</returns>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}