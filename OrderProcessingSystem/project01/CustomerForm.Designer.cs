namespace project01
{
    partial class lstCustomers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            label4 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 48);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = " Customer Form   ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 160);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 118);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(182, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(210, 23);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(292, 23);
            txtEmail.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(246, 220);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Customer ";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 295);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 6;
            label4.Text = " List of Customers ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(219, 325);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(233, 109);
            listBox1.TabIndex = 7;
            // 
            // lstCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "lstCustomers";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtEmail;
        private Button btnSave;
        private Label label4;
        private ListBox listBox1;
    }
}
