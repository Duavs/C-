// See https://aka.ms/new-console-template for more information
//Relational patterns can be used to compare constant values using logical comparison
// operatiors such aas <, >, <=,  and >=

// example determine which quarter it occurs in
string GetQuarterFromDate(DateTime date) => date.Month switch
{
    //categorieze the date into a quarter
    >=1 and <=3 => "Q1", 
        >=4 and <=6 => "Q2",
        >=7 and <=9 => "Q3",
        >=10 and <=12 => "Q4",
    _ => throw new ArgumentOutOfRangeException(nameof(date), $"Unexpected date value: {date}"),
};

Console.WriteLine(GetQuarterFromDate(new DateTime(2023, 1, 15))); // Q1
Console.WriteLine(GetQuarterFromDate(new DateTime(2023, 4, 15))); // Q2
Console.WriteLine(GetQuarterFromDate(new DateTime(2023, 7, 15))); // Q3
Console.WriteLine(GetQuarterFromDate(new DateTime(2023, 10, 15))); // Q4


// also work with the regular "is" statement

void FirstOrSecondHalf(object dt)
{
    if (dt is DateTime { Month: > 6 })
    {
        Console.WriteLine("Second half of the year");
    }
    else if (dt is DateTime { Month: <= 6 })
    {
        Console.WriteLine("First half of the year");
    }
}

FirstOrSecondHalf(new DateTime(2023, 1, 15)); // First half of the year
FirstOrSecondHalf(new DateTime(2023, 7, 15)); // Second half of the year
