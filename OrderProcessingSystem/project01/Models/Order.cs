using OrderProcessingSystem.Models;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public string Id { get; set; } = string.Empty;
    public Customer Customer { get; set; }
    public List<OrderItem> Items = new List<OrderItem>();

    public OrderStatus Status { get; set; } = OrderStatus.Pending;

    public decimal Total
    {
        get { return Items.Sum(i => i.SubTotal); }
    }

    public void AddProduct(Product p, int qty)
    {
        Items.Add(new OrderItem(p, qty));
    }
}

