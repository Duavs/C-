// See https://aka.ms/new-console-template for more information
//Rules
// A stock trade of 0 shares should be caught and flagged as invalid
// a stock trade that is less than 5000 is a 0.1% commission
//a stock trade that is more or equal to 5000 is 0.5% commission
// any stock trade of 1000 shares or more is a flat fee of 10$
// any stock trade of 1000 shares or more with a value of 10,000 or more is flat fee of 50
// a bond trade of 5 years duration is 20$, or 15$ if the total trade is value is 10,000 or more
// any bond trade of 10 years duration is 12
// bond trade of 20 years duration is 10$, or 5$ if the total value is 5,000$ or more
// bond trade of any other duration should be caught and flagged as invalid

//Test code to test the traide commission calculation algorithm:

SecuritiesTrade[] tradeList = new SecuritiesTrade[]
{
    new StockTrade(){Symbol="ABCD", Quantity=1200, Price=27.1m},
    new StockTrade(){Symbol="wxyz", Quantity=1000, Price=7.92m},
    new StockTrade(){Symbol="ABCD", Quantity=200, Price=27.81m},
    new StockTrade(){Symbol="WXYZ", Quantity=400, Price=7.92m},
    new StockTrade(){Symbol="WXYZ", Quantity=0, Price=9.55m},
    new BondTrade(){Symbol="Abcd 5yr", Duration=5, Price=100.0m, Quantity=10},
    new BondTrade(){Symbol="Qwert 10yr", Duration=10, Price=100.0m, Quantity=10},
    new BondTrade(){Symbol="Abcd 20yr", Duration=20, Price=100.0m, Quantity=100},
    new BondTrade(){Symbol="Qwert 50yr", Duration=50, Price=50.0m, Quantity=10},
}

foreach (var tradeItem in tradeList)
{
    try
    {
         
    }
}