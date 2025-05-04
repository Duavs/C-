// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

void OldSchoolLogSring(string theString) //the old school way of logging
{
    if (theString == null)
    {
        Console.WriteLine("No string provided");
    }
    else
    {
        Console.WriteLine(theString);
    }
}

void LogString(string theString) // the new school way of logging
{
    Console.WriteLine(theString ?? "No string provided");
}

void ThrowableLogString(string theString) // the new school way of logging
{
    Console.WriteLine(theString ?? throw new ArgumentNullException(nameof(theString), "No string provided"));
}


OldSchoolLogSring("Old School Log String");
LogString("New School Log String");
ThrowableLogString("Throwable Log String");

string str = "Hello, World!";
str ??= "Default Value"; // Using null-coalescing assignment operator
Console.WriteLine(str); // Output: Default Value