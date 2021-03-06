﻿namespace ManufacturingTest2
{
    partial class AddProductChangeMaterial
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
            this.notAddedListBox = new System.Windows.Forms.ListBox();
            this.addedListBox = new System.Windows.Forms.ListBox();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnRemoveMaterial = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notAddedListBox
            // 
            this.notAddedListBox.FormattingEnabled = true;
            this.notAddedListBox.ItemHeight = 16;
            this.notAddedListBox.Location = new System.Drawing.Point(16, 15);
            this.notAddedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notAddedListBox.Name = "notAddedListBox";
            this.notAddedListBox.Size = new System.Drawing.Size(199, 420);
            this.notAddedListBox.TabIndex = 0;
            // 
            // addedListBox
            // 
            this.addedListBox.FormattingEnabled = true;
            this.addedListBox.ItemHeight = 16;
            this.addedListBox.Location = new System.Drawing.Point(460, 15);
            this.addedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addedListBox.Name = "addedListBox";
            this.addedListBox.Size = new System.Drawing.Size(199, 420);
            this.addedListBox.TabIndex = 1;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(309, 113);
            this.btnAddMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(100, 28);
            this.btnAddMaterial.TabIndex = 2;
            this.btnAddMaterial.Text = "Add";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnRemoveMaterial
            // 
            this.btnRemoveMaterial.Location = new System.Drawing.Point(309, 149);
            this.btnRemoveMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveMaterial.TabIndex = 3;
            this.btnRemoveMaterial.Text = "Remove";
            this.btnRemoveMaterial.UseVisualStyleBackColor = true;
            this.btnRemoveMaterial.Click += new System.EventHandler(this.btnRemoveMaterial_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(309, 185);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 28);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(309, 81);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(99, 22);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantity:";
            // 
            // AddProductChangeMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRemoveMaterial);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.addedListBox);
            this.Controls.Add(this.notAddedListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProductChangeMaterial";
            this.Text = "Add/Remote Material to Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductChangeMaterial_FormClosing);
            this.Load += new System.EventHandler(this.AddProductChangeMaterial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox notAddedListBox;
        private System.Windows.Forms.ListBox addedListBox;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnRemoveMaterial;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
    }
}