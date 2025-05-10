namespace DefaultNamespace;

public class Securities
{
    public int Quantity;
    public decimal Price;
}

public class StockTrade: Securities
{
    public string Symbol;
}

public class BondTrade: Securities
{
    public int Duration;
    public string? Name;
}