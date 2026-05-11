using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Models
{
    public class OrderItem
    {
        // Product
        public Product Product { get; set; }

        // Quantity
        public int Quantity { get; set; }

        // SubTotal
        public double SubTotal
        {
            get
            {
                return (Product.Price - Product.CalculateDiscount())
                        * Quantity;
            }
        }

        // Constructor
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
