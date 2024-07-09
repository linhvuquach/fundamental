using System;

namespace Company.ClassLibrary1;

// Violates OCP
public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public class AreaCalulator
{
    public double CalculateArea(object[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                area += rectangle.Width * rectangle.Height;
            }
            // Adding new shapes requires modifying this class
        }

        return area;
    }
}

// Follow OCP
public abstract class Shape()
{
    public abstract double CalculateArea();
}

public Rectangle : Shape
{
    public double Width { get; set; }
public double Height { get; set; }

public override double CalculateArea()
{
    return Width * Height;
}
}

public Square : Shape
{
    public double Side { get; set; }

public override double CalculateArea()
{
    return Side * Side;
}
}

public Circle : Shape
{
    public double Radius { get; set; }

public override double CalculateArea()
{
    return Math.PI * Radius * Radius;
}
}

public class AreaCalculator
{
    public double CalculateArea(Shape[] shapes)
    {
        return shapes.Sum(shape => shape.CalculateArea());
    }
}