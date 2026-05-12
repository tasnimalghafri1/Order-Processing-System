namespace OrderProcessingSystem.Models
{
    public abstract class Product
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        protected Product(string id, string name, decimal price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            StockQuantity = stock;
        }

        public abstract decimal CalculateDiscount();
    }
}