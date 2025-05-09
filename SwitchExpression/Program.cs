// See https://aka.ms/new-console-template for more information
string NumToString(int num){
	switch (num)
    {
        case 1:
            return "One";
        case 2:
            return "Two";
        case 3:
            return "Three";
        default:
            return "Unknown";
    }
} 
//Console.WriteLine(NumToString(2));
//Console.WriteLine(NumToString(4));


// can now operate on just about any type of object

string ShapeToString(object shape)
{
    switch (shape)
    {
        case DefaultNamespace.Shapes.Circle:
            return "Circle";
        case DefaultNamespace.Shapes.Rectangle:
            return "Rectangle";
        case DefaultNamespace.Shapes.Triangle:
            return "Triangle";
        default:
            return "Unknown";
    }
}

//Console.WriteLine(ShapeToString(new DefaultNamespace.Shapes.Circle { Radius = 10 }));
//Console.WriteLine(ShapeToString(new DefaultNamespace.Shapes.Triangle { Base = 10, Height = 20 }));
//Console.WriteLine(ShapeToString(new DefaultNamespace.Shapes.Rectangle {Length = 12, Width = 20}));
//Console.WriteLine(ShapeToString(new Rectangle{Length = 10, Width = 20}));


// can also use the switch expression to return a value based on the type of the object
string ShapeToString2(object shape) => shape switch
{
	DefaultNamespace.Shapes.Circle {Radius: var r} when r >= 10 => "Large Circle",
	DefaultNamespace.Shapes.Triangle {Base: var b, Height: var h} when b < 20 && h > 10 => "Small Triangle",
	DefaultNamespace.Shapes.Rectangle {Length: var l,Width: var w} when l == w => "Square",
    DefaultNamespace.Shapes.Rectangle {Length: var l,Width: var w} when l > w => "Rectangle",
	DefaultNamespace.Shapes.Rectangle => "Rectangle",
	DefaultNamespace.Shapes.Triangle => "Triangle",
	_ => "Unknown"
};

Console.WriteLine(ShapeToString2(new DefaultNamespace.Shapes.Circle { Radius = 10 }));
Console.WriteLine(ShapeToString2(new DefaultNamespace.Shapes.Triangle { Base = 10, Height = 20 }));
