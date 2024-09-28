using GeometryLibrary;

IShape circle = new Circle(5);
var circleArea = GetArea(circle);
Console.WriteLine($"{circle}, area = {circleArea:F2}");

IShape triangle = new Triangle(3, 4, 5);
var triangleArea = GetArea(triangle);
var isRightAngled = ((Triangle)triangle).IsRightAngled();
Console.WriteLine($"{triangle}, area = {triangleArea:F2}, right-angled = {isRightAngled}");


double GetArea(IShape shape)
{
    return shape.CalculateArea();
}