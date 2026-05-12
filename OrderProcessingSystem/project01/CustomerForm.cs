using OrderProcessingSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project01
{
    public partial class lstCustomers : Form
    {
        public lstCustomers()
        {
            InitializeComponent();
        }

        List<Customer> customers = new List<Customer>();

        private void lstCustomers_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            Customer c = new Customer(
                Guid.NewGuid().ToString(),
                txtName.Text,
                txtEmail.Text
            );

            customers.Add(c);

            listBox1.Items.Add(c);

            MessageBox.Show("Customer Added");

            txtName.Clear();
            txtEmail.Clear();
        }
    }
}