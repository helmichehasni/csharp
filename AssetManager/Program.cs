namespace AssetManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asset[] assets = new Asset[5];
            assets[0] = new Stock(1, "moile legend", new DateTime(2022, 1, 1), 120, "ML", 130, 4);
            assets[1] = new Stock(2, "clash of clan", new DateTime(2022, 1, 1), 120, "COC", 130, 4);
            assets[2] = new Stock(3, "Microsoft", new DateTime(2022, 1, 1), 120, "MSFT", 130, 4);
            assets[3] = new Stock(4, "toyota", new DateTime(2022, 1, 1), 120, "MSFT", 130, 4);
            assets[4] = new Stock(5, "Hondat", new DateTime(2022, 1, 1), 120, "MSFT", 130, 4);

            Console.WriteLine("Description\t\tDate Acquired\tValue");
            foreach (var item in assets)
            {
                Console.WriteLine($"{item.Description}\t{item.DateAcquired.ToShortDateString()}\t{item.GetValue()}");
            }

            Console.WriteLine("-------------------------Car info---------------------");

            Console.WriteLine("-------------------------Stock info---------------------");


        }
    }
}