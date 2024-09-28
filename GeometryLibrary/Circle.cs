namespace GeometryLibrary;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if(radius <= 0)
            throw new ArgumentException("The radius must be a positive number.");
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
    
    public override string ToString()
    {
        return $"Circle: Radius = {Radius}";
    }
}