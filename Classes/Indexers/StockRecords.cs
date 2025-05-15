namespace DefaultNamespace;

public class StockRecords
{
    public string Symbol
    {
        get => "ABCD";
    }

    private decimal[] prices = new decimal[]
    {
        105.0m, 103.12m, 106.92m, 104.5m, 103.7m
    };
    
    //public properties
    public decimal Average
    {
        get => prices.Sum() / prices.Length;
    }

    public decimal High
    {
        get => prices.Max();
    }

    public decimal Low
    {
        get => prices.Min();
    }
    
    //length property

    public int Length => prices.Length;
    
    //indexers
    public decimal this[int index]
    {
        get => prices[index];
    }

    public decimal this[string day]
    {
        get
        {
            if (day == "mon")
            {
                return prices[0];
            }

            if (day == "tue")
            {
                return prices[1];
            }

            if (day == "wed")
            {
                return prices[2];
            }

            if (day == "thu")
            {
                return prices[3];
            }

            if (day == "fri")
            {
                return prices[4];
            }
    
            throw new IndexOutOfRangeException($"Invalid day: {day}");
        }
    }  
}