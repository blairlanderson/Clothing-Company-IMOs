namespace OrderingUI
{
    partial class OrderScreen
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
            this.grpOrderHeader = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.grpCartInfo = new System.Windows.Forms.GroupBox();
            this.btnUpdateCart = new System.Windows.Forms.Button();
            this.cboCart = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.grpOrderHeader.SuspendLayout();
            this.grpCartInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrderHeader
            // 
            this.grpOrderHeader.Controls.Add(this.txtNotes);
            this.grpOrderHeader.Controls.Add(this.lblNotes);
            this.grpOrderHeader.Controls.Add(this.cboStatus);
            this.grpOrderHeader.Controls.Add(this.lblStatus);
            this.grpOrderHeader.Controls.Add(this.cboCustomer);
            this.grpOrderHeader.Controls.Add(this.lblCompany);
            this.grpOrderHeader.Controls.Add(this.txtOrderId);
            this.grpOrderHeader.Controls.Add(this.lblOrderId);
            this.grpOrderHeader.Location = new System.Drawing.Point(12, 0);
            this.grpOrderHeader.Name = "grpOrderHeader";
            this.grpOrderHeader.Size = new System.Drawing.Size(598, 241);
            this.grpOrderHeader.TabIndex = 0;
            this.grpOrderHeader.TabStop = false;
            this.grpOrderHeader.Text = "Order Details: ";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 142);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(580, 82);
            this.txtNotes.TabIndex = 1;
            this.txtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 122);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(53, 17);
            this.lblNotes.TabIndex = 12;
            this.lblNotes.Text = "Notes: ";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "",
            "New",
            "Paid",
            "Shipped",
            "Completed"});
            this.cboStatus.Location = new System.Drawing.Point(325, 96);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(205, 24);
            this.cboStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(322, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(93, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Order Status:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(12, 95);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(205, 24);
            this.cboCustomer.TabIndex = 9;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(12, 75);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(76, 17);
            this.lblCompany.TabIndex = 8;
            this.lblCompany.Text = "Customer: ";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(12, 50);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(200, 22);
            this.txtOrderId.TabIndex = 7;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(12, 29);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(66, 17);
            this.lblOrderId.TabIndex = 6;
            this.lblOrderId.Text = "Order ID:";
            // 
            // grpCartInfo
            // 
            this.grpCartInfo.Controls.Add(this.btnAddItem);
            this.grpCartInfo.Controls.Add(this.btnUpdateCart);
            this.grpCartInfo.Controls.Add(this.cboCart);
            this.grpCartInfo.Location = new System.Drawing.Point(12, 247);
            this.grpCartInfo.Name = "grpCartInfo";
            this.grpCartInfo.Size = new System.Drawing.Size(598, 217);
            this.grpCartInfo.TabIndex = 1;
            this.grpCartInfo.TabStop = false;
            this.grpCartInfo.Text = "Cart:";
            // 
            // btnUpdateCart
            // 
            this.btnUpdateCart.Location = new System.Drawing.Point(435, 22);
            this.btnUpdateCart.Name = "btnUpdateCart";
            this.btnUpdateCart.Size = new System.Drawing.Size(82, 23);
            this.btnUpdateCart.TabIndex = 1;
            this.btnUpdateCart.Text = "Update";
            this.btnUpdateCart.UseVisualStyleBackColor = true;
            this.btnUpdateCart.Click += new System.EventHandler(this.btnUpdateCart_Click);
            // 
            // cboCart
            // 
            this.cboCart.FormattingEnabled = true;
            this.cboCart.Location = new System.Drawing.Point(7, 22);
            this.cboCart.Name = "cboCart";
            this.cboCart.Size = new System.Drawing.Size(422, 24);
            this.cboCart.TabIndex = 0;
            this.cboCart.SelectedIndexChanged += new System.EventHandler(this.cboCart_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 483);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(535, 483);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(435, 51);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(82, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpCartInfo);
            this.Controls.Add(this.grpOrderHeader);
            this.Name = "OrderScreen";
            this.Text = "OrderScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderScreen_Load);
            this.grpOrderHeader.ResumeLayout(false);
            this.grpOrderHeader.PerformLayout();
            this.grpCartInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrderHeader;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.GroupBox grpCartInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnUpdateCart;
        private System.Windows.Forms.ComboBox cboCart;
    }
}