using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OrderProcessingSystem.Models
{
    public class Order
    {
        // Properties
        public string Id { get; set; }

        public Customer Customer { get; set; }


        public List<OrderItem> Items { get; set; }

        public OrderStatus Status { get; set; }
        public Payment PaymentMethod { get; set; }


        // Total Price
        public double TotalPrice
        {
            get
            {
                return Items.Sum(i => i.SubTotal);
            }
        }

        // Constructor
        public Order(string id, Customer customer)
        {
            Id = id;
            Customer = customer;

            Items = new List<OrderItem>();

            Status = OrderStatus.Pending;
        }

        // Add Product
        public void AddProduct(Product product, int quantity)
        {
            // Check stock
            if (quantity <= product.StockQuantity)
            {
                Items.Add(new OrderItem(product, quantity));

                // Reduce stock
                product.StockQuantity -= quantity;
            }
            else
            {
                MessageBox.Show("Not enough stock.");
            }
        }
        public void SetPayment(Payment payment)
        {
            PaymentMethod = payment;
        }
        public void ProcessOrder()
        {
            Status = OrderStatus.Processing;

            PaymentMethod.Pay(TotalPrice);

            Status = OrderStatus.Shipped;

            MessageBox.Show("Order Shipped Successfully");
        }
    }
}