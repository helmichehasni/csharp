using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AssetManager
{
    internal class Stock : Asset
    {
        public Stock(int assetId, string description, DateTime dateAcquired, double originalCost, int modelYear, double odometerReading) : base(assetId, description, dateAcquired, originalCost) 
        {
            StockTicker = stockticker;

        }
        public string StockTicker {  get; set; }

        public double CurrentSharePrice { get; set;}

        public int NumberOfShare {  get; set; }

        public override double GetValue()
        {
            return CurrentSharePrice * NumberOfShare;
        }

        public override string ToString()
        {
            return JsonConverter.SerializeObject(this);
        }
    }
}
