using System.Windows.Forms;

namespace OrderProcessingSystem.Models
{
    public class PaypalPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            MessageBox.Show($"PayPal Payment Completed: {amount:C}");
        }
    }
}
