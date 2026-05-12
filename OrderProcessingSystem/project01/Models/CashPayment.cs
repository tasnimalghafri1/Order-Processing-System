using OrderProcessingSystem.Interfaces;
using System.Windows.Forms;

namespace OrderProcessingSystem.Models
{
    public class CashPayment : IPayable
    {
        public void Pay(decimal amount)
        {
            MessageBox.Show($"Cash Payment completed successfully.\nAmount: {amount:C}");
        }
    }
}