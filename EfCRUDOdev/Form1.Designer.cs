namespace EfCRUDOdev
{
    partial class Form1
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
            lvOrderDetail = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lvShipperName = new ListView();
            lvEmployeeName = new ListView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnGetOrderList = new Button();
            SuspendLayout();
            // 
            // lvOrderDetail
            // 
            lvOrderDetail.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvOrderDetail.FullRowSelect = true;
            lvOrderDetail.GridLines = true;
            lvOrderDetail.Location = new Point(225, 82);
            lvOrderDetail.Name = "lvOrderDetail";
            lvOrderDetail.Size = new Size(483, 329);
            lvOrderDetail.TabIndex = 20;
            lvOrderDetail.UseCompatibleStateImageBehavior = false;
            lvOrderDetail.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "OrderID";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Order Date";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ship City";
            columnHeader3.Width = 150;
            // 
            // lvShipperName
            // 
            lvShipperName.Location = new Point(12, 291);
            lvShipperName.Name = "lvShipperName";
            lvShipperName.Size = new Size(155, 120);
            lvShipperName.TabIndex = 19;
            lvShipperName.UseCompatibleStateImageBehavior = false;
            lvShipperName.View = View.List;
            // 
            // lvEmployeeName
            // 
            lvEmployeeName.Location = new Point(12, 82);
            lvEmployeeName.Name = "lvEmployeeName";
            lvEmployeeName.Size = new Size(155, 177);
            lvEmployeeName.TabIndex = 18;
            lvEmployeeName.UseCompatibleStateImageBehavior = false;
            lvEmployeeName.View = View.List;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(389, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 36);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(603, 23);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 35);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(200, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 35);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGetOrderList
            // 
            btnGetOrderList.Location = new Point(12, 22);
            btnGetOrderList.Name = "btnGetOrderList";
            btnGetOrderList.Size = new Size(102, 36);
            btnGetOrderList.TabIndex = 14;
            btnGetOrderList.Text = "Ger Order List";
            btnGetOrderList.UseVisualStyleBackColor = true;
            btnGetOrderList.Click += btnGetOrderList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 432);
            Controls.Add(lvOrderDetail);
            Controls.Add(lvShipperName);
            Controls.Add(lvEmployeeName);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnGetOrderList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvOrderDetail;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lvShipperName;
        private ListView lvEmployeeName;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnGetOrderList;
    }
}