// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
float x = 42.0f;
string str = x.ToString();
Console.WriteLine($"{str}");

//ToString to represent a custom type
Person p = new Person() {FirstName = "John", LastName = "Duavis", Age=25};
Console.WriteLine($"{p}");
public class Person
{
    public string? FirstName
    {
        get; set;
    }

    public string? LastName
    {
        get;
        set;
    }

    public int Age
    {
        get;
        set;
    }
    public override string ToString()
    {
        return $"[Person] FirstName:{FirstName}, LastName:{LastName}, Age:{Age}";
    }
}

//override toString 
//public override string ToString() => $"[Person] FirstName:{FirstName}, LastName:{LastName}, Age:{Age}";