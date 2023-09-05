using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AssetManager
{
    internal class Car : Asset
    {
        public Car(int assetId, string description, DateTime dateAcquired, double originalCost, int modelYear, double odometerReading) : base(assetId,description,dateAcquired,originalCost)
        {
            ModelYear = modelYear;
            OdometerReading = odometerReading;
        }

        public int ModelYear { get; set; }

        public double OdometerReading { get; set; }

        public override double GetValue()
        {
            if ( (DateTime.Today.Year - ModelYear) < 7)
            {
                depreciationCost = OriginalCost - OdometerReading / 5000 * 0.02;
                depreciaitonCost =
            }
            else
            {
                depreciationCost = OdometerReading < 1000000
                    ? OriginalCost - OriginalCost * 0.7
                    : OriginalCost - OriginalCost * 0.9;
            }
            return depreciationCost;
        }

        public override string ToString()
        {
            return JsonConverter.SerializeObject(this);
        }
    }
}
