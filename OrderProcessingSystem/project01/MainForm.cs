using OrderProcessingSystem.Models;
using System;
using System.Windows.Forms;

namespace project01
{
    public partial class MainForm : Form
    {
        Order currentOrder = new Order();

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // 👤 Customers (آمن بدون constructor)
                cmbCustomer.Items.Add(new Customer { Id = "1", Name = "Yahia", Email = "y@email.com" });
                cmbCustomer.Items.Add(new Customer { Id = "2", Name = "Ahmed", Email = "a@email.com" });

                // 📦 Products
                lstProducts.Items.Add(new ElectronicsProduct("1", "Laptop", 1000m, 5));
                lstProducts.Items.Add(new ElectronicsProduct("2", "Mouse", 50m, 10));

                // 💳 Payment
                cmbPayment.Items.Add("Cash");
                cmbPayment.Items.Add("Card");
                cmbPayment.Items.Add("PayPal");

                cmbCustomer.SelectedIndex = 0;
                lstProducts.SelectedIndex = 0;
                cmbPayment.SelectedIndex = 0;

                // 📊 Grid setup
                dgvOrderItems.Columns.Clear();
                dgvOrderItems.Columns.Add("Product", "Product");
                dgvOrderItems.Columns.Add("Qty", "Qty");
                dgvOrderItems.Columns.Add("Price", "Price");
                dgvOrderItems.Columns.Add("Subtotal", "Subtotal");

                dgvOrderItems.AllowUserToAddRows = false;
                dgvOrderItems.ReadOnly = true;

                lblStatus.Text = "Status: Pending";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem is not Product p)
            {
                MessageBox.Show("Select product!");
                return;
            }

            int qty = (int)numQuantity.Value;

            if (qty <= 0)
            {
                MessageBox.Show("Enter valid quantity");
                return;
            }

            currentOrder.AddProduct(p, qty);

            dgvOrderItems.Rows.Add(
                p.Name,
                qty,
                p.Price.ToString("0.00"),
                (p.Price * qty).ToString("0.00")
            );
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            lblTotal.Text = $"Total: {currentOrder.Total:0.00}";
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem is not Customer c)
            {
                MessageBox.Show("Select customer!");
                return;
            }

            currentOrder.Customer = c;

            lblStatus.Text = "Status: Processing";

            MessageBox.Show(
                $"Order Confirmed!\nCustomer: {c.Name}\nTotal: {currentOrder.Total:0.00}"
            );
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Customer clicked");
        }
    }
}