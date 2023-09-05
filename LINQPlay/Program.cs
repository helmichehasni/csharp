using System.Diagnostics;

namespace LINQPlay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Stock> liststocks = new List<Stock>
            {
                new Stock{ TickerSymbol = "MFST", StockName="Micosoft" , SharePrice=19, UnitsOwned=40},
                new Stock{ TickerSymbol = "AMZN", StockName="Amazon" , SharePrice=34, UnitsOwned=10},
                new Stock{ TickerSymbol = "GOOG", StockName="Google" , SharePrice=45, UnitsOwned=6},
                new Stock{ TickerSymbol = "TSLA", StockName="Tesla" , SharePrice=60, UnitsOwned=3},
                new Stock{ TickerSymbol = "RELI", StockName="Relaiancet" , SharePrice=78, UnitsOwned=7},
                new Stock{ TickerSymbol = "FB", StockName="Facebook" , SharePrice=10, UnitsOwned=5},
                new Stock{ TickerSymbol = "TWT", StockName="Twittwer" , SharePrice=56, UnitsOwned=9},
            };

            var result1 = from s in liststocks
                          where s.SharePrice < 20
                          select s;

            var result2 = liststocks.Where(s => s.SharePrice >= 20 && s.SharePrice <= 75);

            //3. display cheapest stock

            var result3 = liststocks.Min(s => s.SharePrice);

            //get the price of the lowest s.SharePrice
            //lowestPrice = stockList.Min().Single()
            //lowestPriceList = stockList.Where(x => x.SharePrice == lowestPrice.SharePrice).ToList();
            foreach (var item in StockInvestment.GetStockInvestments(Stock)
            {
                Console.WriteLine(item);
            }

        }
    }
}