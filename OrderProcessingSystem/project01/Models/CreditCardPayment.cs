using System.Windows.Forms;

namespace OrderProcessingSystem.Models
{
    public class CreditCardPayment : Payment
    {
        public override void Pay(double amount)
        {
            MessageBox.Show(
                $"Credit Card Payment Completed: ${amount}"
            );
        }
    }
}