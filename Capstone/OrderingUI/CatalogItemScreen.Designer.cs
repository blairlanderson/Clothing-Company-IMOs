namespace OrderingUI
{
    partial class CatalogItemScreen
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
            this.grpCatalogItemHeader = new System.Windows.Forms.GroupBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtCatalogId = new System.Windows.Forms.TextBox();
            this.lblCatalogId = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCatalogItemHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCatalogItemHeader
            // 
            this.grpCatalogItemHeader.Controls.Add(this.btnDetails);
            this.grpCatalogItemHeader.Controls.Add(this.cboProduct);
            this.grpCatalogItemHeader.Controls.Add(this.lblProduct);
            this.grpCatalogItemHeader.Controls.Add(this.txtCatalogId);
            this.grpCatalogItemHeader.Controls.Add(this.lblCatalogId);
            this.grpCatalogItemHeader.Location = new System.Drawing.Point(12, 12);
            this.grpCatalogItemHeader.Name = "grpCatalogItemHeader";
            this.grpCatalogItemHeader.Size = new System.Drawing.Size(598, 144);
            this.grpCatalogItemHeader.TabIndex = 14;
            this.grpCatalogItemHeader.TabStop = false;
            this.grpCatalogItemHeader.Text = "Add Product: ";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(223, 97);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 14;
            this.btnDetails.Text = "Details..";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Items.AddRange(new object[] {
            "Product 1",
            "Product 2",
            "Product 3"});
            this.cboProduct.Location = new System.Drawing.Point(12, 95);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(205, 24);
            this.cboProduct.TabIndex = 9;
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(12, 75);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(61, 17);
            this.lblProduct.TabIndex = 8;
            this.lblProduct.Text = "Product:";
            // 
            // txtCatalogId
            // 
            this.txtCatalogId.Location = new System.Drawing.Point(12, 50);
            this.txtCatalogId.Name = "txtCatalogId";
            this.txtCatalogId.ReadOnly = true;
            this.txtCatalogId.Size = new System.Drawing.Size(200, 22);
            this.txtCatalogId.TabIndex = 7;
            // 
            // lblCatalogId
            // 
            this.lblCatalogId.AutoSize = true;
            this.lblCatalogId.Location = new System.Drawing.Point(12, 29);
            this.lblCatalogId.Name = "lblCatalogId";
            this.lblCatalogId.Size = new System.Drawing.Size(77, 17);
            this.lblCatalogId.TabIndex = 6;
            this.lblCatalogId.Text = "Catalog ID:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(528, 483);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(82, 23);
            this.btnAddItem.TabIndex = 16;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 483);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CatalogItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.grpCatalogItemHeader);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnCancel);
            this.Name = "CatalogItemScreen";
            this.Text = "CatalogItemScreen";
            this.Load += new System.EventHandler(this.CatalogItemScreen_Load);
            this.grpCatalogItemHeader.ResumeLayout(false);
            this.grpCatalogItemHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCatalogItemHeader;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtCatalogId;
        private System.Windows.Forms.Label lblCatalogId;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCancel;
    }
}