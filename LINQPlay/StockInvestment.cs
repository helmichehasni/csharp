using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPlay
{
    internal class StockInvestment
    {
        public string TickerSymbol { get; set; }
        public string StockName { get; set; }

        public double TotalValue { get; set; }

        public static  List<StockInvestment> GetStockInvestments(List<Stock> listStock)
        {
            List<StockInvestment> investments = new List<StockInvestment>();
            listStock.ForEach(stock =>
            {
                investments.Add(new StockInvestment
                {
                    TickerSymbol = stock.TickerSymbol,
                    StockName = stock.StockName,
                    TotalValue = stock.SharePrice * stock.UnitsOwned
                });
            });
            return investments;
        }
    }
}
