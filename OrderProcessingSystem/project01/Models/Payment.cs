using OrderProcessingSystem.Interfaces;

namespace OrderProcessingSystem.Models
{
    public abstract class Payment : IPayable
    {
        public abstract void Pay(decimal amount);
    }
}