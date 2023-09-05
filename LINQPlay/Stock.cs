using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LINQPlay
{
    internal class Stock
    {
        public string TickerSymbol { get; set; }
        public string StockName { get; set;}

        public double SharePrice { get; set;}

        public int UnitsOwned { get; set; }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
