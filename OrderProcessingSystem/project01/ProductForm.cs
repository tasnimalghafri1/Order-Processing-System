using OrderProcessingSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project01
{
    public partial class ProductForm : Form
    {
        public static List<Product> Products = new List<Product>();

        public ProductForm()
        {
            InitializeComponent();

            // 🔥 ربط زر الإضافة (مهم جداً)
            btnAddProduct.Click += btnAddProduct_Click;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Enter Product Name");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid Price");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Invalid Stock");
                return;
            }

            // 🔥 إنشاء المنتج (لازم كلاس مشتق)
            Product p = new ElectronicsProduct(
                Guid.NewGuid().ToString(),
                txtProductName.Text,
                price,
                stock
            );

            Products.Add(p);

            // 🔥 تحديث القائمة
            lstProductList.Items.Clear();

            foreach (var item in Products)
            {
                lstProductList.Items.Add(item.Name);
            }

            MessageBox.Show("Product Added!");

            // تنظيف الحقول
            txtProductName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }
    }
}