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
    /// <summary>
    /// returns the area of the rectangle.
    /// </summary>
    /// <returns>returns a non-negative number.</returns>
    public new int Area()
    {
        return (width * height);
    }
    /// <summary>
    /// prints a string representation of the class's data.
    /// </summary>
    /// <returns>a string</returns>
    public override string ToString() => $"[Rectangle] {width} / {height}";
}
