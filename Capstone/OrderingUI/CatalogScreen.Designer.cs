namespace OrderingUI
{
    partial class CatalogScreen
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
            this.grpCatalogHeader = new System.Windows.Forms.GroupBox();
            this.txtQuarter = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblQuarter = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.grpProductList = new System.Windows.Forms.GroupBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grpCatalogHeader.SuspendLayout();
            this.grpProductList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCatalogHeader
            // 
            this.grpCatalogHeader.Controls.Add(this.txtId);
            this.grpCatalogHeader.Controls.Add(this.txtQuarter);
            this.grpCatalogHeader.Controls.Add(this.txtNotes);
            this.grpCatalogHeader.Controls.Add(this.lblNotes);
            this.grpCatalogHeader.Controls.Add(this.cboStatus);
            this.grpCatalogHeader.Controls.Add(this.lblStatus);
            this.grpCatalogHeader.Controls.Add(this.lblQuarter);
            this.grpCatalogHeader.Controls.Add(this.lblOrderId);
            this.grpCatalogHeader.Location = new System.Drawing.Point(12, 6);
            this.grpCatalogHeader.Name = "grpCatalogHeader";
            this.grpCatalogHeader.Size = new System.Drawing.Size(598, 241);
            this.grpCatalogHeader.TabIndex = 4;
            this.grpCatalogHeader.TabStop = false;
            this.grpCatalogHeader.Text = "Order Details: ";
            // 
            // txtQuarter
            // 
            this.txtQuarter.Location = new System.Drawing.Point(12, 96);
            this.txtQuarter.Name = "txtQuarter";
            this.txtQuarter.Size = new System.Drawing.Size(200, 22);
            this.txtQuarter.TabIndex = 13;
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
            "Active",
            "Inactive",
            "Closed"});
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
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // lblQuarter
            // 
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Location = new System.Drawing.Point(12, 75);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(61, 17);
            this.lblQuarter.TabIndex = 8;
            this.lblQuarter.Text = "Quarter:";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(12, 29);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(77, 17);
            this.lblOrderId.TabIndex = 6;
            this.lblOrderId.Text = "Catalog ID:";
            // 
            // grpProductList
            // 
            this.grpProductList.Controls.Add(this.btnDelete);
            this.grpProductList.Controls.Add(this.btnAddItem);
            this.grpProductList.Controls.Add(this.cboProducts);
            this.grpProductList.Location = new System.Drawing.Point(12, 253);
            this.grpProductList.Name = "grpProductList";
            this.grpProductList.Size = new System.Drawing.Size(598, 217);
            this.grpProductList.TabIndex = 5;
            this.grpProductList.TabStop = false;
            this.grpProductList.Text = "Product List:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(435, 23);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(82, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(7, 22);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(422, 24);
            this.cboProducts.TabIndex = 0;
            this.cboProducts.SelectedIndexChanged += new System.EventHandler(this.cboProducts_SelectedIndexChanged);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(535, 489);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 49);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(200, 22);
            this.txtId.TabIndex = 14;
            // 
            // CatalogScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.grpCatalogHeader);
            this.Controls.Add(this.grpProductList);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCancel);
            this.Name = "CatalogScreen";
            this.Text = "CatalogScreen";
            this.Load += new System.EventHandler(this.CatalogScreen_Load);
            this.grpCatalogHeader.ResumeLayout(false);
            this.grpCatalogHeader.PerformLayout();
            this.grpProductList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCatalogHeader;
        private System.Windows.Forms.TextBox txtQuarter;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.GroupBox grpProductList;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtId;
    }
}