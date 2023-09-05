using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessing
{
    internal class TimeCard
    {
        public string Name { get; set; }

        public int HoursWorked { get; set; }

        public double PayRate { get; set; }

        public static TimeCard CreateTimeCard(string data)
        {
            //Gothie | 45 | 38.60
            string[] parsedData = data.Split('|');
            TimeCard timeCard = new TimeCard()
            {
                Name = parsedData[0],
                HoursWorked = Convert.ToInt32(parsedData[1]),
                PayRate = Convert.ToDouble(parsedData[2])
            };
            return timeCard;
        }

        public double GetGrossPay()
        {
            double grossPay = HoursWorked * PayRate;
            return grossPay;
        }
    }
}
