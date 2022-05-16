using System;
using System.Collections.Generic;

#nullable disable

namespace InventoryApp.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int? OrderAmount { get; set; }
        public bool Order { get; set; }

        public Product( int productId, string productName, string productDescription, int quantity, double price, int orderAmount, bool order)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
            Quantity = quantity;
            Price = price;
            OrderAmount = orderAmount;
            Order = order;
        }

        public Product()
        {

        }
    }
}
