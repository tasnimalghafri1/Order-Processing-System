using OrderProcessingSystem.Interfaces;
using System.Windows.Forms;

namespace OrderProcessingSystem.Models
{
    public class CashPayment : IPayable
    {
        public void Pay(decimal amount)
        {
            MessageBox.Show($"Cash payment completed successfully.\nAmount: {amount:C}");
        }
    }
}