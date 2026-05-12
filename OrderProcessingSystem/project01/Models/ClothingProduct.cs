namespace OrderProcessingSystem.Models
{
    public class ClothingProduct : Product
    {
        public ClothingProduct(string id, string name, decimal price, int stockQuantity)
            : base(id, name, price, stockQuantity)
        {
        }

        public override decimal CalculateDiscount()
        {
            return Price * 0.05m;
        }
    }
}