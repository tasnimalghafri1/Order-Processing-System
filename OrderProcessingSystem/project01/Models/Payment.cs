using OrderProcessingSystem.Interfaces;

namespace OrderProcessingSystem.Models
{
    public abstract class Payment : IPayable
    {
        // Abstract Method
        public abstract void Pay(double amount);
    }
}