namespace GeometryLibrary;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("The sides must be positive numbers.");

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("A triangle with such sides does not exist.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        var semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    public bool IsRightAngled()
    {
        var a2 = SideA * SideA;
        var b2 = SideB * SideB;
        var c2 = SideC * SideC;

        return AreEqual(a2 + b2, c2) ||
               AreEqual(a2 + c2, b2) ||
               AreEqual(b2 + c2, a2);
    }

    private bool AreEqual(double x, double y, double epsilon = 1e-10)
    {
        return Math.Abs(x - y) < epsilon;
    }
    
    public override string ToString()
    {
        return $"Triangle: Sides = ({SideA}, {SideB}, {SideC})";
    }
}