using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQGames
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int QuantityOnHand { get; set; }
        public int SupplierId { get; set; }
        public Product(int productId, string productName,
        decimal price, int quantityOnHand,
       int supplierId)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            QuantityOnHand = quantityOnHand;
            SupplierId = supplierId;
        }
        public override string ToString()
        {
            return $"{ProductId} - {ProductName} - {Price:C} - "
            + $"Qty: {QuantityOnHand} - ";
        }
    }

    class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public Supplier(int supplierId, string name,
        string url)
        {
            SupplierId = supplierId;
            Name = name;
            URL = url;
        }
        public override string ToString()
        {
            return $"{SupplierId} - {Name} - Url: {URL}";
        }
    }
}
