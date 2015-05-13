namespace ManufacturingTest2
{
    partial class AddProduct
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductNotes = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NotAddedMaterials = new System.Windows.Forms.ListBox();
            this.AddedMaterialsList = new System.Windows.Forms.ListBox();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnRemoveMaterial = new System.Windows.Forms.Button();
            this.txtMaterialQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(280, 325);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 28);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Confirm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductNotes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ProductCost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(364, 303);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter A Material";
            // 
            // ProductNotes
            // 
            this.ProductNotes.Location = new System.Drawing.Point(125, 150);
            this.ProductNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductNotes.Name = "ProductNotes";
            this.ProductNotes.Size = new System.Drawing.Size(229, 130);
            this.ProductNotes.TabIndex = 7;
            this.ProductNotes.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // ProductCost
            // 
            this.ProductCost.Location = new System.Drawing.Point(195, 114);
            this.ProductCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.Size = new System.Drawing.Size(160, 22);
            this.ProductCost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(195, 49);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(160, 22);
            this.ProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NotAddedMaterials
            // 
            this.NotAddedMaterials.FormattingEnabled = true;
            this.NotAddedMaterials.ItemHeight = 16;
            this.NotAddedMaterials.Location = new System.Drawing.Point(388, 25);
            this.NotAddedMaterials.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NotAddedMaterials.Name = "NotAddedMaterials";
            this.NotAddedMaterials.Size = new System.Drawing.Size(196, 196);
            this.NotAddedMaterials.TabIndex = 4;
            // 
            // AddedMaterialsList
            // 
            this.AddedMaterialsList.FormattingEnabled = true;
            this.AddedMaterialsList.ItemHeight = 16;
            this.AddedMaterialsList.Location = new System.Drawing.Point(701, 25);
            this.AddedMaterialsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddedMaterialsList.Name = "AddedMaterialsList";
            this.AddedMaterialsList.Size = new System.Drawing.Size(269, 196);
            this.AddedMaterialsList.TabIndex = 5;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(593, 100);
            this.btnAddMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(100, 28);
            this.btnAddMaterial.TabIndex = 6;
            this.btnAddMaterial.Text = "Add Material";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnRemoveMaterial
            // 
            this.btnRemoveMaterial.Location = new System.Drawing.Point(593, 176);
            this.btnRemoveMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveMaterial.TabIndex = 7;
            this.btnRemoveMaterial.Text = "Remove Material";
            this.btnRemoveMaterial.UseVisualStyleBackColor = true;
            this.btnRemoveMaterial.Click += new System.EventHandler(this.btnRemoveMaterial_Click);
            // 
            // txtMaterialQuantity
            // 
            this.txtMaterialQuantity.Location = new System.Drawing.Point(593, 68);
            this.txtMaterialQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaterialQuantity.Name = "txtMaterialQuantity";
            this.txtMaterialQuantity.Size = new System.Drawing.Size(99, 22);
            this.txtMaterialQuantity.TabIndex = 8;
            this.txtMaterialQuantity.Text = "1";
            this.txtMaterialQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaterialQuantity);
            this.Controls.Add(this.btnRemoveMaterial);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.AddedMaterialsList);
            this.Controls.Add(this.NotAddedMaterials);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProduct_FormClosing);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox ProductNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox NotAddedMaterials;
        private System.Windows.Forms.ListBox AddedMaterialsList;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnRemoveMaterial;
        private System.Windows.Forms.TextBox txtMaterialQuantity;
        private System.Windows.Forms.Label label2;
    }
}