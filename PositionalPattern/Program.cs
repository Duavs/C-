// See https://aka.ms/new-console-template for more information
//Using Positional pattern and tuple pattern in pattern matching
decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate) => (groupSize, visitDate.DayOfWeek) switch
{
 //use the position of each value as an individual pattern expression
 (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
 (>= 5 and < 10, DayOfWeek.Monday) => 0.20m,
 (>= 10, DayOfWeek.Monday) => 0.30m,
 (>= 5 and < 10, _) => 0.12m,
 (>= 10, _) => 0.15m,
 (<=0, _) => throw new ArgumentException("Group should be greater than 0"),
 _ => 0.0m,
};

//Declare some tests data to use with the example
(int, DateTime)[] TestDiscountData = new[]
{
 (4, new DateTime(2025, 3, 12)),
 (6, new DateTime(2025, 1, 21)),
 (4, new DateTime(2025, 4, 16)),
 (20, new DateTime(2024, 6, 30)),
};

//Loop through the test data and print out the results
foreach ((var size, var date) in TestDiscountData)
{
 decimal discount = GetGroupTicketPriceDiscount(size, date);
 Console.WriteLine($"Group size: {size}, Visit date: {date: ddd, MMM, d}, is Discount: {discount:P}");
}

//Use the implicit Deconstruct call to switch on the different values of class
string Classify(Point point) => point switch
{
 (>0, >0) => "Upper right quadrant",
 (<0, >0) => "Upper left quadrant",
 (>0, <0) => "Lower right quadrant",
 (<0, <0) => "Lower left quadrant",
 _ => "Just a point",
};

//Test code for point example

Point[] TestPointData = new[]
{
 new Point(5, 8),
 new Point(-5, 3),
 new Point(4, -54),
 new Point(-3, -2),
};

//Loop through the test data and print out the results
foreach (Point p in TestPointData)
{
 Console.WriteLine($"Point: {p}, is in {Classify(p)}");
}

//define a type that implements the Deconstruct method to return a tuple
public readonly struct Point
{
 public int X { get; }
 public int Y { get; }

 public Point(int x, int y)
 {
  X = x;
  Y = y;
 }

 //Deconstruct method to return a tuple
 public void Deconstruct(out int x, out int y)
 {
  x = X;
  y = Y;
 }
}