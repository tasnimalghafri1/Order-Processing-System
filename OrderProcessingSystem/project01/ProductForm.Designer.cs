namespace project01
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstProductList = new ListBox();
            label4 = new Label();
            btnAddProduct = new Button();
            txtPrice = new TextBox();
            txtProductName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtStock = new TextBox();
            SuspendLayout();

            // lstProductList
            lstProductList.FormattingEnabled = true;
            lstProductList.ItemHeight = 15;
            lstProductList.Location = new Point(322, 309);
            lstProductList.Name = "lstProductList";
            lstProductList.Size = new Size(233, 109);

            // label4
            label4.AutoSize = true;
            label4.Location = new Point(322, 279);
            label4.Text = "Products List";

            // btnAddProduct
            btnAddProduct.Location = new Point(349, 224);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(135, 23);
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;

            // txtPrice
            txtPrice.Location = new Point(285, 141);
            txtPrice.Size = new Size(90, 23);

            // txtProductName
            txtProductName.Location = new Point(285, 99);
            txtProductName.Size = new Size(186, 23);

            // label3
            label3.AutoSize = true;
            label3.Location = new Point(223, 102);
            label3.Text = "Name";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(226, 144);
            label2.Text = "Price";

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(322, 32);
            label1.Text = "Product Form";

            // label5
            label5.AutoSize = true;
            label5.Location = new Point(229, 181);
            label5.Text = "Quantity";

            // txtStock
            txtStock.Location = new Point(285, 178);
            txtStock.Size = new Size(186, 23);

            // ProductForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(lstProductList);
            Controls.Add(label4);
            Controls.Add(btnAddProduct);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);

            Name = "ProductForm";
            Text = "ProductForm";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstProductList;
        private Label label4;
        private Button btnAddProduct;
        private TextBox txtPrice;
        private TextBox txtProductName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtStock;
    }
}