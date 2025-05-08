// See https://aka.ms/new-console-template for more information
// can now operate on just about any type of object
using DefaultNamespace;
string ShapeToString(object shape)
{
    switch (shape)
    {
        case Circle:
            return "Circle";
        case Rectangle:
            return "Rectangle";
        case Triangle:
            return "Triangle";
        default:
            return "Unknown";
    }
}

Console.WriteLine(ShapeToString(new Circle{Radius = 10}));
