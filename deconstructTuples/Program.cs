// See https://aka.ms/new-console-template for more information
(decimal, decimal, decimal) GetPrices(string FruitName)
{
    if (FruitName == "Apple")
    {
        return (100.00m, 63.00m, 40.00m);
    }
    else if (FruitName == "Avocado")
    {
        return (200.00m, 150.00m, 50.00m);
    }
    else
    {
        return (0, 0, 0);
    }
}


var itemName = "Avocado";
// Deconstructing the tuple returned by GetPrices method
var (FirstClassFruit, SecondClassFruit, ThirdClassFruit) = GetPrices(itemName);
Console.WriteLine($"First Class {itemName}: {FirstClassFruit} pesos per kilo" +
                  $"\nSecond Class {itemName}: {SecondClassFruit} pesos per kilo" +
                  $"\nThird Class {itemName}: {ThirdClassFruit} pesos per kilo");
 
//Using "_" as discard the value of the tuple
var (TopTier, _, LowTier) = GetPrices(itemName);
Console.WriteLine($"First Class {itemName}: {TopTier} pesos per kilo" +
                  $"\nSecond Class {itemName}:  pesos per kilo" +
                  $"\nThird Class {itemName}: {LowTier} pesos per kilo");