// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// you can use _ as a number separator for better readability

int number = 1_344_500;
float f = 4_353.5f;
var x = 0xAB_CD_EF;
var b = 0b1101_1110_1001_0010;

Console.WriteLine($"number: {number}");
Console.WriteLine($"float: {f}");
Console.WriteLine($"hex: {b:X}");
Console.WriteLine($"binary: {x:X}");