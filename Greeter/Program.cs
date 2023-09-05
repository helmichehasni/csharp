using System;

namespace Greeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeOfDay = DateTime.Now.TimeOfDay;

            if (timeOfDay >= TimeSpan.FromHours(5) && timeOfDay  < TimeSpan.FromHours(10))
            {
                Console.WriteLine("Good Morning");
            }
            else if (timeOfDay >= TimeSpan.FromHours(10) && timeOfDay < TimeSpan.FromHours(6))
            {
                Console.WriteLine("Good Day");
            }
            else if(timeOfDay >= TimeSpan.FromHours(18) && timeOfDay < TimeSpan.FromHours(24))
            {
                Console.WriteLine("Good Evening");
            }
            else if (timeOfDay >= TimeSpan.FromHours(0) && timeOfDay < TimeSpan.FromHours(5))
            {
                Console.WriteLine("Welcome to midnight shift");
            }

            DateTime renewalDate = DateTime.Now;

            DateTime graceDate = renewalDate.AddDays(10);
            DateTime cancelDate = renewalDate.AddMonths(1);
        }
    }
}