namespace project01
{
    partial class MainForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbCustomer = new ComboBox();
            btnAddCustomer = new Button();
            lstProducts = new ListBox();
            label4 = new Label();
            numQuantity = new NumericUpDown();
            btnAddToOrder = new Button();
            label5 = new Label();
            label6 = new Label();
            dgvOrderItems = new DataGridView();
            label7 = new Label();
            cmbPayment = new ComboBox();
            btnCalculateTotal = new Button();
            btnConfirmOrder = new Button();
            lblStatus = new Label();
            lblTotal = new Label();

            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();

            SuspendLayout();

            // 🔹 إعداد العناصر
            label1.AutoSize = true;
            label1.Location = new Point(234, 51);
            label1.Text = "Order Processing System";

            btnAddCustomer.Location = new Point(433, 108);
            btnAddCustomer.Text = "Add customer";

            // 🔹 الأحداث
            btnAddCustomer.Click += btnAddCustomer_Click;
            btnAddToOrder.Click += btnAddToOrder_Click;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            btnConfirmOrder.Click += btnConfirmOrder_Click;

            // 🔹 إضافة العناصر للفورم (آخر خطوة)
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cmbCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(lstProducts);
            Controls.Add(label4);
            Controls.Add(numQuantity);
            Controls.Add(btnAddToOrder);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dgvOrderItems);
            Controls.Add(label7);
            Controls.Add(cmbPayment);
            Controls.Add(btnCalculateTotal);
            Controls.Add(btnConfirmOrder);
            Controls.Add(lblStatus);
            Controls.Add(lblTotal);

            // 🔹 إعداد الفورم
            Name = "MainForm";
            Text = "Add To Order";

            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbCustomer;
        private Button btnAddCustomer;
        private ListBox lstProducts;
        private Label label4;
        private NumericUpDown numQuantity;
        private Button btnAddToOrder;
        private Label label5;
        private Label label6;
        private DataGridView dgvOrderItems;
        private Label label7;
        private ComboBox cmbPayment;
        private Button btnCalculateTotal;
        private Button btnConfirmOrder;
        private Label lblStatus;
        private Label lblTotal;
    }
}