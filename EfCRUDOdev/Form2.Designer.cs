namespace EfCRUDOdev
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            txtShipcity = new TextBox();
            cbxOrderDate = new DateTimePicker();
            cbxShipper = new ComboBox();
            cbxEmployee = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(118, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 36);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtShipcity
            // 
            txtShipcity.Location = new Point(118, 144);
            txtShipcity.Name = "txtShipcity";
            txtShipcity.Size = new Size(127, 23);
            txtShipcity.TabIndex = 25;
            // 
            // cbxOrderDate
            // 
            cbxOrderDate.Location = new Point(118, 81);
            cbxOrderDate.Name = "cbxOrderDate";
            cbxOrderDate.Size = new Size(200, 23);
            cbxOrderDate.TabIndex = 24;
            // 
            // cbxShipper
            // 
            cbxShipper.FormattingEnabled = true;
            cbxShipper.Location = new Point(118, 207);
            cbxShipper.Name = "cbxShipper";
            cbxShipper.Size = new Size(128, 23);
            cbxShipper.TabIndex = 23;
            // 
            // cbxEmployee
            // 
            cbxEmployee.FormattingEnabled = true;
            cbxEmployee.Location = new Point(118, 30);
            cbxEmployee.Name = "cbxEmployee";
            cbxEmployee.Size = new Size(128, 23);
            cbxEmployee.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 210);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 21;
            label4.Text = "Shipper";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 147);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 20;
            label3.Text = "Ship City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 87);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 19;
            label2.Text = "Order Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 18;
            label1.Text = "Employee";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 357);
            Controls.Add(btnAdd);
            Controls.Add(txtShipcity);
            Controls.Add(cbxOrderDate);
            Controls.Add(cbxShipper);
            Controls.Add(cbxEmployee);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtShipcity;
        private DateTimePicker cbxOrderDate;
        private ComboBox cbxShipper;
        private ComboBox cbxEmployee;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}