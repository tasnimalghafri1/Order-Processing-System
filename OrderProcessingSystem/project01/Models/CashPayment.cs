using System.Windows.Forms;

namespace OrderProcessingSystem.Models
{
    public class CashPayment : Payment
    {
        public override void Pay(double amount)
        {
            MessageBox.Show(
                $"Cash Payment Completed: ${amount}"
            );
        }
    }
}