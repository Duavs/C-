// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using DefaultNamespace;
StockRecords stock1 = new StockRecords();

Console.WriteLine($"Average: {stock1.Average:C}");
Console.WriteLine($"High: {stock1.High:C}");
Console.WriteLine($"Low: {stock1.Low:C}");

//use the indexer
Console.WriteLine($"Days: {stock1.Length}");

for (int i = 0; i < stock1.Length; i++)
{
    decimal val = stock1[i];
    Console.WriteLine($"Val: {val:C}");
} 
Console.WriteLine();

Console.WriteLine($"Monday: {stock1["mon"]:C}");
Console.WriteLine($"Wednesday: {stock1["wed"]:C}");

Console.WriteLine($"Not Valid Day: {stock1["monwed"]: C}");