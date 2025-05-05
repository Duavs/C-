// See https://aka.ms/new-console-template for more information
using DefaultNamespace;
//Create some classes with data
Dog Belgian = new Dog("Charlie", 4, "Belgian", "Black and Brown");
Dog Aspin = new Dog("Max", 5, "Aspin", "Pure white");
//Use Deconstruction to get the name and colors
var (name, colors) = Belgian;
Console.WriteLine($"Name: {name}, Colors: {colors}");

//Use Deconstruction to get the name, age, and breed
(name, var age, var breed) = Aspin;
Console.WriteLine($"Name: {name}, Age: {age}, Breed: {breed}");