// See https://aka.ms/new-console-template for more information
//Te 'is' expression is used for this to test the Constant Pattern
// string? str = "This is a string";
//
// if (str is not null)
// {
//     Console.WriteLine($"str is not null: {str}");
// }
// else
// {
//     Console.WriteLine("str is null");
// }


//The 'is' expression is can also be used to extract a value
//This is called the Declaration Pattern

void dashedline(object o)
{
    // the old wa of doing this
    int l = 0;
    if (o.GetType() == typeof(int))
    {
        l = (int)o;
    }

    string s;
    if (o.GetType() == typeof(int))
    {
        s = (string)o;
        if (!int.TryParse(s, out l))
        {
            l = 0;
        }
    }
    if
    {
        if (l > 0)
        {
            string str = new string('-', l);
            Console.WriteLine(str);
        }
    }
    
    //TODO: The new way is to just use the declaration pattern
    if (o is int l || (o is string s && int.Tryparse(s, out l)))
    {
        string str = new string('-', l);
        Console.WriteLine(str);
    }
}

