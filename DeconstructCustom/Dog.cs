namespace DefaultNamespace;

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }
    public string Color { get; set; }

    public Dog(string name, int age, string breed, string colors)
    {
        Name = name;
        Age = age;
        Breed = breed;
        Color = colors;
    }
    
    //Define a Deconstruct method to return name and colors
    public void Deconstruct(out string name, out string colors)
    {
        name = Name;
        colors = Color;
    }
    //Defining a Deconstruct method with the same number of parameter causes error
    //public void Deconstruct(out int age, out string colors)
   // {
   //     age = Age;
    //    colors = Color;
    //
    
    //Define a Deconstruct method to return name, age, and breed
    public void Deconstruct(out string name, out int age, out string breed)
    {
        name = Name;
        age = Age;
        breed = Breed;
    }
}