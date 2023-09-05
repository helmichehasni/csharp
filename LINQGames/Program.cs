namespace LINQGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Supplier> suppliers = new List<Supplier> {
             new Supplier(101, "ACME", "acme.com"),
             new Supplier(201, "Spring Valley", "spring-valley.com"),
             new Supplier(301, "Berkat Sabar", "sabar.com"),
             
            };

             List<Product> products = new List<Product> {
             new Product(1, "Dark Chocolate Bar", 4.99M, 10, 101),
             new Product(2, "8 oz Guacamole", 5.99M, 27, 201),
             new Product(3, "Milk Chocolate Bar", 3.99M, 16, 101),
             new Product(4, "8 pkg Chicken Tacos", 15.99M, 7, 201),
             new Product(5, "Corn Cake", 15.99M, 7, 301),
             new Product(6, "4 Bags Onions", 15.99M, 7, 101),
             new Product(7, "8 pkg Mince Meat", 15.99M, 7, 201),
             new Product(8, "1 Elephant", 15.99M, 7, 301),
             new Product(9, "3 pkg Flour", 15.99M, 7, 101),
             new Product(10, "8 pkg Rose", 15.99M, 7, 201),
             
            };

            var query1 = from s in suppliers select s.Name;

            foreach (var s in query1)
            {
                Console.WriteLine($"Supplier name:{s}");
            }

            //display product name.price and supplier name

            var q5 = from p in products
                     join s in suppliers on p.SupplierId equals s.SupplierId
                     select new
                     {
                         p.ProductName,
                         p.Price,
                         SupplierName = s.Name, 
                     };

            foreach (var ans in q5)
            {
                Console.WriteLine(ans);
            }

        }
    }
}